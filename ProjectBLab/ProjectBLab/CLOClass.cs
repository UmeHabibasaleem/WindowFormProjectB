using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    class CLOClass
    {
        private int Id;
        private string name;
        private DateTime dateCreated;
        private DateTime dateUpdated;

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
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }

            set
            {
                dateCreated = value;
            }
        }

        public DateTime DateUpdated
        {
            get
            {
                return dateUpdated;
            }

            set
            {
                dateUpdated = value;
            }
        }

        

       

        public void ADD_Clo(string name, DateTime Datecreated, DateTime DateUpdated)
        {

            string Insertquery = "Insert into Clo (Name, DateCreated, DateUpdated) VALUES('" + name + "','" + Datecreated + "','" + DateUpdated +  "')";
            Connection C1 = new Connection();
            MessageBox.Show("inthe class of Clo");
            C1.Insertion(Insertquery);

        }
        public void CloRecord()
        {
            string query = "SELECT * FROM Clo";
            Connection C1 = new Connection();
            C1.Show_CLoRecord(query);

        }
        public void Delete(int id)
        {
            string query = "Delete FROM Clo where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        public void Edit(int id, string name, DateTime Datecreated, DateTime DateUpdated)
        {
            string query = "UPDATE Clo SET  Name = '" + name + "', DateCreated = '" + Datecreated + "',DateUpdated = '" + DateUpdated +  "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
    }
}
