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

namespace ProjectBLab
{
    public partial class StudentForm : Form
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

            StudentRecord.Update();

        }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (char c in FirstName.Text)
            {
                if (!Char.IsLetter(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only alphabetic value");
                FirstName.Text = " ";
            }
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (char c in LastName.Text)
            {
                if (!Char.IsLetter(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only alphabetic value");
                LastName.Text = " ";
            }
        }

        private void Contact_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (char c in Contact.Text)
            {
                if (!Char.IsDigit(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only Digit value");
                Contact.Text = " ";

            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            StudentClass Stu = new StudentClass();
            int temp = 0;
            if (IsValidEmail(Email.Text) == false)
            {

                Email.Text = " ";
                Email_TextChanged(sender, e);
            }
            else
            {
                
                if(Active.Checked == true)
                {
                    temp = 5;
                }
                if(InActive.Checked == true)
                { temp = 6; }
                Stu.ADD_student(FirstName.Text, LastName.Text, Contact.Text, Email.Text, RegistrationNumber.Text,temp);
                FirstName.Text = " ";
                LastName.Text = " ";
                Contact.Text = " ";
                Email.Text = " ";
                RegistrationNumber.Text = " ";
                StudentForm_Load(sender, e);

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int temp = 0;
            StudentClass Stu = new StudentClass();
            if (IsValidEmail(Email.Text) == false)
            {
                MessageBox.Show("input should be in email format");
                Email.Text = " ";
                Email_TextChanged(sender, e);
            }
            else
            {
                if (Active.Checked == true)
                {
                    temp = 5;
                }
                if (InActive.Checked == true)
                { temp = 6; }
                Stu.Edit(globalindex, FirstName.Text, LastName.Text, Contact.Text, Email.Text, RegistrationNumber.Text, temp);
                FirstName.Text = " ";
                LastName.Text = " ";
                Contact.Text = " ";
                Email.Text = " ";
                RegistrationNumber.Text = " ";
                StudentRecord.DataSource = null;
                StudentForm_Load(sender, e);

            }
        }

        private void StudentRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentClass sc = new StudentClass();
            ListofClasses lt = new ListofClasses();
            int index = StudentRecord.CurrentCell.RowIndex;
            DataGridViewRow r = StudentRecord.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (StudentRecord.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    sc.Delete(id);
                    StudentRecord.DataSource = null;
                    StudentForm_Load(sender, e);
                    MessageBox.Show("id of the selested row is" + id);
                }
                else
                {
                    return;
                }
            }
            if (StudentRecord.Columns[e.ColumnIndex].Name == "Edit")
            {
                FirstName.Text = r.Cells[1].Value.ToString();
                LastName.Text = r.Cells[2].Value.ToString();
                Contact.Text = r.Cells[3].Value.ToString();
                Email.Text = r.Cells[4].Value.ToString();
                RegistrationNumber.Text = r.Cells[5].Value.ToString();
               int temp = Convert.ToInt32(r.Cells[6].Value);
                if(temp == 5)
                {
                    Active.Checked = true;
                }
                if(temp == 6)
                {
                    InActive.Checked = true;
                }
                globalindex = id; 
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentClass st1 = new StudentClass();
            ListofClasses lt1 = new ListofClasses();
            st1.StudentRecord();
            StudentRecord.DataSource = null;
            StudentRecord.DataSource = lt1.StudentList;
        }

        private void Active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }
    }
}
