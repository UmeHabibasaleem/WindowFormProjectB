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

        public void PDF(DataGridView data, String Filename)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftable = new PdfPTable(data.Columns.Count);
                pdftable.PaddingTop = 10;
                pdftable.DefaultCell.Padding = 3;
                pdftable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdftable.DefaultCell.BorderWidth = 1;
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                foreach (DataGridViewColumn Column in data.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(Column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }
                foreach (DataGridViewRow row in data.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }
                var savefilediologe = new SaveFileDialog();
                savefilediologe.FileName = Filename;
                savefilediologe.DefaultExt = ".pdf";
                if (savefilediologe.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefilediologe.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        Paragraph p1 = new Paragraph("Clo wise Report");
                        p1.Alignment = Element.ALIGN_TOP;
                        p1.PaddingTop = 10;
                        pdfdoc.Add(p1);
                        pdfdoc.Add(pdftable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("File is in use.Firstly close it then try");
                return;
            }
            MessageBox.Show("File created successfully");
                
        }
        private void GeneratePdf_Click(object sender, EventArgs e)
        {
            PDF(CloWiseReport, "CloReport");
        }
    }
}
