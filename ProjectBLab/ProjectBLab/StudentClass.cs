using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    /// <summary>
    ///  This class contain the Datamembers and Functions related to the Students
    /// </summary>
    class StudentClass
    {
        /// <summary>
        ///  Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private int Id;
        private string firstName;
        private string lastName;
        private string contact;
        private string email;
        private string registrationNumber;
        private int status;

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
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
       
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        /// <summary>
        /// This Function used to add the student in the record of students in database by usning insertion function
        /// </summary>
        /// <param name="firstname">Indicate the FisrstName of student</param>
        /// <param name="lastname">Indicate the LastName of student</param>
        /// <param name="contact">Indicate the ContactNo of student</param>
        /// <param name="email">Indicate the Email of student</param>
        /// <param name="RegistrationNo">Indicate the RegistrationNo of student</param>
        /// <param name="status">Indicate the Status of student</param>
        public void ADD_student(string firstname, string lastname,string contact,string email,string RegistrationNo,int status)
        {

            string Insertquery = "Insert into student (FirstName, LastName, Contact,Email,RegistrationNumber,Status) VALUES('" + firstname + "','" + lastname + "','" + contact + "','" + email + "','" + RegistrationNo + "','" + status + "')";
            Connection C1 = new Connection();
            C1.Insertion(Insertquery);
          
        }
        /// <summary>
        /// This function used to get the record of students
        /// </summary>
        public void StudentRecord()
        {
            string query = "SELECT * FROM student";
            Connection C1 = new Connection();
            C1.Show_Record(query);

        }

        /// <summary>
        /// This function used in order to  delete the student from the student Record
        /// </summary>
        /// <param name="id">Indicate the Id of the student</param>
        public void Delete(int id)
        {
            string query = "Delete FROM studentResult where StudentId = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
            string query2 = "Delete FROM studentAttendance where StudentId = " + id;
            C1.Deletion(query2);
            string query1 = "Delete FROM student where Id = " + id ;
            C1.Deletion(query1);
            MessageBox.Show("Data has been deleted successfully");
        }
        /// <summary>
        /// This Function used to edit the student in the record of students in database by usning Update function
        /// </summary>
        /// <param name="id">Indicate the Id of student</param>
        /// <param name="firstname">Indicate the FisrstName of student</param>
        /// <param name="lastname">Indicate the LastName of student</param>
        /// <param name="contact">Indicate the ContactNo of student</param>
        /// <param name="email">Indicate the Email of student</param>
        /// <param name="RegistrationNo">Indicate the RegistrationNo of student</param>
        /// <param name="status">Indicate the Status of student</param>
        public void Edit(int id, string firstname, string lastname, string contact, string email, string RegistrationNo, int status)
        {
            string query = "UPDATE student SET  FirstName = '" + firstname + "', Lastname = '" + lastname + "', Contact = '" + contact + "', Email = '" + email + "', RegistrationNumber = '" + RegistrationNo  + "', Status = '" + status + "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
        public bool Check(string RegNo)
        {
            bool check = true;
            string query = "Select count(*) From Student where RegistrationNumber = '" + RegNo + "'";
            Connection C1 = new Connection();
            if(C1.IsExist(query)> 0)
            {
                check = false;
            }
            return check;
        }
    }
}
