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

        private void MeasureLevel1_TextChanged(object sender, EventArgs e)
        {
            int i = Integercheck(MeasureLevel1.Text);
            if (i > 0)
            {
                MessageBox.Show("only numeric value allow");
                MeasureLevel1.Text = "";
            }

        }

        private void MeasureLevel2_TextChanged(object sender, EventArgs e)
        {
            int i = Integercheck(MeasureLevel2.Text);
            if (i > 0)
            {
                MessageBox.Show("only numeric value allow");
                MeasureLevel2.Text = "";
            }
        }

        private void MeasureLevel3_TextChanged(object sender, EventArgs e)
        {
            int i = Integercheck(MeasureLevel3.Text);
            if (i > 0)
            {
                MessageBox.Show("only numeric value allow");
                MeasureLevel3.Text = "";
            }
        }

        private void MeasureLevel4_TextChanged(object sender, EventArgs e)
        {
            int i = Integercheck(MeasureLevel4.Text);
            if (i > 0)
            {
                MessageBox.Show("only numeric value allow");
                MeasureLevel4.Text = "";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Datails1.Text != "" &&  MeasureLevel1.Text != "" && Details2.Text != "" && MeasureLevel2.Text != "" && Datails3.Text != "" && MeasureLevel3.Text != "" && Datails4.Text != "" && MeasureLevel4.Text != "")
            {
                RubricLevelClass RL = new RubricLevelClass();
                RL.ADD_RubricL(Datails1.Text, MeasureLevel1.Text, Details2.Text, MeasureLevel2.Text, Datails3.Text, MeasureLevel3.Text, Datails4.Text, MeasureLevel4.Text, Rubricselection.Text);
                Datails1.Text = "";
                MeasureLevel1.Text = "";
                Details2.Text = "";
                MeasureLevel2.Text = "";
                Datails3.Text = "";
                MeasureLevel3.Text = "";
                Datails4.Text = "";
                MeasureLevel4.Text = "";
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
    }
}
