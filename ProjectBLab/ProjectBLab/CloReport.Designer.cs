namespace ProjectBLab
{
    partial class CloReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CloWiseReport = new System.Windows.Forms.DataGridView();
            this.registrationNumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloName1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainMarks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GeneratePdf = new System.Windows.Forms.Button();
            this.generateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloWiseReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CloWiseReport, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CloWiseReport
            // 
            this.CloWiseReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloWiseReport.AutoGenerateColumns = false;
            this.CloWiseReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CloWiseReport.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.CloWiseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CloWiseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumber1DataGridViewTextBoxColumn,
            this.cloName1DataGridViewTextBoxColumn,
            this.obtainMarks1DataGridViewTextBoxColumn});
            this.CloWiseReport.DataSource = this.generateReportBindingSource1;
            this.CloWiseReport.Location = new System.Drawing.Point(3, 3);
            this.CloWiseReport.Name = "CloWiseReport";
            this.CloWiseReport.Size = new System.Drawing.Size(610, 373);
            this.CloWiseReport.TabIndex = 0;
            this.CloWiseReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CloWiseReport_CellContentClick);
            // 
            // registrationNumber1DataGridViewTextBoxColumn
            // 
            this.registrationNumber1DataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber1";
            this.registrationNumber1DataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumber1DataGridViewTextBoxColumn.Name = "registrationNumber1DataGridViewTextBoxColumn";
            // 
            // cloName1DataGridViewTextBoxColumn
            // 
            this.cloName1DataGridViewTextBoxColumn.DataPropertyName = "CloName1";
            this.cloName1DataGridViewTextBoxColumn.HeaderText = "CloName";
            this.cloName1DataGridViewTextBoxColumn.Name = "cloName1DataGridViewTextBoxColumn";
            // 
            // obtainMarks1DataGridViewTextBoxColumn
            // 
            this.obtainMarks1DataGridViewTextBoxColumn.DataPropertyName = "ObtainMarks1";
            this.obtainMarks1DataGridViewTextBoxColumn.HeaderText = "ObtainMarks";
            this.obtainMarks1DataGridViewTextBoxColumn.Name = "obtainMarks1DataGridViewTextBoxColumn";
            // 
            // generateReportBindingSource1
            // 
            this.generateReportBindingSource1.DataSource = typeof(ProjectBLab.GenerateReport);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.GeneratePdf, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(291, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // GeneratePdf
            // 
            this.GeneratePdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratePdf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GeneratePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePdf.Location = new System.Drawing.Point(3, 3);
            this.GeneratePdf.Name = "GeneratePdf";
            this.GeneratePdf.Size = new System.Drawing.Size(194, 29);
            this.GeneratePdf.TabIndex = 0;
            this.GeneratePdf.Text = "Generate pdf";
            this.GeneratePdf.UseVisualStyleBackColor = false;
            this.GeneratePdf.Click += new System.EventHandler(this.GeneratePdf_Click);
            // 
            // generateReportBindingSource
            // 
            this.generateReportBindingSource.DataSource = typeof(ProjectBLab.GenerateReport);
            // 
            // CloReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(754, 506);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CloReport";
            this.Text = "CloReport";
            this.Load += new System.EventHandler(this.CloReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloWiseReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView CloWiseReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.BindingSource generateReportBindingSource;
        private System.Windows.Forms.Button GeneratePdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloName1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainMarks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generateReportBindingSource1;
    }
}