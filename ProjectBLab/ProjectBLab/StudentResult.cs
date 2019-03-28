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
        int globalindex;
        int globalindex2;
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
            SR.AddASSname();
            int length3 = lt1.Assessment1.Count();
            AssessmentSel.Items.Clear();

            for (int i = 0; i < length3; i++)
            {
                AssessmentSel.Items.Add(lt1.Assessment1.ElementAt(i));
            }
           

        }
        public void AssessmentComponent(string ASSValue)
        {
            StudentResultClass SR = new StudentResultClass();
            ListofClasses lt1 = new ListofClasses();
            SR.addAssessmentname(ASSValue);
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
            ListofClasses lt1 = new ListofClasses();
            Acc.Record();
            StudentResultRecord.DataSource = null;
            AssessmentSelection.Text = "";
            AssessmentSel.Text = "";
            StudentResultRecord.DataSource = lt1.STR1;
            comoboxvalues();
       

        }
        private void StudentResult_Load(object sender, EventArgs e)
        {
            //comoboxvalues();
            My_Own_Load();
        }

        private void StudentResultRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentResultClass STR = new StudentResultClass();
            ListofClasses lt = new ListofClasses();
            int index = StudentResultRecord.CurrentCell.RowIndex;

            DataGridViewRow r = StudentResultRecord.Rows[index];
            int STUid = Convert.ToInt32(r.Cells[0].Value);
            int ASSid = Convert.ToInt32(r.Cells[1].Value);
            if (StudentResultRecord.Columns[e.ColumnIndex].Name == "DeleteSr")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete data against the id ?" + STUid, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    STR.Delete(STUid,ASSid);
                    StudentResultRecord.DataSource = null;
                    My_Own_Load();
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
            if (StudentResultRecord.Columns[e.ColumnIndex].Name == "EditSR")
            {
                StudentResultClass SC = new StudentResultClass();
                comoboxvalues();
                StudentName1.Text = SC.RegistrationNoStudent(Convert.ToInt32(r.Cells[0].Value));
                int rubricid = Convert.ToInt32(r.Cells[2].Value);
                RubricLSelection.SelectedText = SC.NameofRubricId(rubricid);
                int ASS = Convert.ToInt32(r.Cells[1].Value);
                AssessmentSelection.SelectedText = SC.NameofASSComId(ASS);
                AssessmentSel.SelectedText = SC.NameofASSId(ASS);
                EvaluateDate.Value = Convert.ToDateTime(r.Cells[3].Value);
                globalindex = Convert.ToInt32(r.Cells[0].Value);
                globalindex2 = Convert.ToInt32(r.Cells[1].Value);
                if (ADD.Visible)
                {
                    ADD.Visible = false;
                }

            } 
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
            My_Own_Load();



        }

        private void AssessmentSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssessmentComponent(AssessmentSel.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string Rubric = RubricLSelection.GetItemText(RubricLSelection.SelectedItem);
            string assessment = AssessmentSelection.GetItemText(AssessmentSelection.SelectedItem);
            string assessmentCom = AssessmentSel.GetItemText(AssessmentSel.SelectedItem);
            string stdentName = StudentName1.GetItemText(StudentName1.SelectedItem);
            StudentResultClass Rub = new StudentResultClass();
            Rub.Edit(globalindex,globalindex2, stdentName, assessment, Rubric,EvaluateDate.Value);
            StudentResultRecord.DataSource = null;
            AssessmentSel.Text = "";
            RubricLSelection.Text = "";
            AssessmentSelection.Text = "";
            StudentName1.Text = "";
            EvaluateDate.ResetText();
            My_Own_Load();
            ADD.Visible = true;
        }

        private void EvaluateDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
