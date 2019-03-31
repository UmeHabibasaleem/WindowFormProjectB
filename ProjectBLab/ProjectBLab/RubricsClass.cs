using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the Rubric Module in project.
    /// </summary>
    class RubricsClass
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private int id;
        private string Details;
        private string cloname;


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Details1
        {
            get
            {
                return Details;
            }

            set
            {
                Details = value;
            }
        }

        public string Cloname
        {
            get
            {
                return cloname;
            }

            set
            {
                cloname = value;
            }
        }

        /// <summary>
        /// This functrion used to add the rubric in data storage through the insertion function
        /// </summary>
        /// <param name="detail">Indicate the detail of the Rubric</param>
        /// <param name="Cloname">Indicate the Clo against the Rubcit added</param>
        public void ADD_Rubric(string detail, string Cloname)
           {
            Connection C1 = new Connection();
            string query1 = "SELECT MAX(Id) FROM Rubric";
            int RubricId = C1.MyRubricID(query1);
            string query ="select Id FROM Clo where Name = '" + Cloname + "'";
            int id = C1.get_Id_clo(query);
            if(id >= 0)
              {
                string Insertquery = "Insert into Rubric (Id, Details, CloId) VALUES('" + RubricId + "','" + detail + "','" + id + "')";
                C1.Insertion(Insertquery);
              }
           }

         /// <summary>
         /// This Function used to get the Record of the Rubric
         /// </summary>
           public void RubricRecord()
           {
               string query = "SELECT * FROM Rubric";
               Connection C1 = new Connection();
               C1.RubricRecord(query);

           }

         /// <summary>
         /// This Function used to Delete the Rubric
         /// </summary>
         /// <param name="id">Indicate the id of the rubric</param>
           public void Delete(int id)
           {
               Connection C1 = new Connection();
            string query = "Delete FROM AssessmentComponent where RubricId = " + id;
            C1.Deletion(query);
            string query1 = "Delete FROM Rubric where Id = " + id;
            C1.Deletion(query1);
           }

        /// <summary>
        /// This functrion used to Edit the Rubric From data storage through the Deletion function
        /// </summary>
        /// <param name="id">Indicate the id of the rubric</param>
        /// <param name="detail">Indicate the detail of the Rubric</param>
        /// <param name="Cloname">Indicate the Clo against the Rubcit added</param>
        public void Edit(int id, string detail,string name)
           {
            string myquery = "select Id FROM Clo where Name = '" + name + "'";
            Connection C2 = new Connection();
               int idclo = C2.get_Id_clo(myquery);
               string query = "UPDATE Rubric SET  Details = '" + detail + "', CloId = '" + idclo + "'where Id = " + id;
               Connection C1 = new Connection();
               C1.UPdate(query);
           } 
         /// <summary>
         /// Use for insert the data in Clo comobox
         /// </summary>
        public void addCLOname()
        {
            string query = "Select Name from Clo";
            Connection C1 = new Connection();
            C1.nameForcomoboxList(query);
        }


    }
}
