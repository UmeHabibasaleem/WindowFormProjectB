using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the AssessmentComponent Module in project.
    /// </summary>
    class AssessmentComClass
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private int Id;
        private string Name;
        private int RubricId;
        private int TotalMarks;
        private DateTime DateCreated;
        private DateTime DateUpdated;
        private int AssessmentId;

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

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int RubricId1
        {
            get
            {
                return RubricId;
            }

            set
            {
                RubricId = value;
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

        public DateTime DateUpdated1
        {
            get
            {
                return DateUpdated;
            }

            set
            {
                DateUpdated = value;
            }
        }

        public int AssessmentId1
        {
            get
            {
                return AssessmentId;
            }

            set
            {
                AssessmentId = value;
            }
        }
        /// <summary>
        /// This Function Create a query to insert the AssesssmentComponent in the DataBase storage through insertion function.
        /// </summary>
        /// Multiple parameters.
        /// <param name="Name">Used to indicate Name of AssessmentComponent.</param>
        /// <param name="RubricDetail">Used to specify RubricDetail.</param>
        /// <param name="Assessment">Used to specify Assessment.</param>
        /// <param name="TotalMarks">Used to specify TotalMarks.</param>
        /// <param name="DateCreated">Used to specify Datecreated of AssessmentComponent.</param>
        /// <param name="DateUpdated">Used to specify  DateUpdated of AssessmentComponent.</param>
        public void ASSCOM_ADD(string Name,string RubricDetail,string Assessment,int TotalMarks,DateTime DateCreated,DateTime DateUpdated)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM Rubric where Details = '" + RubricDetail + "'";
            int Rubricid = C1.get_Id_clo(query);
            string query2 = "select Id FROM Assessment where Title = '" + Assessment+ "'";
            int AssId = C1.get_Id_clo(query2);
            if (Rubricid >= 0 && AssId >= 0)
            {
                string Insertquery = "Insert into AssessmentComponent ( Name, RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES('" + Name + "','" + Rubricid + "','" + TotalMarks + "','" + DateCreated + "','" + DateUpdated + "','" + AssId + "')";
                C1.Insertion(Insertquery);
            }
        }
        /// <summary>
        /// This Function Create a query to get all the record againt  the AssesssmentComponent in the DataBase storage through ASSCRecord function.
        /// </summary>
        public void AssComRecord()
        {
            string query = "SELECT * FROM AssessmentComponent";
            Connection C1 = new Connection();
            C1.AssCRecord(query);

        }
        /// <summary>
        /// This Function Create a query to delete the AssesssmentComponent in the DataBase storage through Deletion function.
        /// </summary>
        public void Delete(int id)
        {
            Connection C1 = new Connection();
            string query2 = "Delete FROM AssessmentComponent where Id = " + id;
            C1.Deletion(query2);
           
        }
        /// <summary>
        /// This Function Create a query to Edit the AssesssmentComponent in the DataBase storage through Edit function.
        /// In this function, get_Id_clo(query) function used to get the id againt the RubricDetail and Assessment Title.
        /// </summary>
        /// Multiple parameters.
        /// <param name="id">Used to indicate id of AssessmentComponent to edit data againt that id.</param>
        /// <param name="Name">Used to indicate Name of AssessmentComponent.</param>
        /// <param name="RubricDetail">Used to specify RubricDetail.</param>
        /// <param name="Assessment">Used to specify Assessment.</param>
        /// <param name="TotalMarks">Used to specify TotalMarks.</param>
        /// <param name="DateCreated">Used to specify Datecreated of AssessmentComponent.</param>
        /// <param name="DateUpdated">Used to specify  DateUpdated of AssessmentComponent.</param>
        public void Edit(int id, string Name, string RubricDetail, string Assessment, int TotalMarks, DateTime DateCreated, DateTime DateUpdated)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM Rubric where Details = '" + RubricDetail + "'";
            int Rubricid = C1.get_Id_clo(query);
            string query2 = "select Id FROM Assessment where Title = '" + Assessment + "'";
            int AssId = C1.get_Id_clo(query2);
            if (Rubricid >= 0 && AssId >= 0)
            {
                string query1 = "UPDATE AssessmentComponent SET  Name = '" + Name + "', RubricId = '" + Rubricid + "', TotalMarks = '" + TotalMarks + "', DateCreated = '" + DateCreated + "', DateUpdated = '" + DateUpdated + "', AssessmentId = '" + AssId + "' where Id = " + id;
                C1.UPdate(query1);
            }
        }
        /// <summary>
        /// This Function used to add the datails of Rubric in the RubicComobox 
        /// </summary>
        public void addRubricname()
        {
            string query = "Select Details from Rubric";
            Connection C1 = new Connection();
            C1.nameForcomoboxList(query);
        }
        /// <summary>
        /// This Function used to get the Detail of rubric against an id 
        /// </summary>
        /// <param name = "id">Indicate the id of the rubric</param>
        /// <returns>Return the Detail of the rubric againt id</returns>
        public string NameofRubricId(int id)
        {
            string result;
            string query = "select Details FROM Rubric where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
        /// <summary>
        /// This Function used to get the Title of Assessment against an id 
        /// </summary>
        /// <param name = "id">Indicate the id of the Assessment</param>
        /// <returns>Return the Title of the Assessment against id</returns>
        public string NameofASSId(int id)
        {
            string result;
            string query = "select Title FROM Assessment where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
    }
}
