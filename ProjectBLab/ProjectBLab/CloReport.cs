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
    public partial class CloReport : Form
    {
        public CloReport()
        {
            InitializeComponent();
        }

        private void CloReport_Load(object sender, EventArgs e)
        {
            ListofClasses lt = new ListofClasses();
            
            GenerateReport Gr = new GenerateReport();
            Gr.CLOwiseReport();
            CloWiseReport.DataSource = null;
            CloWiseReport.DataSource = lt.CloReport1;


        }

        private void CloWiseReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void GeneratePdf_Click(object sender, EventArgs e)
        {
            GenerateReport gr = new GenerateReport();
            gr.PDF(CloWiseReport, "CloReport","Clo wise Report");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generateReportBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void generateReportBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void generateReportBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void generateReportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
