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
        private zkemkeeper.CZKEM Machine = new();
        private bool Connected = false;
        private int LastErrorCode = 0;
        public readonly string MachineAlias = new("Default");
        public readonly List<User> userInfo = new();
        public readonly List<AttendanceRecord> attendanceRecords = new();

        public MachineConnection()
        {
        }

        ~MachineConnection()
        {
            this.Disconnect();
        }

        public bool Connect(string MachineAlias, string ip, int port)
        {
            if (Machine.Connect_Net(ip, port))
            {
                Connected = true;
                return Connected;
            }
            else
            {
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
            Machine.Disconnect();
        }
        public bool DownloadUsers()
        {
            if (!Machine.ReadAllUserID(0))
            {
                Machine.GetLastError(ref LastErrorCode);
                return false;
            }

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
                userInfo.Add(tmpusr);

            }
            return true;
        }

        public bool DownloadAttendance(bool eraseAfterward)
        {
            if (!Machine.ReadGeneralLogData(0))
            {
                Machine.GetLastError(ref LastErrorCode);
                return false;
            }

            bool reading = true;
            AttendanceRecord tmpattrec = new();
            while (reading)
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
                attendanceRecords.Add(tmpattrec);

            }
            if (eraseAfterward)
            {
                if (Machine.ClearGLog(0))
                {
                    Machine.GetLastError(ref LastErrorCode);
                    return false;
                }
            }
                    
            return true;
        }

        public bool DeleteUser(string ID)
        {
            if (!Machine.SSR_DeleteEnrollData(0, ID, 12))
            {
                Machine.GetLastError(LastErrorCode);
                return false;
            }

            return true;
        }


    }
}
