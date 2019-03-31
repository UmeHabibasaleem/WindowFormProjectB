using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        private void Attendene_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Attendence AT = new Attendence();
            this.Hide();
            AT.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentAttendence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentAttendence SA = new StudentAttendence();
            this.Hide();
            SA.Show();
        }

        private void GenerateCloReport_Click(object sender, EventArgs e)
        {
            CloReport Cr = new CloReport();
            this.Hide();
            Cr.Show();
          /*  Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("E:/Create.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("HelloWorld!");
            doc.Add(p1);
            doc.Close();
            MessageBox.Show("file successfully created"); */


        }

        private void AssessmentReport_Click(object sender, EventArgs e)
        {
            AssessmentWiseReport AWR = new AssessmentWiseReport();
            this.Hide();
            AWR.Show();
        }
    }
}
