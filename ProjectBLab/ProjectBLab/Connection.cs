using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    class Connection
    {
       
         static String conURL = @"Data Source = . ; Initial Catalog = ProjectB; User ID = mylogin; Password = 12345; MultipleActiveResultSets = True;";
         SqlConnection conn = new SqlConnection(conURL);
           
         public void Insertion( string insertquery)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertquery, conn);
               
                int i = command.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Data could not add. Please try again!");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        public void Deletion(string Deletequery)
        {
            try
            {
                SqlCommand command = new SqlCommand(Deletequery, conn);
                conn.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                MessageBox.Show("Data Deleted");
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        public void UPdate(string updatequery)
        {
            SqlCommand command = new SqlCommand(updatequery, conn);
            conn.Open();
            SqlDataReader reader;
            reader = command.ExecuteReader();
            MessageBox.Show("Data has been updated");
        }
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
           catch(Exception ex)
            {
                throw (ex);
            }
        }

    }
}
