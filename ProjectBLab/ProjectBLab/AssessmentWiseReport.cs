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
    public partial class AssessmentWiseReport : Form
    {
        public AssessmentWiseReport()
        {
            InitializeComponent();
        }

        private void GeneratePdf_Click(object sender, EventArgs e)
        {
            GenerateReport gr = new GenerateReport();
            gr.PDF(ASSWiseReport, "AssWiseReport", "Assessment wise Report");
        }

        private void ASSWiseReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AssessmentWiseReport_Load(object sender, EventArgs e)
        {
            ListofClasses lt = new ListofClasses();

            GenerateReport Gr = new GenerateReport();
            Gr.AssessmentWiseReport();
            ASSWiseReport.DataSource = null;
            ASSWiseReport.DataSource = lt.CloReport1;
        }
    }
}
