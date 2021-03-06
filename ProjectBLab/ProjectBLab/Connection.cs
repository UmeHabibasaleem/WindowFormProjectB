﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    /// <summary>
    /// This class is used to interact the database and the business logic
    /// </summary>
    class Connection
    {
        /// <summary>
        /// Connection building with sql
        /// </summary>
        static String conURL = @"Data Source = . ; Initial Catalog = ProjectB; User ID = mylogin; Password = 12345; MultipleActiveResultSets = True;";
        SqlConnection conn = new SqlConnection(conURL);

        /// <summary>
        /// Insert the data in database
        /// </summary>
        /// <param name="insertquery"> Query to isert the data</param>
        public void Insertion(string insertquery)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertquery, conn);

                int i = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data addition fail,because of dublicate data");
                return;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// This function Delete The data from the Database acoording the quer passed in parameter
        /// </summary>
        /// <param name="Deletequery"> Query of the deletion</param>
        public void Deletion(string Deletequery)
        {
            try
            {
                SqlCommand command = new SqlCommand(Deletequery, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show("Data can't be deleted,");
                return;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// This function is used to update the data in the dataBase
        /// </summary>
        /// <param name="updatequery">Query of the update</param>
        public void UPdate(string updatequery)
        {
            try
            {
                SqlCommand command = new SqlCommand(updatequery, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                MessageBox.Show("Data has been updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// This function insert the student record in the StudentRecordList
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void Show_Record(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.StudentList.Clear();
                    while (reader.Read())
                    {
                        StudentClass st1 = new StudentClass();
                        st1.Id1 = Convert.ToInt32(reader[0]);
                        st1.FirstName = reader[1].ToString();
                        st1.LastName = reader[2].ToString();
                        st1.Contact = reader[3].ToString();
                        st1.Email = reader[4].ToString();
                        st1.RegistrationNumber = reader[5].ToString();
                        st1.Status = Convert.ToInt32(reader[6]);
                        Lt1.addIntolist(st1);

                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function insert the CLO record in the CLORecordList
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void Show_CLoRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.CLOList.Clear();
                    while (reader.Read())
                    {
                        CLOClass Clo = new CLOClass();
                        Clo.Id1 = Convert.ToInt32(reader[0]);
                        Clo.Name = reader[1].ToString();
                        Clo.DateCreated = Convert.ToDateTime(reader[2]);
                        Clo.DateUpdated = Convert.ToDateTime(reader[3]);
                        Lt1.AddIntoCLoList(Clo);

                    }
                }
               
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to insert the RubricLevel record in RubricLevel List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void ShowRubricLevelRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.RemoveFromRubricLevel();
                    while (reader.Read())
                    {
                        RubricLevelClass RL = new RubricLevelClass();
                        RL.Id = Convert.ToInt32(reader[0]);
                        int rubricid =Convert.ToInt32 (reader[1]);
                        RL.Details1= reader[2].ToString();
                        RL.Measurement1 = Convert.ToInt32(reader[3]);
                        string myquery = "select Details FROM Rubric where Id = '" + rubricid + "'";
                        RL.RubricName1 = Cloname(myquery);
                        Lt1.AddRubricLevelList(RL);

                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to get the id of the required object accordint to passed query
        /// </summary>
        /// <param name="query">Indicate the query</param>
        /// <returns>Return the Id of the required thing</returns>
        public int get_Id_clo(string query)
        {
            int id = -1;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        /// <summary>
        /// This function used to insert the Rubric record in Rubric List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void RubricRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.RemoveFromRubrics();
                    while (reader.Read())
                    {
                        RubricsClass Rub = new RubricsClass();
                        Rub.Id = Convert.ToInt32(reader[0]);
                        Rub.Details1 = reader[1].ToString();
                        int id = Convert.ToInt32(reader[2]);
                        string myquery = "select Name FROM Clo where Id = '" + id + "'";
                        Rub.Cloname = Cloname(myquery);
                      
                        Lt1.AddIntoRubricList(Rub);
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function return the Name if Clo
        /// </summary>
        /// <param name="query">Query to retreive of Clo name</param>
        /// <returns>Name of Clo</returns>
        public string Cloname(string query)
        {
            try
            {
                string cloname = "";
                SqlCommand mycommand = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = mycommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cloname = reader[0].ToString();
                    }

                }
                return cloname;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Used to get the Id of the rubric
        /// </summary>
        /// <param name="query">Query to get the Id of the Rubric</param>
        /// <returns>The id of the quer</returns>
        public int MyRubricID(string query)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();

                if(reader.Read())
                {
                    if (reader.GetValue(0) == DBNull.Value)
                    {
                        id = 1;
                    }
                    else
                    {
                        id = Convert.ToInt32(reader[0] )+ 1;
                    }
                }
            
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();

            }
            return id;
        }

        /// <summary>
        /// This function used to get the Name of the comobox list 
        /// </summary>
        /// <param name="query">Query to retrieve require data</param>
        public void nameForcomoboxList(string query)
        {
            try
            {
                ListofClasses l = new ListofClasses();

                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();
                l.Cloname.Clear();
                while(reader.Read())
                {
                    l.AddIntoCLOnameList(reader[0].ToString());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function is used to get the Title of assessment From the Database
        /// </summary>
        /// <param name="query">Indicate the query to retrieve the data</param>
        public void TitleForAssesssment(string query)
        {
            try
            {
                ListofClasses l = new ListofClasses();

                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();
                l.Assessment1.Clear();
                while (reader.Read())
                {
                    l.AddIntoAssesssment(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Retrieve the studentName for the student
        /// </summary>
        /// <param name="query">Indicate the query</param>
        public void NameForStudentList(string query)
        {
            try
            {
                ListofClasses l = new ListofClasses();

                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();
                l.Studentname.Clear();
                while (reader.Read())
                {
                    l.AddIntoStudentnameList(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function is used to get the Date od Attendence
        /// </summary>
        /// <param name="query">Indicate the query</param>
        public void DateForAttendence(string query)
        {
            try
            {
                ListofClasses l = new ListofClasses();

                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();
                l.AttendenceDate1.Clear();
                while (reader.Read())
                {
                    l.AddIntoAttendenceDate(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This Function is used to get the Name of the assessmentComponentList
        /// </summary>
        /// <param name="query">Indicate the Query</param>
        public void NameForAssementComList(string query)
        {
            try
            {
                ListofClasses l = new ListofClasses();

                SqlCommand command = new SqlCommand(query, conn);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader;
                reader = command.ExecuteReader();
                l.ASSname1.Clear();
                while (reader.Read())
                {
                    l.AddIntoAssnameList(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to insert the Aseseement record in Assessment List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void ShowASSRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.RemoveFromASS();
                    while (reader.Read())
                    {
                        AssessmentClass ASS = new AssessmentClass();
                        ASS.Id1 = Convert.ToInt32(reader[0]);
                        ASS.Title1 = reader[1].ToString();
                        ASS.DateCreated1= Convert.ToDateTime(reader[2]);
                        ASS.TotalMarks1 = Convert.ToInt32(reader[3]);
                        ASS.TotalWeightage1 = Convert.ToInt32(reader[4]);
                        Lt1.AddASSList(ASS);

                    }
                }
              
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to insert the AssessmentComponent Record in AssessmentComList 
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void AssCRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.RemoveFromASSCom();
                    while (reader.Read())
                    {
                        AssessmentComClass ASS = new AssessmentComClass();
                        ASS.Id1 = Convert.ToInt32(reader[0]);
                        ASS.Name1 = reader[1].ToString();
                        ASS.RubricId1= Convert.ToInt32(reader[2]);
                        ASS.TotalMarks1 = Convert.ToInt32(reader[3]);
                        ASS.DateCreated1 = Convert.ToDateTime(reader[4]);
                        ASS.DateUpdated1 = Convert.ToDateTime(reader[5]);
                        ASS.AssessmentId1 = Convert.ToInt32(reader[6]);
                        Lt1.AddASSComList(ASS);

                    }
                }
               
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to insert the StudentResult record in StudentResult List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void StudentResultRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.RemoveFromSTR();
                    while (reader.Read())
                    {
                        StudentResultClass SRC = new StudentResultClass();
                        SRC.StudentId1 = Convert.ToInt32(reader[0]);
                        SRC.AssessmentComId1= Convert.ToInt32(reader[1]);
                        SRC.RubricMeasurement1 = Convert.ToInt32(reader[2]);
                        SRC.EvaluationDate1 = Convert.ToDateTime(reader[3]);
                        Lt1.AddSTRList(SRC);

                    }
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to insert the Attendence Record in ClassAttendance List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void AttendenceRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.CA1.Clear();
                    while (reader.Read())
                    {
                        ClassAttendence Ca = new ClassAttendence();
                        Ca.Id1= Convert.ToInt32(reader[0]);
                        Ca.AttendenceDate1 = Convert.ToDateTime(reader[1]);
                        Lt1.addIntoAttendence(Ca);

                    }
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This function used to insert the StudentAttendance record in studentAttendance List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void StudentAttendenceRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.SAC1.Clear();
                    while (reader.Read())
                    {
                        StudentAttendenceClass SRC = new StudentAttendenceClass();
                        SRC.StudentId1 = Convert.ToInt32(reader[1]);
                        SRC.AttendanceId1 = Convert.ToInt32(reader[0]);
                        SRC.AttendanceStatus1 = Convert.ToInt32(reader[2]);
                        Lt1.addIntoStudentAttendence(SRC);

                    }
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// This function used to insert the CloWiseResult record in ClowiseResult List
        /// </summary>
        /// <param name="query">Query to retrieve the data from database</param>
        public void ClowiseResultRecord(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ListofClasses Lt1 = new ListofClasses();
                    Lt1.CloReport1.Clear();
                    while (reader.Read())
                    {
                        GenerateReport st1 = new GenerateReport();
                        st1.RegistrationNumber1 = reader[0].ToString();
                        st1.CloName1 = reader[1].ToString();
                        st1.TotalMarks1 = Convert.ToInt32(reader[2]);
                        st1.ObtainMarks1 = Convert.ToInt32(reader[3]);
                        Lt1.addIntoCloReport(st1);

                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public int IsExist(string query)
        {
            int count = 0;
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
            return count;
        }
    }
}   

