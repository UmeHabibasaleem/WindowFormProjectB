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
    public partial class RubricLevelindex : Form
    {
        int globalindex;
        public RubricLevelindex()
        {
            InitializeComponent();
        }

        private void RubricLevelindex_Load(object sender, EventArgs e)
        {
            ListofClasses lt = new ListofClasses();
            RubricLevelClass Rlb = new RubricLevelClass();
            Rlb.RubricLRecord(); 
            RubLevelRecord.DataSource = lt.RLC;
        }

        private void RubLevelRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            RubricLevelClass Rub = new RubricLevelClass();
            ListofClasses lt = new ListofClasses();
            int index = RubLevelRecord.CurrentCell.RowIndex;
            DataGridViewRow r = RubLevelRecord.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (RubLevelRecord.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete data against the id ?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    Rub.Delete(id);
                    RubLevelRecord.DataSource = null;
                    RubricLevelindex_Load(sender, e);
                    if (Add.Visible == false)
                    {
                        Add.Visible = true;
                    }
                }
                else
                {
                    return;
                }
            }
           if (RubLevelRecord.Columns[e.ColumnIndex].Name == "Edit")
            {
              
                Details.Text = r.Cells[1].Value.ToString();
                Measurement.Text = r.Cells[2].Value.ToString();
                globalindex = id;
                if (Add.Visible)
                {
                    Add.Visible = false;
                }

            } 
        }

        private void Save_Click(object sender, EventArgs e)
        {
            RubricLevelClass RLC = new RubricLevelClass();
            RLC.Edit(globalindex, Details.Text, Measurement.Text);
            RubLevelRecord.DataSource = null;
            RubricLevelindex_Load(sender, e);
            Details.Text = " ";
            Measurement.Text = " ";
            Add.Visible = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
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
