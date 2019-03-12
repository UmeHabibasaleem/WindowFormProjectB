using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    class StudentClass
    {
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

       

        public void ADD_student(string firstname, string lastname,string contact,string email,string RegistrationNo,int status)
        {

            string Insertquery = "Insert into student (FirstName, LastName, Contact,Email,RegistrationNumber,Status) VALUES('" + firstname + "','" + lastname + "','" + contact + "','" + email + "','" + RegistrationNo + "','" + status + "')";
            Connection C1 = new Connection();
            MessageBox.Show("inthe class of student");
            C1.Insertion(Insertquery);
          
        }
        public void StudentRecord()
        {
            string query = "SELECT * FROM student";
            Connection C1 = new Connection();
            C1.Show_Record(query);

        }
        public void Delete(int id)
        {
            string query = "Delete FROM student where Id = " + id ;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        public void Edit(int id, string firstname, string lastname, string contact, string email, string RegistrationNo, int status)
        {
            string query = "UPDATE student SET  FirstName = '" + firstname + "', Lastname = '" + lastname + "', Contact = '" + contact + "', Email = '" + email + "', RegistrationNumber = '" + RegistrationNo  + "', Status = '" + status + "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
    }
}
