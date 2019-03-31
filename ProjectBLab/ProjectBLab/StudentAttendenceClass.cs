using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    /// <summary>
    /// This class contain the Datamembers and Functions of the StudentAttendenceClass
    /// </summary>
    class StudentAttendenceClass
    {
        /// <summary>
        ///  Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
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
       
        /// <summary>
        /// Use to add the data in the StudentSelection comobox
        /// </summary>
        public void addStudentname()
        {
            string query = "Select RegistrationNumber from Student";
            Connection C1 = new Connection();
            C1.NameForStudentList(query);
        }

        /// <summary>
        /// Use to add the data in the AttendenceDate comobox
        /// </summary>
        public void AddAttendenceDate()
        {
            string query = "Select AttendanceDate from ClassAttendance";
            Connection C1 = new Connection();
            C1.DateForAttendence(query);
        }

        /// <summary>
        /// Use to add the data in the Student attendence Table
        /// </summary>
        /// <param name="stuName"> Indicate the Name of the Student</param>
        /// <param name="Attendence">Indicate the Attedance Date of the Attendance</param>
        /// <param name="status">Indicate the Status of the StudentAttendence</param>
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

        /// <summary>
        /// Use to get the record of the Strudent Attendence
        /// </summary>
        public void Record()
        {
            string query = "SELECT * FROM StudentAttendance";
            Connection C1 = new Connection();
            C1.StudentAttendenceRecord(query);

        }

        /// <summary>
        /// Use to delete the data
        /// </summary>
        /// <param name="id">Indicate studentId</param>
        /// <param name="Assid">Indicate the AttendanceId</param>
        public void Delete(int id, int Assid)
        {
            string query = "Delete FROM StudentAttendance where StudentId = " + id + " and AttendanceId = " + Assid;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
       
        /// <summary>
        /// Use to get the Registration Number for the student againt id
        /// </summary>
        /// <param name="id">Indicate the StudentId</param>
        /// <returns>Retun the registration number</returns>
        public string RegistrationNoStudent(int id)
        {
            string result;
            string query = "select RegistrationNumber FROM Student where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }

        /// <summary>
        /// Use to get the Attendance date feom ClassAttendance
        /// </summary>
        /// <param name="id">Indicate the AttendanceID</param>
        /// <returns>Return the AttendanceDate</returns>
        public string AttendenceDate(int id)
        {
            string result;
            string query = "select AttendanceDate FROM ClassAttendance where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }

        /// <summary>
        /// Use to find the string againt statusId
        /// </summary>
        /// <param name="id">indicate the StatusId</param>
        /// <returns>Return the Name of status</returns>
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

        /// <summary>
        /// Use to update the data aginst the id 
        /// </summary>
        /// <param name="stid">Indicate studentId</param>
        /// <param name="AttendenceId">Indicate AttendanceId</param>
        /// <param name="stuName">Indicate StudentName</param>
        /// <param name="AttendenceDate">Indicate AttendanceDate</param>
        /// <param name="status">Indicate the Status</param>
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
