using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class ClassAttendence
    {
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

        public void ADDAttendence( DateTime AttendenceDate)
        {

            string Insertquery = "Insert into ClassAttendance (AttendanceDate) VALUES('" + AttendenceDate +  "')";
            Connection C1 = new Connection();
            C1.Insertion(Insertquery);

        }
        public void ATTendenceRecord()
        {
            string query = "SELECT * FROM ClassAttendance";
            Connection C1 = new Connection();
            C1.AttendenceRecord(query);

        }
        public void Delete(int id)
        {
            string query = "Delete FROM ClassAttendance where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        public void Edit(int id,DateTime AttendanceDate)
        {
            string query = "UPDATE ClassAttendance SET  AttendanceDate = '" + AttendanceDate +  "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }

    }
}
