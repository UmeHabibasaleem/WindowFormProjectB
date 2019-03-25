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
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
        }
        public void comoboxvalues()
        {
            StudentResultClass SR = new StudentResultClass();
            ListofClasses lt1 = new ListofClasses();
            SR.addRubricname();
            int length = lt1.Cloname.Count();
            RubricLSelection.Items.Clear();

            for (int i = 0; i < length; i++)
            {
                RubricLSelection.Items.Add(lt1.Cloname.ElementAt(i));
            }
            SR.addStudentname();
            int length1 = lt1.Studentname.Count();
            StudentName1.Items.Clear();

            for (int i = 0; i < length1; i++)
            {
                StudentName1.Items.Add(lt1.Studentname.ElementAt(i));
            }
            SR.addAssessmentname();
            int length2 = lt1.ASSname1.Count();
            AssessmentSelection.Items.Clear();

            for (int i = 0; i < length2; i++)
            {
                AssessmentSelection.Items.Add(lt1.ASSname1.ElementAt(i));
            }
        }
        private void My_Own_Load()
        {
            StudentResultClass Acc = new StudentResultClass();
         /*   ListofClasses lt1 = new ListofClasses();
            Acc.AssComRecord();
            StudentResultRecord.DataSource = null;
            AssessmentSelection.Text = "";
            StudentResultRecord.DataSource = lt1.ASSCom1;
            comoboxvalues(); */

        }
        private void StudentResult_Load(object sender, EventArgs e)
        {
            comoboxvalues();
        }

        private void StudentResultRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentName1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RubricLSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssessmentSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            StudentResultClass SR = new StudentResultClass();
            string Rubric = RubricLSelection.GetItemText(RubricLSelection.SelectedItem);
            string assessment = AssessmentSelection.GetItemText(AssessmentSelection.SelectedItem);
            string student = StudentName1.GetItemText(StudentName1.SelectedItem);
            SR.ADD(student, assessment,Rubric, EvaluateDate.Value);
            StudentResultRecord.DataSource = null;
            RubricLSelection.Text = "";
            AssessmentSelection.Text = "";
            StudentName1.Text = "";
            EvaluateDate.ResetText();
           
            
        }
    }
}
