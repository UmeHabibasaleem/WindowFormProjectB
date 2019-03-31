namespace ProjectBLab
{
    partial class AssessmentWiseReport
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GeneratePdf = new System.Windows.Forms.Button();
            this.registrationNumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloName1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainMarks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSWiseReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateReportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.generateReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.generateReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ASSWiseReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ASSWiseReport, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 379);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.GeneratePdf, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(279, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // GeneratePdf
            // 
            this.GeneratePdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratePdf.AutoSize = true;
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
            // registrationNumber1DataGridViewTextBoxColumn
            // 
            this.registrationNumber1DataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber1";
            this.registrationNumber1DataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumber1DataGridViewTextBoxColumn.Name = "registrationNumber1DataGridViewTextBoxColumn";
            // 
            // cloName1DataGridViewTextBoxColumn
            // 
            this.cloName1DataGridViewTextBoxColumn.DataPropertyName = "CloName1";
            this.cloName1DataGridViewTextBoxColumn.HeaderText = "AssessmentTitle";
            this.cloName1DataGridViewTextBoxColumn.Name = "cloName1DataGridViewTextBoxColumn";
            // 
            // totalMarks1DataGridViewTextBoxColumn
            // 
            this.totalMarks1DataGridViewTextBoxColumn.DataPropertyName = "TotalMarks1";
            this.totalMarks1DataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarks1DataGridViewTextBoxColumn.Name = "totalMarks1DataGridViewTextBoxColumn";
            // 
            // obtainMarks1DataGridViewTextBoxColumn
            // 
            this.obtainMarks1DataGridViewTextBoxColumn.DataPropertyName = "ObtainMarks1";
            this.obtainMarks1DataGridViewTextBoxColumn.HeaderText = "ObtainMarks";
            this.obtainMarks1DataGridViewTextBoxColumn.Name = "obtainMarks1DataGridViewTextBoxColumn";
            // 
            // ASSWiseReport
            // 
            this.ASSWiseReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ASSWiseReport.AutoGenerateColumns = false;
            this.ASSWiseReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ASSWiseReport.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.ASSWiseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ASSWiseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ASSWiseReport.DataSource = this.generateReportBindingSource3;
            this.ASSWiseReport.Location = new System.Drawing.Point(3, 3);
            this.ASSWiseReport.Name = "ASSWiseReport";
            this.ASSWiseReport.Size = new System.Drawing.Size(610, 373);
            this.ASSWiseReport.TabIndex = 1;
            this.ASSWiseReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ASSWiseReport_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegistrationNumber1";
            this.dataGridViewTextBoxColumn1.HeaderText = "RegistrationNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CloName1";
            this.dataGridViewTextBoxColumn2.HeaderText = "AssessmentTitle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalMarks1";
            this.dataGridViewTextBoxColumn3.HeaderText = "TotalMarks";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ObtainMarks1";
            this.dataGridViewTextBoxColumn4.HeaderText = "ObtainMarks";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // generateReportBindingSource3
            // 
            this.generateReportBindingSource3.DataSource = typeof(ProjectBLab.GenerateReport);
            // 
            // generateReportBindingSource2
            // 
            this.generateReportBindingSource2.DataSource = typeof(ProjectBLab.GenerateReport);
            // 
            // generateReportBindingSource1
            // 
            this.generateReportBindingSource1.DataSource = typeof(ProjectBLab.GenerateReport);
            // 
            // generateReportBindingSource
            // 
            this.generateReportBindingSource.DataSource = typeof(ProjectBLab.GenerateReport);
            // 
            // AssessmentWiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(726, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AssessmentWiseReport";
            this.Text = "AssessmentWiseReport";
            this.Load += new System.EventHandler(this.AssessmentWiseReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ASSWiseReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource generateReportBindingSource3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button GeneratePdf;
        private System.Windows.Forms.BindingSource generateReportBindingSource2;
        private System.Windows.Forms.BindingSource generateReportBindingSource1;
        private System.Windows.Forms.BindingSource generateReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloName1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainMarks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ASSWiseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}