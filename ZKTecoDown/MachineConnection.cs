namespace ZKTecoDown
{

    internal struct User
    {
        public string Name;
        public string Password;
        public string ID;
        public int Privilege;
        public bool Enabled;

        public string[] ToStringArray()
        {
            return new string[] { ID, Name, Privilege.ToString() };
        }
    }
    /* InOutModes
        0-Check-In Default
        1-Check-Out
        2-Break-Out
        3-Break-In
        4-OT-In
        5-OT-Out
    */
    internal struct AttendanceRecord
    {
        public string ID;
        public int VerifyMode;
        public int InOut;
        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public int Second;
        public int WorkCode;

        public string[] ToStringArray()
        {
            var LogDate = new DateTime(Year, Month, Day, Hour, Minute, Second);
            string inoutType;
            switch (InOut)
            {
                case 0:
                    inoutType = "E";
                    break;
                case 1:
                    inoutType = "S";
                    break;
                case 2:
                    inoutType = "1";
                    break;
                case 3:
                    inoutType = "2";
                    break;
                case 4:
                    inoutType = "3";
                    break;
                case 5:
                    inoutType = "4";
                    break;
                default:
                    inoutType = "E";
                    break;
            }
            return new string[] { ID, inoutType, LogDate.ToString() };
        }
    }

    internal class MachineConnection
    {
        private static log4net.ILog? log;
        private zkemkeeper.CZKEM Machine = new();
        private bool Connected = false;
        private int LastErrorCode = 0;
        public string MachineAlias { get; private set; }
        public readonly List<User> userInfo = new();
        public readonly List<AttendanceRecord> attendanceRecords = new();

        public MachineConnection()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger("Connection");
            
            MachineAlias = new("Default");
        }

        ~MachineConnection()
        {
            this.Disconnect();
        }

        public bool Connect(string MachineAlias, string ip, int port)
        {
            log.Info($"Conectando a {MachineAlias} ({ip}:{port}).");
            if (Machine.Connect_Net(ip, port))
            {
                Connected = true;
                this.MachineAlias = MachineAlias;
                log.Info($"Conexion exitosa a {MachineAlias} ({ip}:{port}).");
                return Connected;
            }
            else
            {
                log.Error($"Error al conectar a {MachineAlias} ({ip}:{port}).");
                Machine.GetLastError(ref LastErrorCode);
                return Connected;
            }
        }

        public bool isConnected()
        {
            return Connected;
        }

        public void Disconnect()
        {
            Connected = false;
            log.Info($"Desconexion.");
            Machine.Disconnect();
        }
        public bool DownloadUsers()
        {
            log.Info("Descargando usuarios.");
            if (!Machine.ReadAllUserID(0))
            {
                Machine.GetLastError(ref LastErrorCode);
                log.Error("Error al descargar usuarios.");
                return false;
            }
            userInfo.Clear();
            bool reading = true;
            User tmpusr = new();
            while (reading)
            {
                reading = Machine.SSR_GetAllUserInfo(0,
                                                   out tmpusr.ID,
                                                   out tmpusr.Name,
                                                   out tmpusr.Password,
                                                   out tmpusr.Privilege,
                                                   out tmpusr.Enabled);

                if (reading)
                    userInfo.Add(tmpusr);
            }
            log.Info($"Se descargaron {userInfo.Count()} usuarios.");
            return true;
        }

        public bool DownloadAttendance(bool eraseAfterward)
        {
            log.Info("Comenzando descarga de fichadas");
            attendanceRecords.Clear();

            if (!Machine.ReadGeneralLogData(0))
            {
                Machine.GetLastError(ref LastErrorCode);
                return false;
            }

            bool reading = true;
            AttendanceRecord tmpattrec = new();
            int errCounter = 0;
            do
            {
                reading = Machine.SSR_GetGeneralLogData(0,
                                                   out tmpattrec.ID,
                                                   out tmpattrec.VerifyMode,
                                                   out tmpattrec.InOut,
                                                   out tmpattrec.Year,
                                                   out tmpattrec.Month,
                                                   out tmpattrec.Day,
                                                   out tmpattrec.Hour,
                                                   out tmpattrec.Minute,
                                                   out tmpattrec.Second,
                                                   ref tmpattrec.WorkCode);
                if (reading)
                    attendanceRecords.Add(tmpattrec);


            } while (reading);
            if (eraseAfterward && attendanceRecords.Count() > 0)
            {
                if (Machine.ClearGLog(0))
                {
                    log.Error("Error al eliminar/descargar fichadas.");
                    Machine.GetLastError(ref LastErrorCode);
                    return false;
                }
                log.Info("Eliminacion de fichadas completa.");
            }
            log.Info($"Se descargaron {attendanceRecords.Count()} fichadas.");
            return true;
        }

        public bool DeleteUser(string ID)
        {
            if (!Machine.SSR_DeleteEnrollData(0, ID, 12))
            {
                Machine.GetLastError(LastErrorCode);
                return false;
            }
            log.Info("Se elimino el usuario de ID " + ID);
            DownloadUsers();

            return true;
        }

        public bool AddUser(string ID, string Name)
        {
            if (!Machine.SSR_SetUserInfo(0, ID, Name, "", 0, true))
            {
                Machine.GetLastError(LastErrorCode);
                return false;
            }
            log.Info("Se añadio el usuario " + Name + " con ID " + ID);
            return true;
        }
    }
}
