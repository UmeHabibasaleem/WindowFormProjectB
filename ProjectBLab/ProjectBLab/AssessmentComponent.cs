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
    public partial class AssessmentComponent : Form
    {
        int globalindex;
        public AssessmentComponent()
        {
            InitializeComponent();
        }

        public void comoboxvalues()
        {
            AssessmentComClass Rub = new AssessmentComClass();
            ListofClasses lt1 = new ListofClasses();
            Rub.addRubricname();
            int length = lt1.Cloname.Count();
            RubricSelection.Items.Clear();

            for (int i = 0; i < length; i++)
            {
                RubricSelection.Items.Add(lt1.Cloname.ElementAt(i));
            }
        }
        private void My_Own_Load()
        {
            AssessmentComClass Acc = new AssessmentComClass();
            ListofClasses lt1 = new ListofClasses();
             Acc.AssComRecord();
            AssessmentRecord.DataSource = null;
            AssessmentSelection.Text = "";
            AssessmentRecord.DataSource = lt1.ASSCom1;
            comoboxvalues();

        }
        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet4.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet3.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet3.AssessmentComponent);

            My_Own_Load();
        }

        private void ASSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalMarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateCreated_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateUpdated_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AssessmentSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RubricSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            AssessmentComClass ACC = new AssessmentComClass();

            if (ASSName.Text == "" || TotalMarks.Text == "")
            {
                MessageBox.Show("please fillall the fields first");
            }
            else
            {
                string Rubric = RubricSelection.GetItemText(RubricSelection.SelectedItem);
                string assessment = AssessmentSelection.GetItemText(AssessmentSelection.SelectedItem);
                ACC.ASSCOM_ADD(ASSName.Text ,Rubric,assessment,Convert.ToInt32(TotalMarks.Text),DateCreated.Value,DateUpdated.Value);
                RubricSelection.DataSource = null;
                ASSName.Text = "";
                RubricSelection.Text = "";
                AssessmentSelection.Text = "";
                TotalMarks.Text = "";
                DateCreated.ResetText();
                DateUpdated.ResetText();
                My_Own_Load();
            }
        }

        private void AssessmentRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AssessmentComClass ACC = new AssessmentComClass();
            ListofClasses lt = new ListofClasses();
            int index = AssessmentRecord.CurrentCell.RowIndex;

            DataGridViewRow r = AssessmentRecord.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (AssessmentRecord.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete data against the id ?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    ACC.Delete(id);
                    AssessmentRecord.DataSource = null;
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
            if (AssessmentRecord.Columns[e.ColumnIndex].Name == "Edit")
            {
                AssessmentComClass acc = new AssessmentComClass();
                comoboxvalues();
                ASSName.Text = r.Cells[1].Value.ToString(); 
              
                int rubricid= Convert.ToInt32(r.Cells[2].Value);
                RubricSelection.SelectedText = acc.NameofRubricId(rubricid);
                int ASSid = Convert.ToInt32(r.Cells[6].Value);
                AssessmentSelection.SelectedText = acc.NameofASSId(ASSid);
                TotalMarks.Text = r.Cells[3].Value.ToString(); 
                DateCreated.Value = Convert.ToDateTime(r.Cells[4].Value); 
                DateUpdated.Value = Convert.ToDateTime(r.Cells[5].Value); 

                globalindex = id;
                if (ADD.Visible)
                {
                    ADD.Visible = false;
                }

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string Rubric = RubricSelection.GetItemText(RubricSelection.SelectedItem);
            string assessment = AssessmentSelection.GetItemText(AssessmentSelection.SelectedItem);
            AssessmentComClass Rub = new AssessmentComClass();
            Rub.Edit(globalindex,ASSName.Text , Rubric, assessment, Convert.ToInt32(TotalMarks.Text), DateCreated.Value, DateUpdated.Value);
            AssessmentRecord.DataSource = null;
            ASSName.Text = "";
            RubricSelection.Text = "";
            AssessmentSelection.Text = "";
            TotalMarks.Text = "";
            DateCreated.ResetText();
            DateUpdated.ResetText();
            My_Own_Load();
            ADD.Visible = true;
        }
    }
 }

