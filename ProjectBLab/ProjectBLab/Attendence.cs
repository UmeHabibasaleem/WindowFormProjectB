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
    public partial class Attendence : Form
    {
        int globalindex;
        public Attendence()
        {
            InitializeComponent();
        }

        private void ClassAttendenceRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassAttendence CA = new ClassAttendence();
            ListofClasses lt = new ListofClasses();
            int index = ClassAttendenceRecord.CurrentCell.RowIndex;
            DataGridViewRow r = ClassAttendenceRecord.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (ClassAttendenceRecord.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    CA.Delete(id);
                    Attendence_Load(sender, e);
                    MessageBox.Show("id of the selested row is" + id);
                }
                else
                {
                    return;
                }
            }
            if (ClassAttendenceRecord.Columns[e.ColumnIndex].Name == "Edit")
            {
                AttendenceDatepicker.Value = Convert.ToDateTime(r.Cells[1].Value);
                globalindex= id;
                if (ADD.Visible)
                {
                    ADD.Visible = false;
                }
                if(Save.Visible == false)
                {
                    Save.Visible = true;
                }
            }
            if (ClassAttendenceRecord.Columns[e.ColumnIndex].Name == "StudentAttendence")
            {
                globalindex = id;
            }
        }

        

        private void ADD_Click(object sender, EventArgs e)
        {

            ClassAttendence CA = new ClassAttendence();
            CA.ADDAttendence(AttendenceDatepicker.Value);
            AttendenceDatepicker.ResetText();
            Attendence_Load(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            ClassAttendence CA = new ClassAttendence();
            CA.Edit(globalindex, AttendenceDatepicker.Value);
            AttendenceDatepicker.ResetText();
            Attendence_Load(sender, e);
            
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            if (Save.Visible)
            {
                Save.Visible = false;
            }
            ClassAttendence CA = new ClassAttendence();
            ListofClasses lt1 = new ListofClasses();
            CA.ATTendenceRecord();
            ClassAttendenceRecord.DataSource = null;
            ClassAttendenceRecord.DataSource = lt1.CA1;
         }

        private void AttendenceDatepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudentAttendence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentAttendence st = new ProjectBLab.StudentAttendence();
            this.Hide();
            st.Show();
        }
    }
}
