using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zkemkeeper;

namespace ZKTecoDown
{

    internal struct User {
        public string Name;
        public string Password;
        public string ID;
        public int Privilege;
        public bool Enabled;

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
    }

    internal class MachineConnection
    {
        private zkemkeeper.CZKEM reloj;
        private bool Connected;
        public readonly string MachineAlias;
        public readonly List<User> userInfo;
        public readonly List<AttendanceRecord> attendanceRecords;
        public MachineConnection()
        {
            reloj = new zkemkeeper.CZKEM();
            Connected = false;
            userInfo = new List<User>();
            attendanceRecords = new List<AttendanceRecord>();
        }

        ~MachineConnection()
        {
            this.Disconnect();
        }

        public bool Connect(string MachineAlias, string ip, int port)
        {
            if (reloj.Connect_Net(ip, port))
            {
                Connected = true;
                return Connected;
            }
            return Connected;
        }

        public bool isConnected()
        {
            return Connected;
        }

        public void Disconnect()
        {
            Connected = false;
            reloj.Disconnect();
        }
        public bool DownloadUsers()
        {
            if (!reloj.ReadAllUserID(0))
                return false;

            bool reading = true;
            User tmpusr = new User();
            while (reading)
            {
                reading = reloj.SSR_GetAllUserInfo(0,
                                                   out tmpusr.ID,
                                                   out tmpusr.Name,
                                                   out tmpusr.Password,
                                                   out tmpusr.Privilege,
                                                   out tmpusr.Enabled);
                userInfo.Add(tmpusr);

            }
            return true;
        }

        public bool DownloadAttendance(bool eraseAfterward)
        {
            if (!reloj.ReadGeneralLogData(0))
                return false;

            bool reading = true;
            AttendanceRecord tmpattrec = new AttendanceRecord();
            while (reading)
            {
                reading = reloj.SSR_GetGeneralLogData(0,
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
                attendanceRecords.Add(tmpattrec);

            }
            if (eraseAfterward)
                reloj.ClearGLog(0);
            return true;
        }

        public bool DeleteUser(string ID)
        {
            return reloj.SSR_DeleteEnrollData(0, ID, 12);
        }


    }
}
