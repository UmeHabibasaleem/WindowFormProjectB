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
    public partial class RubricLevel : Form
    {
        public RubricLevel()
        {
            InitializeComponent();
        }

        private void RubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);

        }
        public int  charatercheck(string abc)
        {
            int count = 0;

            foreach (char c in abc)
            {
                if (!Char.IsLetter(c))
                {
                    count++;
                }
            }
           return count;
        }
        public int Integercheck(string abc)
        {
            int count = 0;

            foreach (char c in abc)
            {
                if (!Char.IsDigit(c))
                {
                    count++;
                }

            }

            return count;
        }
        private void Datails1_TextChanged(object sender, EventArgs e)
        {
            int i = charatercheck(Datails1.Text);
            if (i > 0)
            {
                MessageBox.Show(" only alphabetic worlld allow");
                Datails1.Text = "";
            }
        }

        private void Details2_TextChanged(object sender, EventArgs e)
        {
            int i = charatercheck(Details2.Text);
            if (i > 0)
            {
                MessageBox.Show(" only alphabetic worlld allow");
                Details2.Text = "";
            }
        }

        private void Datails3_TextChanged(object sender, EventArgs e)
        {
            int i = charatercheck(Datails3.Text);
            if (i > 0)
            {
                MessageBox.Show(" only alphabetic worlld allow");
                Datails3.Text = "";
            }
        }

        private void Datails4_TextChanged(object sender, EventArgs e)
        {
            int i = charatercheck(Datails4.Text);
            if (i > 0)
            {
                MessageBox.Show(" only alphabetic worlld allow");
                Datails4.Text = "";
            }
        }

       

        private void Add_Click(object sender, EventArgs e)
        {
            if (Datails1.Text != "" && MeasurementcomboBox1.Text != "" && Details2.Text != "" && MeasurementcomboBox2.Text != "" && Datails3.Text != "" && MeasurementcomboBox3.Text != "" && Datails4.Text != "" && MeasurementcomboBox4.Text != "")
            {
                RubricLevelClass RL = new RubricLevelClass();
                RL.ADD_RubricL(Datails1.Text.Trim(), MeasurementcomboBox1.Text.Trim(), Details2.Text.Trim(), MeasurementcomboBox2.Text.Trim(), Datails3.Text.Trim(), MeasurementcomboBox3.Text.Trim(), Datails4.Text.Trim(), MeasurementcomboBox4.Text.Trim(), Rubricselection.Text);
                MessageBox.Show("Data has been addes successfully");
                Datails1.Text = "";
                MeasurementcomboBox1.Text = "";
                Details2.Text = "";
                MeasurementcomboBox2.Text = "";
                Datails3.Text = "";
                MeasurementcomboBox3.Text = "";
                Datails4.Text = "";
                MeasurementcomboBox4.Text = "";
                Rubricselection.Text = "";
            }
            else
            {
                MessageBox.Show("firstly fill all the fields to further proceed");
                
            }
            RubricLevelindex RLI = new RubricLevelindex();
            this.Hide();
            RLI.Show();
        }

        private void Rubricselection_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MeasurementcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
