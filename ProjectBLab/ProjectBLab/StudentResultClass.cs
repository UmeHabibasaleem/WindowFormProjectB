﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    /// <summary>
    ///  This class contain the Datamembers and Functions related to the StudentResult
    /// </summary>
    class StudentResultClass
    {
        /// <summary>
        ///  Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
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
        /// <summary>
        /// This function use for putting the data of Details of Robric in comobox 
        /// </summary>
        public void addRubricname()
        {
            string query = "Select Details from RubricLevel";
            Connection C1 = new Connection();
            C1.nameForcomoboxList(query);
        }

        /// <summary>
        /// This function use for putting the data in Details of the comobox of Rubric
        /// </summary>
        /// <param name="Assvalue">Indicate the Title of the Asseeement in order to get the name of student Assessmentcomponent</param>
        public void addAssessmentname(string Assvalue)
        {
            Connection C1 = new Connection();
            string query = "Select Id from Assessment where Title = '" + Assvalue + "'";
            int ASSid = C1.get_Id_clo(query);
            string query2 = "Select Name from AssessmentComponent  where AssessmentId = " + ASSid;
            
            C1.NameForAssementComList(query2);
        }

        /// <summary>
        /// Add the name of the student  in studentList
        /// </summary>
        public void addStudentname()
        {
            string query = "Select RegistrationNumber from Student";
            Connection C1 = new Connection();
            C1.NameForStudentList(query);
        }

        /// <summary>
        /// Add the Assessment Title in Assessment comobox
        /// </summary>
        public void AddASSname()
        {
            string query = "Select Title from Assessment";
            Connection C1 = new Connection();
            C1.TitleForAssesssment(query);
        }

        /// <summary>
        /// This function used to add the Result of the student in student Result Record
        /// </summary>
        /// <param name="stuName">Indicate the name of the student</param>
        /// <param name="AssTitle">Indicate the Assessment title of the student</param>
        /// <param name="RLD">Indicate the RubruicLevel</param>
        /// <param name="EvaluatedDate">Indicate the evaluation date</param>
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

        /// <summary>
        /// This function used in order to get the data from the studentResult
        /// </summary>
        public void Record()
        {
            string query = "SELECT * FROM StudentResult";
            Connection C1 = new Connection();
            C1.StudentResultRecord(query);

        }

        /// <summary>
        /// This function used to delete the data from the StudentResult
        /// </summary>
        /// <param name="id">Indicate the Id of the student</param>
        /// <param name="Assid">Indicate the AssessmentComponentId</param>
        public void Delete(int id,int Assid)
        {
            string query = "Delete FROM StudentResult where StudentId = " + id + " and AssessmentComponentId = " +Assid ;
            Connection C1 = new Connection();
            C1.Deletion(query);
        }

        /// <summary>
        /// This function is used to get the Name of the AssessmentComponent 
        /// </summary>
        /// <param name="id">Indicate the Id of the AssessmentComponent </param>
        /// <returns>it return the name of the assessmentComponent</returns>
        public string NameofASSComId(int id)
        {
            string result;
            string query = "select Name FROM AssessmentComponent where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }

        /// <summary>
        /// USed for the name od Assessment Id
        /// </summary>
        /// <param name="id">Indicate the AssessmentComponentId</param>
        /// <returns>Return the Title of the Assessment</returns>
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

        /// <summary>
        /// Used to get the RegistrationNumber of the student
        /// </summary>
        /// <param name="id">Indicate the id of the student</param>
        /// <returns>Return the RegistrationNumber of the student</returns>
        public string RegistrationNoStudent(int id)
        {
            string result;
            string query = "select RegistrationNumber FROM Student where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }

        /// <summary>
        /// This function used to get the details of the RubricLevel
        /// </summary>
        /// <param name="id"> Indicate the id of the RubricLevel</param>
        /// <returns>Return the Details of the RubricLevel</returns>
        public string NameofRubricId(int id)
        {
            string result;
            string query = "select Details FROM RubricLevel where Id = " + id;
            Connection C1 = new Connection();
            result = C1.Cloname(query);
            return result;
        }

        /// <summary>
        /// This function used to Edit the Result of the student in student Result Record
        /// </summary>
        /// <param name="assid">Indicate the assessmentId</param>
        /// <param name="stuid">Indicate the Astudent Id</param>
        /// <param name="stuName">Indicate the name of the student</param>
        /// <param name="AssTitle">Indicate the Assessment title of the student</param>
        /// <param name="RLD">Indicate the RubruicLevel</param>
        /// <param name="EvaluatedDate">Indicate the evaluation date</param>
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
