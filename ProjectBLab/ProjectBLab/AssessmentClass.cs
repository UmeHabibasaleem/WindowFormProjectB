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
            string query = "Delete FROM Assessment where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        public void Edit(int id, string Title, int totalmarks, int totalweightage, DateTime Datecreated)
        {
            string query = "UPDATE Assessment SET  Title = '" + Title + "', DateCreated = '" + Datecreated + "',TotalMarks = '" + totalmarks + "',TotalWeightage = '" + totalweightage + "' where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }
       
    }
}
