using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class StudentAttendenceClass
    {
        private int AttendanceId;
        private int StudentId;
        private int AttendanceStatus;

        public int AttendanceId1
        {
            get
            {
                return AttendanceId;
            }

            set
            {
                AttendanceId = value;
            }
        }

        public int StudentId1
        {
            get
            {
                return StudentId;
            }

            set
            {
                StudentId = value;
            }
        }

        public int AttendanceStatus1
        {
            get
            {
                return AttendanceStatus;
            }

            set
            {
                AttendanceStatus = value;
            }
        }
       
        public void addStudentname()
        {
            string query = "Select RegistrationNumber from Student";
            Connection C1 = new Connection();
            C1.NameForStudentList(query);
        }
        public void AddAttendenceDate()
        {
            string query = "Select AttendanceDate from ClassAttendance";
            Connection C1 = new Connection();
            C1.DateForAttendence(query);
        }

        public void ADD(string stuName, string Attendence, string status)
        {
            Connection C1 = new Connection();
            int AttendenceStatus = 0;
            if(status == "Present")
            {
                AttendenceStatus = 1;
            }
            else if (status == "Absent")
            {
                AttendenceStatus = 2;
            }
            else if (status == "Leave")
            {
                AttendenceStatus = 3;
            }
            else if (status == "Late")
            {
                AttendenceStatus = 4;
            }
            string query3 = "select Id FROM Student where RegistrationNumber = '" + stuName + "'";
            int stuId = C1.get_Id_clo(query3);
            string query4 = "select Id FROM ClassAttendance where AttendanceDate = '" + Attendence + "'";
            int attendence = C1.get_Id_clo(query4);
            if (stuId >= 0)
            {
                string Insertquery = "Insert into StudentAttendance (AttendanceId ,StudentId,AttendanceStatus) VALUES('" + attendence + "','" + stuId + "','" + AttendenceStatus +  "')";
                C1.Insertion(Insertquery);
            }
        }
        public void Record()
        {
            string query = "SELECT * FROM StudentAttendance";
            Connection C1 = new Connection();
            C1.StudentAttendenceRecord(query);

        }
        public void Delete(int id, int Assid)
        {
            string query = "Delete FROM StudentAttendance where StudentId = " + id + " and AttendanceId = " + Assid;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
       
       
        public string RegistrationNoStudent(int id)
        {
            string result;
            string query = "select RegistrationNumber FROM Student where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
        public string AttendenceDate(int id)
        {
            string result;
            string query = "select AttendanceDate FROM ClassAttendance where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
        public string Staus(int id)
        {
            string status = "";
            if (id == 1)
            {
                status = "Present";
            }
            else if (id == 2)
            {
                status = "Absent";
            }
            else if (id == 3)
            {
                status = "Leave";
            }
            else if (id == 4)
            {
                status= "Left";
            }
            return status;
        }
        public void Edit(int stid, int AttendenceId,string stuName,string AttendenceDate, string status)
        {
            Connection C1 = new Connection();
            int AttendenceStatus = 0;
            if (status == "Present")
            {
                AttendenceStatus = 1;
            }
            else if (status == "Absent")
            {
                AttendenceStatus = 2;
            }
            else if (status == "Leave")
            {
                AttendenceStatus = 3;
            }
            else if (status == "Late")
            {
                AttendenceStatus = 4;
            }
            string query3 = "select Id FROM Student where RegistrationNumber = '" + stuName + "'";
            int stuId = C1.get_Id_clo(query3);
            string query4 = "select Id FROM ClassAttendance where AttendanceDate = '" + AttendenceDate + "'";
            int AttendancedateId = C1.get_Id_clo(query4);
            if (stuId >= 0)
            {
                string query1 = "UPDATE StudentAttendance SET  studentId = '" + stuId + "',   AttendanceStatus = '" + AttendenceStatus + "',   AttendanceId = '" + AttendancedateId + "' where StudentId = " + stid + " and AttendanceId = " + AttendenceId;
                C1.UPdate(query1);
            }
        }
    }
}
