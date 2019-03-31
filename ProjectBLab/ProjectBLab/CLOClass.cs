using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the CLO Module in project.
    /// </summary>
    class CLOClass
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
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
        /// <summary>
        /// This Function Create a query to insert the CLO in the DataBase storage through insertion function.
        /// </summary>
        /// Multiple parameters.
        /// <param name="name">Used to indicate Name of Clo of class.</param>
        /// <param name="DateCreated">Used to indicate DateCreated of CLO</param>
        /// <param name="DateUpdated">Used to indicate DateUpdated of CLO</param>

        public void ADD_Clo(string name, DateTime Datecreated, DateTime DateUpdated)
        {

            string Insertquery = "Insert into Clo (Name, DateCreated, DateUpdated) VALUES('" + name + "','" + Datecreated + "','" + DateUpdated +  "')";
            Connection C1 = new Connection();
            MessageBox.Show("inthe class of Clo");
            C1.Insertion(Insertquery);

        }

        /// <summary>
        /// This Function Create a query in order to get  the CLO in the DataBase storage through Show_CLoRecord() function.
        /// </summary>
        public void CloRecord()
        {
            string query = "SELECT * FROM Clo";
            Connection C1 = new Connection();
            C1.Show_CLoRecord(query);

        }

        /// <summary>
        /// This Function Create a query in order to Delete  the CLO in the DataBase storage through Deletion function.
        /// <param name="id">Used to indicate Id of Clo </param>
        /// </summary>
        public void Delete(int id)
        {
            string query = "Delete FROM Clo where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }

        /// <summary>
        /// This Function Create a query to Edit the CLO in the DataBase storage through Edit function.
        /// </summary>
        /// Multiple parameters.
        /// <param name="id">Used to indicate Id of Clo </param>
        /// <param name="name">Used to indicate Name of Clo of class.</param>
        /// <param name="DateCreated">Used to indicate DateCreated of CLO</param>
        /// <param name="DateUpdated">Used to indicate DateUpdated of CLO</param>
        
        public void Edit(int id, string name, DateTime Datecreated, DateTime DateUpdated)
        {
            string query = "UPDATE Clo SET  Name = '" + name + "', DateCreated = '" + Datecreated + "',DateUpdated = '" + DateUpdated +  "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
    }
}
