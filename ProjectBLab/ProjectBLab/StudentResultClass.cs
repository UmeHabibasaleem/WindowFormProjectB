using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class StudentResultClass
    {
        private int StudentId;
        private int AssessmentComId;
        private int RubricMeasurement;
        private DateTime EvaluationDate;

        public int StudentId1
        {
            get
            {
                return StudentId;
            }

            set
            {
                StudentId = value;
            }
        }

        public int AssessmentComId1
        {
            get
            {
                return AssessmentComId;
            }

            set
            {
                AssessmentComId = value;
            }
        }

        public int RubricMeasurement1
        {
            get
            {
                return RubricMeasurement;
            }

            set
            {
                RubricMeasurement = value;
            }
        }

        public DateTime EvaluationDate1
        {
            get
            {
                return EvaluationDate;
            }

            set
            {
                EvaluationDate = value;
            }
        }
        public void addRubricname()
        {
            string query = "Select Details from RubricLevel";
            Connection C1 = new Connection();
            C1.nameForcomoboxList(query);
        }

        public void addAssessmentname()
        {
            string query = "Select Name from AssessmentComponent";
            Connection C1 = new Connection();
            C1.NameForAssementComList(query);
        }
        public void addStudentname()
        {
            string query = "Select RegistrationNumber from Student";
            Connection C1 = new Connection();
            C1.NameForStudentList(query);
        }
        public void ADD(string stuName, string AssTitle, string RLD, DateTime EvaluatedDate)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM RubricLevel where Details='" + RLD+"' ";
            int Rubricid = C1.get_Id_clo(query);
            string query2 = "select Id FROM AssessmentComponent where Name = '" + AssTitle + "'";
            int AssId = C1.get_Id_clo(query2);
            string query3 = "select Id FROM Student where RegistrationNumber = '" + stuName + "'";
            int stuId = C1.get_Id_clo(query3);
            if (Rubricid >= 0 && AssId >= 0 && stuId >= 0)
            {
                string Insertquery = "Insert into StudentResult ( StudentId, AssessmentComponentId,RubricMeasurementId,EvaluationDate) VALUES('" + stuId + "','" + AssId + "','" + Rubricid+ "','" + EvaluatedDate + "')";
                C1.Insertion(Insertquery);
            }
        }
    }
}
