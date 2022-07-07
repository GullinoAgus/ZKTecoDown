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

    internal class RelojConnection
    {
        private zkemkeeper.CZKEM reloj;
        private List<User> userInfo;
        private List<AttendanceRecord> attendanceRecords;
        RelojConnection()
        {
            reloj = new zkemkeeper.CZKEM();
            userInfo = new List<User>();
            attendanceRecords = new List<AttendanceRecord>();
        }

        ~RelojConnection()
        {
            this.Disconnect();
        }

        public bool Connect(string ip, int port)
        {
            return reloj.Connect_Net(ip, port);
        }

        public void Disconnect()
        {
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
