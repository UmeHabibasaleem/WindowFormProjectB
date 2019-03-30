using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBLab
{
    public partial class Assessment : Form
    {
        int globalindex;
        public Assessment()
        {
            InitializeComponent();
        }

        

        private void Title_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TotalMarks_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (char c in TotalMarks.Text)
            {
                if (!Char.IsDigit(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only Digit value");
                TotalMarks.Text = " ";

            }
        }

        private void Totalweightage_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (char c in Totalweightage.Text)
            {
                if (!Char.IsDigit(c))
                {
                    count++;
                }

            }
            if (count > 1)
            {
                MessageBox.Show("this can take only Digit value");
                Totalweightage.Text = " ";

            }
        }

        private void AssessmentRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AssessmentClass ASS = new AssessmentClass();
            ListofClasses lt = new ListofClasses();
            int index = AssessmentRecord.CurrentCell.RowIndex;
            DataGridViewRow r = AssessmentRecord.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (AssessmentRecord.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    ASS.Delete(id);
                    AssessmentRecord.DataSource = null;
                    Assessment_Load(sender, e);
                    if (ADD.Visible == false)
                    {
                        ADD.Visible = true;
                    }
                }
                else
                {
                    return;
                }
            }
           if (AssessmentRecord.Columns[e.ColumnIndex].Name == "Edit")
            {
                Title.Text = r.Cells[1].Value.ToString();
                TotalMarks.Text = r.Cells[3].Value.ToString();
                Totalweightage.Text = r.Cells[4].Value.ToString();
                DateCreated.Value = Convert.ToDateTime(r.Cells[2].Value);
                globalindex = id;
                ADD.Visible = false;
            } 
        }

        private void Save_Click(object sender, EventArgs e)
        {

            AssessmentClass ASS = new AssessmentClass();
            ASS.Edit(globalindex, Title.Text, Convert.ToInt32(TotalMarks.Text), Convert.ToInt32(Totalweightage.Text), DateCreated.Value);
            AssessmentRecord.DataSource = null;
            Title.Text = " ";
            TotalMarks.Text = " ";
            Totalweightage.Text = " ";
            DateCreated.ResetText();
            Assessment_Load(sender, e);
            ADD.Visible = true;
        
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            AssessmentClass Ass = new AssessmentClass();
            if (Title.Text != "" && Totalweightage.Text != "" && TotalMarks.Text != "" )
            {
                Ass.ADD_Asses(Title.Text, Convert.ToInt32(TotalMarks.Text), Convert.ToInt32(Totalweightage.Text), DateCreated.Value);
                Title.Text = " ";
                TotalMarks.Text = " ";
                Totalweightage.Text = " ";
                DateCreated.ResetText();
                AssessmentRecord.DataSource = null;
                Assessment_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Must fill all the fields in order to proceed");

            }
        }

        private void Assessment_Load(object sender, EventArgs e)
        {
            AssessmentClass ASS = new AssessmentClass();
            ListofClasses lt1 = new ListofClasses();
            ASS.ASSRecord();
            AssessmentRecord.DataSource = lt1.ASSC1;
            
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }
    }
}
