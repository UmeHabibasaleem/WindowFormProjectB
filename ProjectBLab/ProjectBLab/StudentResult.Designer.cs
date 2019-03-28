namespace ProjectBLab
{
    partial class StudentResult
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
            this.rubricTableAdapter = new ProjectBLab.ProjectBDataSet5TableAdapters.RubricTableAdapter();
            this.studentClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new ProjectBLab.ProjectBDataSet3TableAdapters.AssessmentComponentTableAdapter();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new ProjectBLab.ProjectBDataSet3();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Save = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.projectBDataSet5 = new ProjectBLab.ProjectBDataSet5();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet4 = new ProjectBLab.ProjectBDataSet4();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RubricLSelection = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentName1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EvaluateDate = new System.Windows.Forms.DateTimePicker();
            this.AssessmentSelection = new System.Windows.Forms.ComboBox();
            this.AssessmentSel = new System.Windows.Forms.ComboBox();
            this.assessmentTableAdapter = new ProjectBLab.ProjectBDataSet4TableAdapters.AssessmentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.assessmentComClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.studentResultClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurement1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentResultRecord = new System.Windows.Forms.DataGridView();
            this.studentId1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComId1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurement1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDate1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditSR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteSr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentResultClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComClassBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultClassBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentResultRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Save, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ADD, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(581, 162);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(213, 46);
            this.tableLayoutPanel3.TabIndex = 26;
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
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet5;
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet4;
            // 
            // RubricLSelection
            // 
            this.RubricLSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricLSelection.FormattingEnabled = true;
            this.RubricLSelection.Location = new System.Drawing.Point(107, 34);
            this.RubricLSelection.Name = "RubricLSelection";
            this.RubricLSelection.Size = new System.Drawing.Size(198, 21);
            this.RubricLSelection.TabIndex = 24;
            this.RubricLSelection.Tag = "";
            this.RubricLSelection.SelectedIndexChanged += new System.EventHandler(this.RubricLSelection_SelectedIndexChanged);
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
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.StudentName1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.EvaluateDate, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.AssessmentSelection, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.RubricLSelection, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AssessmentSel, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 86);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Assessment";
            // 
            // StudentName1
            // 
            this.StudentName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentName1.FormattingEnabled = true;
            this.StudentName1.Location = new System.Drawing.Point(107, 4);
            this.StudentName1.Name = "StudentName1";
            this.StudentName1.Size = new System.Drawing.Size(198, 21);
            this.StudentName1.TabIndex = 25;
            this.StudentName1.Tag = "";
            this.StudentName1.SelectedIndexChanged += new System.EventHandler(this.StudentName1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "RubricLevel";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "StudentName";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "AssessmentCom";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "EvaluateDate";
            // 
            // EvaluateDate
            // 
            this.EvaluateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EvaluateDate.Location = new System.Drawing.Point(466, 35);
            this.EvaluateDate.Name = "EvaluateDate";
            this.EvaluateDate.Size = new System.Drawing.Size(208, 20);
            this.EvaluateDate.TabIndex = 22;
            this.EvaluateDate.ValueChanged += new System.EventHandler(this.EvaluateDate_ValueChanged);
            // 
            // AssessmentSelection
            // 
            this.AssessmentSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessmentSelection.FormattingEnabled = true;
            this.AssessmentSelection.Location = new System.Drawing.Point(466, 4);
            this.AssessmentSelection.Name = "AssessmentSelection";
            this.AssessmentSelection.Size = new System.Drawing.Size(208, 21);
            this.AssessmentSelection.TabIndex = 23;
            this.AssessmentSelection.Tag = "";
            this.AssessmentSelection.SelectedIndexChanged += new System.EventHandler(this.AssessmentSelection_SelectedIndexChanged);
            // 
            // AssessmentSel
            // 
            this.AssessmentSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessmentSel.FormattingEnabled = true;
            this.AssessmentSel.Location = new System.Drawing.Point(107, 63);
            this.AssessmentSel.Name = "AssessmentSel";
            this.AssessmentSel.Size = new System.Drawing.Size(198, 21);
            this.AssessmentSel.TabIndex = 27;
            this.AssessmentSel.Tag = "";
            this.AssessmentSel.SelectedIndexChanged += new System.EventHandler(this.AssessmentSel_SelectedIndexChanged);
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Result";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.27249F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 60);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // studentId1DataGridViewTextBoxColumn
            // 
            this.studentId1DataGridViewTextBoxColumn.DataPropertyName = "StudentId1";
            this.studentId1DataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentId1DataGridViewTextBoxColumn.Name = "studentId1DataGridViewTextBoxColumn";
            // 
            // assessmentComId1DataGridViewTextBoxColumn
            // 
            this.assessmentComId1DataGridViewTextBoxColumn.DataPropertyName = "AssessmentComId1";
            this.assessmentComId1DataGridViewTextBoxColumn.HeaderText = "AssessmentComId";
            this.assessmentComId1DataGridViewTextBoxColumn.Name = "assessmentComId1DataGridViewTextBoxColumn";
            // 
            // rubricMeasurement1DataGridViewTextBoxColumn
            // 
            this.rubricMeasurement1DataGridViewTextBoxColumn.DataPropertyName = "RubricMeasurement1";
            this.rubricMeasurement1DataGridViewTextBoxColumn.HeaderText = "RubricMeasurement";
            this.rubricMeasurement1DataGridViewTextBoxColumn.Name = "rubricMeasurement1DataGridViewTextBoxColumn";
            // 
            // evaluationDate1DataGridViewTextBoxColumn
            // 
            this.evaluationDate1DataGridViewTextBoxColumn.DataPropertyName = "EvaluationDate1";
            this.evaluationDate1DataGridViewTextBoxColumn.HeaderText = "EvaluationDate";
            this.evaluationDate1DataGridViewTextBoxColumn.Name = "evaluationDate1DataGridViewTextBoxColumn";
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.StudentResultRecord, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(16, 229);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(775, 295);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // StudentResultRecord
            // 
            this.StudentResultRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentResultRecord.AutoGenerateColumns = false;
            this.StudentResultRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentResultRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentResultRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId1DataGridViewTextBoxColumn1,
            this.assessmentComId1DataGridViewTextBoxColumn1,
            this.rubricMeasurement1DataGridViewTextBoxColumn1,
            this.evaluationDate1DataGridViewTextBoxColumn1,
            this.EditSR,
            this.DeleteSr});
            this.StudentResultRecord.DataSource = this.studentResultClassBindingSource1;
            this.StudentResultRecord.Location = new System.Drawing.Point(3, 3);
            this.StudentResultRecord.Name = "StudentResultRecord";
            this.StudentResultRecord.Size = new System.Drawing.Size(769, 289);
            this.StudentResultRecord.TabIndex = 0;
            this.StudentResultRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentResultRecord_CellContentClick);
            // 
            // studentId1DataGridViewTextBoxColumn1
            // 
            this.studentId1DataGridViewTextBoxColumn1.DataPropertyName = "StudentId1";
            this.studentId1DataGridViewTextBoxColumn1.HeaderText = "StudentId";
            this.studentId1DataGridViewTextBoxColumn1.Name = "studentId1DataGridViewTextBoxColumn1";
            // 
            // assessmentComId1DataGridViewTextBoxColumn1
            // 
            this.assessmentComId1DataGridViewTextBoxColumn1.DataPropertyName = "AssessmentComId1";
            this.assessmentComId1DataGridViewTextBoxColumn1.HeaderText = "AssessmentComId";
            this.assessmentComId1DataGridViewTextBoxColumn1.Name = "assessmentComId1DataGridViewTextBoxColumn1";
            // 
            // rubricMeasurement1DataGridViewTextBoxColumn1
            // 
            this.rubricMeasurement1DataGridViewTextBoxColumn1.DataPropertyName = "RubricMeasurement1";
            this.rubricMeasurement1DataGridViewTextBoxColumn1.HeaderText = "RubricMeasurement";
            this.rubricMeasurement1DataGridViewTextBoxColumn1.Name = "rubricMeasurement1DataGridViewTextBoxColumn1";
            // 
            // evaluationDate1DataGridViewTextBoxColumn1
            // 
            this.evaluationDate1DataGridViewTextBoxColumn1.DataPropertyName = "EvaluationDate1";
            this.evaluationDate1DataGridViewTextBoxColumn1.HeaderText = "EvaluationDate";
            this.evaluationDate1DataGridViewTextBoxColumn1.Name = "evaluationDate1DataGridViewTextBoxColumn1";
            // 
            // EditSR
            // 
            this.EditSR.DataPropertyName = "StudentId1";
            this.EditSR.HeaderText = "Edit";
            this.EditSR.Name = "EditSR";
            this.EditSR.Text = "Edit";
            this.EditSR.UseColumnTextForButtonValue = true;
            // 
            // DeleteSr
            // 
            this.DeleteSr.DataPropertyName = "StudentId1";
            this.DeleteSr.HeaderText = "Delete";
            this.DeleteSr.Name = "DeleteSr";
            this.DeleteSr.Text = "Delete";
            this.DeleteSr.UseColumnTextForButtonValue = true;
            // 
            // studentResultClassBindingSource1
            // 
            this.studentResultClassBindingSource1.DataSource = typeof(ProjectBLab.StudentResultClass);
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 536);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComClassBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultClassBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentResultRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultClassBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectBDataSet5TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.BindingSource studentClassBindingSource;
        private ProjectBDataSet3TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ADD;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet4 projectBDataSet4;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private System.Windows.Forms.ComboBox RubricLSelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox StudentName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EvaluateDate;
        private System.Windows.Forms.ComboBox AssessmentSelection;
        private ProjectBDataSet4TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurement1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource studentResultClassBindingSource;
        private System.Windows.Forms.BindingSource assessmentComClassBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView StudentResultRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComId1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurement1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDate1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn EditSR;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSr;
        private System.Windows.Forms.BindingSource studentResultClassBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AssessmentSel;
    }
}