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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void StuManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentForm st = new StudentForm();
            this.Hide();
            st.Show();
        }

        private void CloManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clo_Management clo = new Clo_Management();
            this.Hide();
            clo.Show();
        }

        private void RubManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubrics rub = new Rubrics();
            this.Hide();
            rub.Show();
        }

        private void RLManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel rl = new RubricLevel();
            this.Hide();
            rl.Show();
        }

        private void StuResultManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentResult sr = new StudentResult();
            this.Hide();
            sr.Show();
        }

        private void ASSMAnagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assessment ass = new Assessment();
            this.Hide();
            ass.Show();
        }

        private void AssComManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentComponent AC = new AssessmentComponent();
            this.Hide();
            AC.Show();
        }
    }
}
