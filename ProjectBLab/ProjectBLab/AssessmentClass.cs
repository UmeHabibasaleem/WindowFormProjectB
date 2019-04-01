using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the Assessment Module in project.
    /// </summary>
    class AssessmentClass
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private int Id;
        private string Title;
        private DateTime DateCreated;
        private int TotalMarks;
        private int TotalWeightage;

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

        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public DateTime DateCreated1
        {
            get
            {
                return DateCreated;
            }

            set
            {
                DateCreated = value;
            }
        }

        public int TotalMarks1
        {
            get
            {
                return TotalMarks;
            }

            set
            {
                TotalMarks = value;
            }
        }

        public int TotalWeightage1
        {
            get
            {
                return TotalWeightage;
            }

            set
            {
                TotalWeightage = value;
            }
        }
        /// <summary>
        /// This Function Create a query to insert the Assesssment in the DataBase storage through insertion function.
        /// </summary>
        /// Multiple parameters.
        /// <param name="Title">Used to indicate title of Assessment.</param>
        /// <param name="totalMarks">Used to specify totalMarks.</param>
        /// <param name="totalWeightage">Used to specify Totalweightage.</param>
        /// <param name="DateCreated">Used to specify Datecreated of Assessment.</param>
        public void ADD_Asses(string Title, int totalmarks, int totalweightage, DateTime Datecreated)
        {
            string Insertquery = "Insert into Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES('" + Title + "','" + Datecreated + "','" + totalmarks + "','" + totalweightage + "')";
            Connection C1 = new Connection();
            C1.Insertion(Insertquery);
        }
        /// <summary>
        /// This Function Create a query to get all the stored data of  the Assesssment in the DataBase storage through ShowASSRecord function.
        /// </summary>
        public void ASSRecord()
        {
            string query = "SELECT * FROM Assessment";
            Connection C1 = new Connection();
            C1.ShowASSRecord(query);

        }
        /// <summary>
        /// This Function Create a query to Delete the Assesssment in the DataBase storage through Delete function.
        /// this function firsttly delete all those data in which it's id exist as forein key.
        /// </summary>
        public void Delete(int id)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM AssessmentComponent where AssessmentId = " + id;
           int AssessmentId = C1.get_Id_clo(query);
           string query1 = "Delete FROM AssessmentComponent where Id = " + AssessmentId;
           C1.Deletion(query1); 
           string query2 = "Delete FROM Assessment where Id = " + id;
           C1.Deletion(query2);
            MessageBox.Show("Data Has been deleted successfully");
        }
        /// <summary>
        /// This Function Create a query to Update the Assesssment in the DataBase storage through Edit function.
        /// </summary>
        /// Multiple parameters.
        /// <param name="id">Used to indicate id of Assessment against the data will be update.</param>
        /// <param name="Title">Used to indicate title of Assessment.</param>
        /// <param name="totalMarks">Used to specify totalMarks.</param>
        /// <param name="totalWeightage">Used to specify Totalweightage.</param>
        /// <param name="DateCreated">Used to specify Datecreated of Assessment.</param>
        public void Edit(int id, string Title, int totalmarks, int totalweightage, DateTime Datecreated)
        {
            string query = "UPDATE Assessment SET  Title = '" + Title + "', DateCreated = '" + Datecreated + "',TotalMarks = '" + totalmarks + "',TotalWeightage = '" + totalweightage + "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
       
    }
}
