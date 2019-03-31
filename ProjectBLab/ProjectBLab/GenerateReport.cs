using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace ProjectBLab
{
    /// <summary>
    /// This Class Contain the Functions and Datamembers related to the Generate the CLO Report.
    /// </summary>
    class GenerateReport
    {
        /// <summary>
        /// Datamemebers and the Getter Seter functions of Datamemebers.
        /// </summary>
        private string RegistrationNumber;
        private int TotalMarks;
        private int ObtainMarks;
        private string CloName;
      

        public string RegistrationNumber1
        {
            get
            {
                return RegistrationNumber;
            }

            set
            {
                RegistrationNumber = value;
            }
        }

        public int ObtainMarks1
        {
            get
            {
                return ObtainMarks;
            }

            set
            {
                ObtainMarks = value;
            }
        }

        public string CloName1
        {
            get
            {
                return CloName;
            }

            set
            {
                CloName = value;
            }
        }

        public int TotalMarks1
        {
            get
            {
                return TotalMarks;
            }

            set
            {
                TotalMarks = value;
            }
        }

        /// <summary>
        /// This function used to generate the result of the students acording to the clo's.In this function a query is used to generate the required result.
        /// </summary>
        public void CLOwiseReport()
        {
            string query = " Select sub2.RegistrationNumber,sub2.Name,Sum(sub2.TotalMarks)as TotalMarks,sum(Sub2.Result) as ObtainMarks from " +
            "(Select sub.RegistrationNumber, sub.Name, Sub.MeasurementLevel, Sub.TotalMarks, (Sub.MeasurementLevel * Sub.TotalMarks) / 4.0 as Result From " +
            "(SELECT   S.RegistrationNumber, MeasurementLevel, TotalMarks, Clo.Name, R.Details " +
            "FROM StudentResult as SR " +
            "INNER JOIN Student as S ON StudentId = S.Id " +
            "INNER JOIN AssessmentComponent ON AssessmentComponentId = AssessmentComponent.Id " +
            "INNER JOIN RubricLevel As RL ON RL.Id = SR.RubricMeasurementId " +
            "INNER JOIN Rubric AS R ON R.Id = RL.RubricId " +
            "INNER JoIN Clo ON R.CloId = Clo.Id) as sub) as sub2 Group By RegistrationNumber , Name Order By RegistrationNumber";
            Connection c1 = new Connection();
            c1.ClowiseResultRecord(query);
            
        }

        /// <summary>
        /// This function is used to generate the Result of the student according to the ssessment 
        /// </summary>
        public void AssessmentWiseReport()
        {
            string query = "Select sub3.RegistrationNumber,Title,TotalMarks,Sum(sub3.Result)As ObtainedMarks from " +
            "(Select sub2.RegistrationNumber, sub2.Result, AssessmentId, sub2.Name from " +
            "(Select sub.RegistrationNumber, sub.Name, Sub.MeasurementLevel, AssessmentComponentId, AssessmentId, Sub.TotalMarks, (Sub.MeasurementLevel * Sub.TotalMarks) / 4.0 as Result From " +
            "(SELECT   S.RegistrationNumber, MeasurementLevel, TotalMarks, Clo.Name, R.Details, AssessmentComponentId, AssessmentId "+
            "FROM StudentResult as SR "+
            "INNER JOIN Student as S ON StudentId = S.Id "+
            "INNER JOIN AssessmentComponent ON AssessmentComponentId = AssessmentComponent.Id "+
             "INNER JOIN RubricLevel As RL ON RL.Id = SR.RubricMeasurementId "+
            "INNER JOIN Rubric AS R ON R.Id = RL.RubricId "+ 
            "INNER JoIN Clo ON R.CloId = Clo.Id) as sub) as sub2 "+
            "where AssessmentComponentId = sub2.AssessmentComponentId) as sub3 "+
            "INNER JOIN Assessment as ASS oN ASS.Id = AssessmentId "+
            "Group by RegistrationNumber,Title,TotalMarks";
            Connection c1 = new Connection();
            c1.ClowiseResultRecord(query);
        }

        /// <summary>
        /// This function used to generate the Pdf of the Result
        /// </summary>
        /// <param name="data">Indicate the name of the grid</param>
        /// <param name="Filename">Indicate the name of the File</param>
        /// <param name="Heading">Indicate the heading of the file</param>
        public void PDF(DataGridView data, String Filename ,string Heading)
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
                        Paragraph p1 = new Paragraph(Heading);
                        p1.Alignment = Element.ALIGN_TOP;
                        p1.PaddingTop = 10;
                        pdfdoc.Add(p1);
                        pdfdoc.Add(pdftable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File is in use.Firstly close it then try");
                return;
            }
            MessageBox.Show("File created successfully");

        }
    }
}
