using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class AssessmentComClass
    {
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
        public void AssComRecord()
        {
            string query = "SELECT * FROM AssessmentComponent";
            Connection C1 = new Connection();
            C1.AssCRecord(query);

        }
        public void Delete(int id)
        {
            string query = "Delete FROM AssessmentComponent where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
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

        public void addRubricname()
        {
            string query = "Select Details from Rubric";
            Connection C1 = new Connection();
            C1.nameForcomoboxList(query);
        }
        public string NameofRubricId(int id)
        {
            string result;
            string query = "select Details FROM Rubric where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
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
