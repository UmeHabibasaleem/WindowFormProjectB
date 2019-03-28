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

        public void addAssessmentname(string Assvalue)
        {
            Connection C1 = new Connection();
            string query = "Select Id from Assessment where Title = '" + Assvalue + "'";
            int ASSid = C1.get_Id_clo(query);
            string query2 = "Select Name from AssessmentComponent  where AssessmentId = " + ASSid;
            
            C1.NameForAssementComList(query2);
        }
        public void addStudentname()
        {
            string query = "Select RegistrationNumber from Student";
            Connection C1 = new Connection();
            C1.NameForStudentList(query);
        }
        public void AddASSname()
        {
            string query = "Select Title from Assessment";
            Connection C1 = new Connection();
            C1.TitleForAssesssment(query);
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
        public void Record()
        {
            string query = "SELECT * FROM StudentResult";
            Connection C1 = new Connection();
            C1.StudentResultRecord(query);

        }
        public void Delete(int id,int Assid)
        {
            string query = "Delete FROM StudentResult where StudentId = " + id + " and AssessmentComponentId = " +Assid ;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }
        public string NameofASSComId(int id)
        {
            string result;
            string query = "select Name FROM AssessmentComponent where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
        public string NameofASSId(int id)
        {
            string result,result1;
            int temp; 
            string query = "select AssessmentId FROM AssessmentComponent where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            temp = Convert.ToInt32(result);
            string query1 = "select Title FROM Assessment where Id = " + temp;
            result1 = C1.Cloname(query1);
            return result1;
        }
        public string RegistrationNoStudent(int id)
        {
            string result;
            string query = "select RegistrationNumber FROM Student where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
        public string NameofRubricId(int id)
        {
            string result;
            string query = "select Details FROM RubricLevel where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }
        public void Edit(int stuid, int assid,string stuName, string AssTitle, string RLD, DateTime EvaluatedDate)
        {
            Connection C1 = new Connection();
            string query = "select Id FROM RubricLevel where Details='" + RLD + "' ";
            int Rubricid = C1.get_Id_clo(query);
            string query2 = "select Id FROM AssessmentComponent where Name = '" + AssTitle + "'";
            int AssId = C1.get_Id_clo(query2);
            string query3 = "select Id FROM Student where RegistrationNumber = '" + stuName + "'";
            int stuId = C1.get_Id_clo(query3);
            if (Rubricid >= 0 && AssId >= 0 && stuId >= 0)
            {
                string query1 = "UPDATE StudentResult SET  studentId = '" + stuId + "', RubricMeasurementId = '" + Rubricid + "', AssessmentComponentId = '" + AssId + "', EvaluationDate = '" + EvaluatedDate + "' where StudentId = " + stuid + " and AssessmentComponentId = " + assid ;
                C1.UPdate(query1);
            }
        }

    }
}
