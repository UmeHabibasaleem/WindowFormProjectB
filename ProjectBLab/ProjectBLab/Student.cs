using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ProjectBLab
{
    public partial class Student : Form
    {
        ErrorProvider e1 = new ErrorProvider();
        int globalindex;
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool emailvalid(string email)
        {
            bool check = false;
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(email, pattern))
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Input should be in email format");
            }
            return check;
        }
        private void ReloadForm()
        {
           
            dataGridView1.Update();
            
        }
        public Student()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StudentClass st1 = new StudentClass();
            ListofClasses lt1 = new ListofClasses();
            st1.StudentRecord();
            dataGridView1.DataSource = lt1.StudentList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass Stu = new StudentClass();
            if (IsValidEmail(textBox2.Text) == false) 
          {
                MessageBox.Show("input should be in email format");
                textBox2.Text = " ";
                textBox2_TextChanged(sender,e);
          }
          else
          {
               Stu.ADD_student(textBox1.Text,textBox3.Text, textBox5.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox6.Text));
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
             
            }
         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int count = 0; 

            foreach (char c in textBox3.Text)
            {
                if (!Char.IsLetter(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only alphabetic value");
                textBox3.Text = " " ;
            }
       
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            int count = 0;

            foreach (char c in textBox5.Text)
            {
                if (!Char.IsDigit(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only Digit value");
                textBox5.Text = " ";
                    
            }
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (char c in textBox1.Text)
            {
                if (!Char.IsLetter(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only alphabetic value");
                textBox1.Text = " ";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

            StudentClass sc = new StudentClass();
            ListofClasses lt = new ListofClasses();
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    sc.Delete(id);
                    MessageBox.Show("id of the selested row is" + id);
                }
                else
                {
                    return;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                textBox1.Text = r.Cells[1].Value.ToString();
                textBox3.Text = r.Cells[2].Value.ToString();
                textBox5.Text = r.Cells[3].Value.ToString();
                textBox2.Text = r.Cells[4].Value.ToString();
                textBox4.Text = r.Cells[5].Value.ToString();
                textBox6.Text = r.Cells[6].Value.ToString();
                globalindex = id;
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentClass Stu = new StudentClass();
            if (IsValidEmail(textBox2.Text) == false)
            {
                MessageBox.Show("input should be in email format");
                textBox2.Text = " ";
                textBox2_TextChanged(sender, e);
            }
            else
            {
                Stu.Edit(globalindex, textBox1.Text, textBox3.Text, textBox5.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox6.Text));
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clo_Management Clo = new Clo_Management();
            this.Hide();
            Clo.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubrics rub = new Rubrics();
            this.Hide();
            rub.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel rebL = new RubricLevel();
            this.Hide();
            rebL.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assessment ASS = new Assessment();
            this.Hide();
            ASS.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentComponent ac = new AssessmentComponent();
            this.Hide();
            ac.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentResult SR = new StudentResult();
            this.Hide();
            SR.Show();
        }
    }
    
 }
