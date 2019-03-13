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
    public partial class Clo_Management : Form
    {
        int globalindex2;
        public Clo_Management()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         }

        private void Clo_Management_Load(object sender, EventArgs e)
        {

        }

        private void CloName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DateCreated_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateUpdated_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CloName.Text == " ")
            {
                MessageBox.Show("Must fill the Name attribute");
                CloName_TextChanged(sender, e);
            }
            if (DateCreated.Value == null)
            {
                MessageBox.Show("Must select the date for Datecreated");
                DateCreated_ValueChanged(sender, e);
            }
            if (DateUpdated.Value == null)
            {
                MessageBox.Show("Must select the date for DateUpdated");
                DateUpdated_ValueChanged(sender, e);
            }
            else
            {
                CLOClass clo1 = new CLOClass();
                clo1.ADD_Clo(CloName.Text, DateCreated.Value, DateUpdated.Value);
                CloName.Text = " ";
                DateCreated.ResetText();
                DateUpdated.ResetText();
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            CLOClass clo = new CLOClass();
            if (CloName.Text == " ")
            {
                MessageBox.Show("Must fill the Name");
                CloName_TextChanged(sender, e);
                
            }
            else
            {
                clo.Edit(globalindex2 ,CloName.Text, DateCreated.Value, DateUpdated.Value);
                CloName.Text = " ";
                DateCreated.ResetText();
                DateUpdated.ResetText();
            }
        }

        private void ClodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CLOClass sc = new CLOClass();
            ListofClasses lt = new ListofClasses();
            int index = ClodataGridView.CurrentCell.RowIndex;
            DataGridViewRow r = ClodataGridView.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (ClodataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?" +id , "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            if (ClodataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                CloName.Text = r.Cells[1].Value.ToString();
                DateCreated.Value= Convert.ToDateTime(r.Cells[2].Value);
                DateUpdated.Value = Convert.ToDateTime(r.Cells[3].Value);
                globalindex2 = id;
            }
        }

        private void Clo_Management_Load_1(object sender, EventArgs e)
        {
            CLOClass clo = new CLOClass();
            ListofClasses lt1 = new ListofClasses();
            clo.CloRecord();
            ClodataGridView.DataSource = lt1.CLOList;
        }
    }
}
