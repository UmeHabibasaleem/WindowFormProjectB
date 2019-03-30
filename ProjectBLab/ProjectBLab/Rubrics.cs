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
    public partial class Rubrics : Form
    {
        string CLO;
        int globalindex;
        int datagridviewindex;
        public Rubrics()
        {
            InitializeComponent();
        }
        public void comoboxvalues()
        {
            RubricsClass Rub = new RubricsClass();
            ListofClasses lt1 = new ListofClasses();
            Rub.addCLOname();
            int length = lt1.Cloname.Count();
            Closelection.Items.Clear();

            for (int i = 0; i < length; i++)
            {
                Closelection.Items.Add(lt1.Cloname.ElementAt(i));
            }
        }
        private void My_Own_Load()
        {
            RubricsClass Rub = new RubricsClass();
            ListofClasses lt1 = new ListofClasses();
            Rub.RubricRecord();
            RubricsDetail.DataSource = lt1.RubList;
            comoboxvalues();


        }
        private void Rubrics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter1.Fill(this.projectBDataSet1.Clo);
            My_Own_Load();
           
           
        }

        

        private void Add_Click(object sender, EventArgs e)
        {

            RubricsClass rub = new RubricsClass();
           
            if(Details.Text == " ")
            {
                MessageBox.Show("please fill the detail box first");
                Details_TextChanged(sender, e);
            }
            else
            {
                string clo = Closelection.GetItemText(Closelection.SelectedItem);
                rub.ADD_Rubric(Details.Text, clo);
                RubricsDetail.DataSource = null;
                Details.Text = " ";
                Closelection.Text = " ";
                My_Own_Load();
            }
            
        }

        private void Details_TextChanged(object sender, EventArgs e)
       {

        }

        private void RubricsDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            RubricsClass Rub = new RubricsClass();
            ListofClasses lt = new ListofClasses();
            int index = RubricsDetail.CurrentCell.RowIndex;
            datagridviewindex = index;
            DataGridViewRow r = RubricsDetail.Rows[index];
            int id = Convert.ToInt32(r.Cells[0].Value);
            if (RubricsDetail.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Do You Want to delete data against the id ?" + id, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    Rub.Delete(id);
                    RubricsDetail.DataSource = null;
                    Details.Text = " ";
                    Closelection.SelectedText = " ";
                    My_Own_Load();
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
           if (RubricsDetail.Columns[e.ColumnIndex].Name == "Edit")
            {
                comoboxvalues();
                Details.Text = r.Cells[2].Value.ToString();
                CLO = r.Cells[1].Value.ToString();
                Closelection.SelectedText = CLO;
                globalindex = id;
                if (Add.Visible) 
                {
                    Add.Visible = false;  
                }
               
            } 
        }

        private void Save_Click(object sender, EventArgs e)
        {
            RubricsClass Rub = new RubricsClass();
            Rub.Edit(globalindex, Details.Text, Closelection.Text);
            RubricsDetail.DataSource = null;
            My_Own_Load();
            Details.Text = " ";
            Closelection.Text= " ";
            Add.Visible = true;
        }

        private void Closelection_SelectedIndexChanged(object sender, EventArgs e)
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
