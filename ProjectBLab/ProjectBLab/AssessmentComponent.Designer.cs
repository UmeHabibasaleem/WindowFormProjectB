namespace ProjectBLab
{
    partial class AssessmentComponent
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AssessmentRecord = new System.Windows.Forms.DataGridView();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdated1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assessmentComClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ASSName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalMarks = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AssessmentSelection = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet4 = new ProjectBLab.ProjectBDataSet4();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.DateUpdated = new System.Windows.Forms.DateTimePicker();
            this.RubricSelection = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet5 = new ProjectBLab.ProjectBDataSet5();
            this.ADD = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.projectBDataSet3 = new ProjectBLab.ProjectBDataSet3();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new ProjectBLab.ProjectBDataSet3TableAdapters.AssessmentComponentTableAdapter();
            this.studentClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentTableAdapter = new ProjectBLab.ProjectBDataSet4TableAdapters.AssessmentTableAdapter();
            this.rubricTableAdapter = new ProjectBLab.ProjectBDataSet5TableAdapters.RubricTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComClassBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AssessmentComponent ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.27249F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 60);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // AssessmentRecord
            // 
            this.AssessmentRecord.AutoGenerateColumns = false;
            this.AssessmentRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssessmentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1DataGridViewTextBoxColumn,
            this.name1DataGridViewTextBoxColumn,
            this.rubricId1DataGridViewTextBoxColumn,
            this.totalMarks1DataGridViewTextBoxColumn,
            this.dateCreated1DataGridViewTextBoxColumn,
            this.dateUpdated1DataGridViewTextBoxColumn,
            this.assessmentId1DataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.AssessmentRecord.DataSource = this.assessmentComClassBindingSource;
            this.AssessmentRecord.Location = new System.Drawing.Point(14, 223);
            this.AssessmentRecord.Name = "AssessmentRecord";
            this.AssessmentRecord.Size = new System.Drawing.Size(778, 306);
            this.AssessmentRecord.TabIndex = 21;
            this.AssessmentRecord.Tag = "Delete";
            this.AssessmentRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssessmentRecord_CellContentClick);
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "Id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "Id";
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            // 
            // name1DataGridViewTextBoxColumn
            // 
            this.name1DataGridViewTextBoxColumn.DataPropertyName = "Name1";
            this.name1DataGridViewTextBoxColumn.HeaderText = "Name";
            this.name1DataGridViewTextBoxColumn.Name = "name1DataGridViewTextBoxColumn";
            // 
            // rubricId1DataGridViewTextBoxColumn
            // 
            this.rubricId1DataGridViewTextBoxColumn.DataPropertyName = "RubricId1";
            this.rubricId1DataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricId1DataGridViewTextBoxColumn.Name = "rubricId1DataGridViewTextBoxColumn";
            // 
            // totalMarks1DataGridViewTextBoxColumn
            // 
            this.totalMarks1DataGridViewTextBoxColumn.DataPropertyName = "TotalMarks1";
            this.totalMarks1DataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarks1DataGridViewTextBoxColumn.Name = "totalMarks1DataGridViewTextBoxColumn";
            // 
            // dateCreated1DataGridViewTextBoxColumn
            // 
            this.dateCreated1DataGridViewTextBoxColumn.DataPropertyName = "DateCreated1";
            this.dateCreated1DataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreated1DataGridViewTextBoxColumn.Name = "dateCreated1DataGridViewTextBoxColumn";
            // 
            // dateUpdated1DataGridViewTextBoxColumn
            // 
            this.dateUpdated1DataGridViewTextBoxColumn.DataPropertyName = "DateUpdated1";
            this.dateUpdated1DataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdated1DataGridViewTextBoxColumn.Name = "dateUpdated1DataGridViewTextBoxColumn";
            // 
            // assessmentId1DataGridViewTextBoxColumn
            // 
            this.assessmentId1DataGridViewTextBoxColumn.DataPropertyName = "AssessmentId1";
            this.assessmentId1DataGridViewTextBoxColumn.HeaderText = "AssessmentId";
            this.assessmentId1DataGridViewTextBoxColumn.Name = "assessmentId1DataGridViewTextBoxColumn";
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
            // assessmentComClassBindingSource
            // 
            this.assessmentComClassBindingSource.DataSource = typeof(ProjectBLab.AssessmentComClass);
            // 
            // ASSName
            // 
            this.ASSName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ASSName.Location = new System.Drawing.Point(107, 3);
            this.ASSName.Name = "ASSName";
            this.ASSName.Size = new System.Drawing.Size(198, 20);
            this.ASSName.TabIndex = 8;
            this.ASSName.TextChanged += new System.EventHandler(this.ASSName_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Rubric";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "DateUpdated";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "TotalMarks";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "DateCreated";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Assessment";
            // 
            // TotalMarks
            // 
            this.TotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalMarks.Location = new System.Drawing.Point(466, 3);
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Size = new System.Drawing.Size(208, 20);
            this.TotalMarks.TabIndex = 9;
            this.TotalMarks.TextChanged += new System.EventHandler(this.TotalMarks_TextChanged);
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
            this.tableLayoutPanel2.Controls.Add(this.AssessmentSelection, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TotalMarks, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ASSName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DateCreated, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DateUpdated, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.RubricSelection, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 83);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // AssessmentSelection
            // 
            this.AssessmentSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessmentSelection.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assessmentBindingSource, "Title", true));
            this.AssessmentSelection.DataSource = this.assessmentBindingSource;
            this.AssessmentSelection.DisplayMember = "Title";
            this.AssessmentSelection.FormattingEnabled = true;
            this.AssessmentSelection.Location = new System.Drawing.Point(107, 61);
            this.AssessmentSelection.Name = "AssessmentSelection";
            this.AssessmentSelection.Size = new System.Drawing.Size(198, 21);
            this.AssessmentSelection.TabIndex = 24;
            this.AssessmentSelection.Tag = "";
            this.AssessmentSelection.ValueMember = "Title";
            this.AssessmentSelection.SelectedIndexChanged += new System.EventHandler(this.AssessmentSelection_SelectedIndexChanged);
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet4;
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateCreated
            // 
            this.DateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateCreated.Location = new System.Drawing.Point(107, 32);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(198, 20);
            this.DateCreated.TabIndex = 21;
            this.DateCreated.ValueChanged += new System.EventHandler(this.DateCreated_ValueChanged);
            // 
            // DateUpdated
            // 
            this.DateUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateUpdated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateUpdated.Location = new System.Drawing.Point(466, 32);
            this.DateUpdated.Name = "DateUpdated";
            this.DateUpdated.Size = new System.Drawing.Size(208, 20);
            this.DateUpdated.TabIndex = 22;
            this.DateUpdated.ValueChanged += new System.EventHandler(this.DateUpdated_ValueChanged);
            // 
            // RubricSelection
            // 
            this.RubricSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricSelection.FormattingEnabled = true;
            this.RubricSelection.Location = new System.Drawing.Point(466, 61);
            this.RubricSelection.Name = "RubricSelection";
            this.RubricSelection.Size = new System.Drawing.Size(208, 21);
            this.RubricSelection.TabIndex = 23;
            this.RubricSelection.Tag = "";
            this.RubricSelection.SelectedIndexChanged += new System.EventHandler(this.RubricSelection_SelectedIndexChanged);
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet5;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ADD
            // 
            this.ADD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(3, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(100, 40);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(109, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 40);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save  ";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Save, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ADD, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(579, 162);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(213, 46);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet3;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // studentClassBindingSource
            // 
            this.studentClassBindingSource.DataSource = typeof(ProjectBLab.StudentClass);
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // AssessmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 536);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.AssessmentRecord);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssessmentComponent";
            this.Text = "AssessmentComponent";
            this.Load += new System.EventHandler(this.AssessmentComponent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComClassBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView AssessmentRecord;
        private System.Windows.Forms.BindingSource studentClassBindingSource;
        private System.Windows.Forms.TextBox ASSName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalMarks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker DateCreated;
        private System.Windows.Forms.DateTimePicker DateUpdated;
        private System.Windows.Forms.ComboBox AssessmentSelection;
        private System.Windows.Forms.ComboBox RubricSelection;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet3TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdated1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource assessmentComClassBindingSource;
        private ProjectBDataSet4 projectBDataSet4;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet4TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet5TableAdapters.RubricTableAdapter rubricTableAdapter;
    }
}