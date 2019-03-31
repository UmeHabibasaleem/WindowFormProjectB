using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the RubricLevel Module in project.
    /// </summary>
    class RubricLevelClass
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private int id;
        private string RubricName;
        private string Details;
        private int Measurement;

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

        public int Measurement1
        {
            get
            {
                return Measurement;
            }

            set
            {
                Measurement = value;
            }
        }

        public string RubricName1
        {
            get
            {
                return RubricName;
            }

            set
            {
                RubricName = value;
            }
        }
        /// <summary>
        /// This Function Create a query to insert the RubricLevel in the DataBase storage through insertion function.
        /// In this function four Rubric level data has been inserted at the same time againt one rubric
        /// </summary>
        /// Multiple parameters.
        /// <param name="detail">Used to indicate detail of RubricLevel of class.</param>
        /// <param name="Measurement">Used to indicate the Measurement for the of Rubriclevel</param>
        
        public void ADD_RubricL(string detail1, string Measurement1, string detail2, string Measurement2, string detail3, string Measurement3, string detail4, string Measurement4, string Cloname)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM Rubric where Details = '" + Cloname + "'";
            int id = C1.get_Id_clo(query);
            if (id >= 0)
            {
                string Insertquery = "Insert into RubricLevel (RubricId, Details, MeasurementLevel) VALUES('" + id + "','" + detail1 + "','" + Convert.ToInt32(Measurement1) + "')";
                C1.Insertion(Insertquery);
                string Insertquery1 = "Insert into RubricLevel (RubricId, Details, MeasurementLevel) VALUES('" + id + "','" + detail2 + "','" +Convert.ToInt32(Measurement2)+ "')";
                C1.Insertion(Insertquery1);
                string Insertquery2 = "Insert into RubricLevel (RubricId, Details, MeasurementLevel) VALUES('" + id + "','" + detail3 + "','" + Convert.ToInt32(Measurement3) + "')";
                C1.Insertion(Insertquery2);
                string Insertquery3 = "Insert into RubricLevel (RubricId, Details, MeasurementLevel) VALUES('" + id + "','" + detail1 + "','" + Convert.ToInt32(Measurement4) + "')";
                C1.Insertion(Insertquery3);
            }
        }
        /// <summary>
        /// This function use to get the data in the RubricLevel storage
        /// </summary>
        public void RubricLRecord()
        {
            string query = "SELECT * FROM RubricLevel";
            Connection C1 = new Connection();
            C1.ShowRubricLevelRecord(query);

        }
        /// <summary>
        /// This function Delete the data againt the gioven id from deletion
        /// </summary>
        /// <param name="id">Indicate the id of the RebricLevel</param>
        public void Delete(int id)
        {
            string query = "Delete FROM RubricLevel where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        /// <summary>
        /// This function used to edit the data adaint id from the RubricLevel
        /// </summary>
        /// <param name="id">Indicate the id of the RubricLevel</param>
        /// <param name="detail">Indicate the Details about thre RubricLevel</param>
        /// <param name="measurement">Indicate the Measurement againt RubriclLevel</param>
        public void Edit(int id, string detail, string measurement)
        {
            string query = "UPDATE RubricLevel SET  Details = '" + detail + "', MeasurementLevel = '" + measurement + "'where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
    }
}
