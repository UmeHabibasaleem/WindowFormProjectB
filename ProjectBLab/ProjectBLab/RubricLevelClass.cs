using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class RubricLevelClass
    {
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
        public void RubricLRecord()
        {
            string query = "SELECT * FROM RubricLevel";
            Connection C1 = new Connection();
            C1.ShowRubricLevelRecord(query);

        }
        public void Delete(int id)
        {
            string query = "Delete FROM RubricLevel where Id = " + id;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        public void Edit(int id, string detail, string measurement)
        {
            string query = "UPDATE RubricLevel SET  Details = '" + detail + "', MeasurementLevel = '" + measurement + "'where Id = " + id;
            Connection C1 = new Connection();
            C1.UPdate(query);
        }

      /*  public void addname()
        {
            string query = "Select Name from Clo";
            Connection C1 = new Connection();
            C1.nameForcomoboxList(query);
        } */

    }
}
