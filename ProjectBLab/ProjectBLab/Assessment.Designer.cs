namespace ProjectBLab
{
    partial class Assessment
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
            this.button2 = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.AssessmentRecord = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Save = new System.Windows.Forms.Button();
            this.Totalweightage = new System.Windows.Forms.TextBox();
            this.TotalMarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.TextBox();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightage1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentRecord)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(109, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save  ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            this.ADD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(134, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(125, 40);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // AssessmentRecord
            // 
            this.AssessmentRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessmentRecord.AutoGenerateColumns = false;
            this.AssessmentRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssessmentRecord.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.AssessmentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1DataGridViewTextBoxColumn,
            this.title1DataGridViewTextBoxColumn,
            this.dateCreated1DataGridViewTextBoxColumn,
            this.totalMarks1DataGridViewTextBoxColumn,
            this.totalWeightage1DataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.AssessmentRecord.DataSource = this.assessmentClassBindingSource;
            this.AssessmentRecord.Location = new System.Drawing.Point(3, 3);
            this.AssessmentRecord.Name = "AssessmentRecord";
            this.AssessmentRecord.Size = new System.Drawing.Size(781, 317);
            this.AssessmentRecord.TabIndex = 20;
            this.AssessmentRecord.Tag = "Delete";
            this.AssessmentRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssessmentRecord_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id1";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id1";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "TotalWeightage";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.Save, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ADD, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Home, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(44, 165);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(787, 46);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(265, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(125, 40);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Totalweightage
            // 
            this.Totalweightage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Totalweightage.Location = new System.Drawing.Point(470, 52);
            this.Totalweightage.Name = "Totalweightage";
            this.Totalweightage.Size = new System.Drawing.Size(210, 20);
            this.Totalweightage.TabIndex = 11;
            this.Totalweightage.TextChanged += new System.EventHandler(this.Totalweightage_TextChanged);
            // 
            // TotalMarks
            // 
            this.TotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalMarks.Location = new System.Drawing.Point(108, 52);
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Size = new System.Drawing.Size(200, 20);
            this.TotalMarks.TabIndex = 10;
            this.TotalMarks.TextChanged += new System.EventHandler(this.TotalMarks_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "TotalMarks";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "DateCreated";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.49614F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.34962F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63496F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85347F));
            this.tableLayoutPanel2.Controls.Add(this.Totalweightage, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Title, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalMarks, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DateCreated, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(44, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 83);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Location = new System.Drawing.Point(108, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 20);
            this.Title.TabIndex = 8;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateCreated.Location = new System.Drawing.Point(470, 10);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(210, 20);
            this.DateCreated.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.27249F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 47);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Home
            // 
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.LinkColor = System.Drawing.Color.MidnightBlue;
            this.Home.Location = new System.Drawing.Point(527, 8);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(125, 29);
            this.Home.TabIndex = 22;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Home_LinkClicked);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.AssessmentRecord, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(44, 231);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(787, 323);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "Id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "Id";
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            // 
            // title1DataGridViewTextBoxColumn
            // 
            this.title1DataGridViewTextBoxColumn.DataPropertyName = "Title1";
            this.title1DataGridViewTextBoxColumn.HeaderText = "Title";
            this.title1DataGridViewTextBoxColumn.Name = "title1DataGridViewTextBoxColumn";
            // 
            // dateCreated1DataGridViewTextBoxColumn
            // 
            this.dateCreated1DataGridViewTextBoxColumn.DataPropertyName = "DateCreated1";
            this.dateCreated1DataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreated1DataGridViewTextBoxColumn.Name = "dateCreated1DataGridViewTextBoxColumn";
            // 
            // totalMarks1DataGridViewTextBoxColumn
            // 
            this.totalMarks1DataGridViewTextBoxColumn.DataPropertyName = "TotalMarks1";
            this.totalMarks1DataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarks1DataGridViewTextBoxColumn.Name = "totalMarks1DataGridViewTextBoxColumn";
            // 
            // totalWeightage1DataGridViewTextBoxColumn
            // 
            this.totalWeightage1DataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage1";
            this.totalWeightage1DataGridViewTextBoxColumn.HeaderText = "TotalWeightage";
            this.totalWeightage1DataGridViewTextBoxColumn.Name = "totalWeightage1DataGridViewTextBoxColumn";
            // 
            // assessmentClassBindingSource
            // 
            this.assessmentClassBindingSource.DataSource = typeof(ProjectBLab.AssessmentClass);
            // 
            // studentClassBindingSource
            // 
            this.studentClassBindingSource.DataSource = typeof(ProjectBLab.StudentClass);
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(875, 566);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Assessment";
            this.Text = "Assessment";
            this.Load += new System.EventHandler(this.Assessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentRecord)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentClassBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.DataGridView AssessmentRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox Totalweightage;
        private System.Windows.Forms.TextBox TotalMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightage1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource assessmentClassBindingSource;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.LinkLabel Home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}