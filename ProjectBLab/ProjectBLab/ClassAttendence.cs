using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the ClassAttendance Module in project.
    /// </summary>
    class ClassAttendence
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private DateTime AttendenceDate;
        private int Id;
        public DateTime AttendenceDate1
        {
            get
            {
                return AttendenceDate;
            }

            set
            {
                AttendenceDate = value;
            }
        }

        public int Id1
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }
        /// <summary>
        /// This Function Create a query to insert the Attendance of Class in the DataBase storage through insertion function.
        /// </summary>
        /// Single parameter.
        /// <param name="AttendenceDate">Used to indicate AttendanceDate of Attendance of class.</param>

        public void ADDAttendence( DateTime AttendenceDate)
        {

            string Insertquery = "Insert into ClassAttendance (AttendanceDate) VALUES('" + AttendenceDate +  "')";
            Connection C1 = new Connection();
            C1.Insertion(Insertquery);

        }
        /// <summary>
        /// This Function Create a query in order to get the record  of Class Attendence  in the DataBase storage through  AttendenceRecord function.
        /// </summary>
        public void ATTendenceRecord()
        {
            string query = "SELECT * FROM ClassAttendance";
            Connection C1 = new Connection();
            C1.AttendenceRecord(query);

        }
        /// <summary>
        /// This Function Create a query in order to Delete the record  of Class Attendance  in the DataBase storage through  Deletion function.
        /// </summary>
        public void Delete(int id)
        {
            string query = "Delete FROM ClassAttendance where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        /// <summary>
        /// This Function Create a query to Edit the Attendance of Class in the DataBase storage through Update function.
        /// </summary>
        /// Multiple parameter.
        /// <param name="id">Used to indicate id of Attendance of class,against whic the data will be updated.</param>
        /// <param name="AttendenceDate">Used to indicate AttendanceDate of Attendance of class.</param>
        public void Edit(int id,DateTime AttendanceDate)
        {
            string query = "UPDATE ClassAttendance SET  AttendanceDate = '" + AttendanceDate +  "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }

    }
}
