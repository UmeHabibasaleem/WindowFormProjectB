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
    public partial class StudentAttendence : Form
    {
        int globalindex;
        int globalindex2;
        public void comoboxvalues()
        {
            StudentAttendenceClass SR = new StudentAttendenceClass();
            ListofClasses lt1 = new ListofClasses();
            SR.AddAttendenceDate();
            int length = lt1.AttendenceDate1.Count();
            AttendencedateComobox.Items.Clear();

            for (int i = 0; i < length; i++)
            {
                AttendencedateComobox.Items.Add(lt1.AttendenceDate1.ElementAt(i));
            }
            SR.addStudentname();
            int length1 = lt1.Studentname.Count();
            StudentName1.Items.Clear();

            for (int i = 0; i < length1; i++)
            {
                StudentName1.Items.Add(lt1.Studentname.ElementAt(i));
            }
            

        }
        public StudentAttendence()
        {
            InitializeComponent();
        }

        private void StudentAttendence_Load(object sender, EventArgs e)
        {
            StudentAttendenceClass Acc = new StudentAttendenceClass();
            ListofClasses lt1 = new ListofClasses();
            StudentAttendenceRecord.DataSource = null;
            Acc.Record();
            StudentName1.Text = "";
            AttendenceAtatus.Text = "";
            AttendencedateComobox.Text = "";
            StudentAttendenceRecord.DataSource = lt1.SAC1;
            comoboxvalues();
        }

        private void StudentName1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttendenceAtatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttendencedateComobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentAttendenceRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentAttendenceClass STR = new StudentAttendenceClass();
            ListofClasses lt = new ListofClasses();
            int index = StudentAttendenceRecord.CurrentCell.RowIndex;

            DataGridViewRow r = StudentAttendenceRecord.Rows[index];
            int STUid = Convert.ToInt32(r.Cells[0].Value);
            int ASSid = Convert.ToInt32(r.Cells[1].Value);
            if (StudentAttendenceRecord.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete data against the id ?" + STUid, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    STR.Delete( ASSid, STUid);
                    StudentAttendenceRecord.DataSource = null;
                    StudentAttendence_Load(sender, e);
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
            if (StudentAttendenceRecord.Columns[e.ColumnIndex].Name == "Edit")
            {
                StudentAttendenceClass SC = new StudentAttendenceClass();
                comoboxvalues();
                StudentName1.Text = SC.RegistrationNoStudent(Convert.ToInt32(r.Cells[1].Value));
                int ATTId = Convert.ToInt32(r.Cells[0].Value);
                AttendencedateComobox.SelectedText = SC.AttendenceDate(ATTId);
                int ASS = Convert.ToInt32(r.Cells[2].Value);
                AttendenceAtatus.SelectedText = SC.Staus(ASS);
                globalindex = Convert.ToInt32(r.Cells[1].Value);
                globalindex2 = Convert.ToInt32(r.Cells[0].Value);
                if (ADD.Visible)
                {
                    ADD.Visible = false;
                }

            } 
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            StudentAttendenceClass SR = new StudentAttendenceClass();
            string status = AttendenceAtatus.GetItemText(AttendenceAtatus.SelectedItem);
            string Attendence = AttendencedateComobox.GetItemText(AttendencedateComobox.SelectedItem);
            string student = StudentName1.GetItemText(StudentName1.SelectedItem);
            SR.ADD(student, Attendence, status);
            StudentAttendenceRecord.DataSource = null;
            AttendenceAtatus.Text = "";
            AttendencedateComobox.Text = "";
            StudentName1.Text = "";
            StudentAttendence_Load(sender,e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            StudentAttendenceClass SR = new StudentAttendenceClass();
            string status = AttendenceAtatus.GetItemText(AttendenceAtatus.SelectedItem);
            string Attendence = AttendencedateComobox.Text;
            string student = StudentName1.GetItemText(StudentName1.SelectedItem);
            SR.Edit(globalindex,globalindex2,student,Attendence,status);
            StudentAttendenceRecord.DataSource = null;
            AttendenceAtatus.Text = "";
            AttendencedateComobox.Text = "";
            StudentName1.Text = "";
            StudentAttendence_Load(sender, e);
            ADD.Visible = true;
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
