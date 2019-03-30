using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class AssessmentClass
    {
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
        public void ADD_Asses(string Title, int totalmarks, int totalweightage, DateTime Datecreated)
        {

            string Insertquery = "Insert into Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES('" + Title + "','" + Datecreated + "','" + totalmarks + "','" + totalweightage + "')";
            Connection C1 = new Connection();
            C1.Insertion(Insertquery);

        }
        public void ASSRecord()
        {
            string query = "SELECT * FROM Assessment";
            Connection C1 = new Connection();
            C1.ShowASSRecord(query);

        }
        public void Delete(int id)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM AssessmentComponent where AssessmentId = " + id;
           int AssessmentId = C1.get_Id_clo(query);
           string query1 = "Delete FROM AssessmentComponent where Id = " + AssessmentId;
           C1.Deletion(query1); 
           string query2 = "Delete FROM Assessment where Id = " + id;
           
           C1.Deletion(query2);
        }
        public void Edit(int id, string Title, int totalmarks, int totalweightage, DateTime Datecreated)
        {
            string query = "UPDATE Assessment SET  Title = '" + Title + "', DateCreated = '" + Datecreated + "',TotalMarks = '" + totalmarks + "',TotalWeightage = '" + totalweightage + "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
       
    }
}
