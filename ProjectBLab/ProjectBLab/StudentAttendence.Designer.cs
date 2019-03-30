namespace ProjectBLab
{
    partial class StudentAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendence));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ATTDate = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.AttendencedateComobox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentName1 = new System.Windows.Forms.ComboBox();
            this.AttendenceDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AttendenceAtatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClassAttendence = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentAttendenceRecord = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.attendanceId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatus1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAttendenceClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendenceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.99838F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.29957F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85239F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.23589F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49595F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49595F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49595F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.99838F));
            this.tableLayoutPanel4.Controls.Add(this.Home, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.AttendencedateComobox, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.ATTDate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Save, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.ADD, 4, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(77, 153);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(691, 39);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // ATTDate
            // 
            this.ATTDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ATTDate.AutoSize = true;
            this.ATTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATTDate.Location = new System.Drawing.Point(44, 9);
            this.ATTDate.Name = "ATTDate";
            this.ATTDate.Size = new System.Drawing.Size(141, 20);
            this.ATTDate.TabIndex = 28;
            this.ATTDate.Text = "AttendenceDate";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(485, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 33);
            this.Save.TabIndex = 1;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ADD
            // 
            this.ADD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(399, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(80, 33);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // AttendencedateComobox
            // 
            this.AttendencedateComobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendencedateComobox.FormattingEnabled = true;
            this.AttendencedateComobox.Location = new System.Drawing.Point(198, 9);
            this.AttendencedateComobox.Name = "AttendencedateComobox";
            this.AttendencedateComobox.Size = new System.Drawing.Size(145, 21);
            this.AttendencedateComobox.TabIndex = 27;
            this.AttendencedateComobox.Tag = "";
            this.AttendencedateComobox.SelectedIndexChanged += new System.EventHandler(this.AttendencedateComobox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.328613F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.87817F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.328613F));
            this.tableLayoutPanel2.Controls.Add(this.StudentName1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AttendenceDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.AttendenceAtatus, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(77, 101);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(691, 35);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // StudentName1
            // 
            this.StudentName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentName1.FormattingEnabled = true;
            this.StudentName1.Location = new System.Drawing.Point(203, 7);
            this.StudentName1.Name = "StudentName1";
            this.StudentName1.Size = new System.Drawing.Size(137, 21);
            this.StudentName1.TabIndex = 26;
            this.StudentName1.Tag = "";
            this.StudentName1.SelectedIndexChanged += new System.EventHandler(this.StudentName1_SelectedIndexChanged);
            // 
            // AttendenceDate
            // 
            this.AttendenceDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttendenceDate.AutoSize = true;
            this.AttendenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendenceDate.Location = new System.Drawing.Point(92, 7);
            this.AttendenceDate.Name = "AttendenceDate";
            this.AttendenceDate.Size = new System.Drawing.Size(73, 20);
            this.AttendenceDate.TabIndex = 1;
            this.AttendenceDate.Text = "Student";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "AttendenceStatus";
            // 
            // AttendenceAtatus
            // 
            this.AttendenceAtatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendenceAtatus.FormattingEnabled = true;
            this.AttendenceAtatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "Late"});
            this.AttendenceAtatus.Location = new System.Drawing.Point(490, 7);
            this.AttendenceAtatus.Name = "AttendenceAtatus";
            this.AttendenceAtatus.Size = new System.Drawing.Size(137, 21);
            this.AttendenceAtatus.TabIndex = 3;
            this.AttendenceAtatus.SelectedIndexChanged += new System.EventHandler(this.AttendenceAtatus_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ClassAttendence, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(276, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 56);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ClassAttendence
            // 
            this.ClassAttendence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClassAttendence.AutoSize = true;
            this.ClassAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAttendence.Location = new System.Drawing.Point(14, 18);
            this.ClassAttendence.Name = "ClassAttendence";
            this.ClassAttendence.Size = new System.Drawing.Size(171, 20);
            this.ClassAttendence.TabIndex = 0;
            this.ClassAttendence.Text = "Student Attendence";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.StudentAttendenceRecord, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(74, 213);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(691, 299);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // StudentAttendenceRecord
            // 
            this.StudentAttendenceRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentAttendenceRecord.AutoGenerateColumns = false;
            this.StudentAttendenceRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentAttendenceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentAttendenceRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceId1DataGridViewTextBoxColumn,
            this.studentId1DataGridViewTextBoxColumn,
            this.attendanceStatus1DataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.StudentAttendenceRecord.DataSource = this.studentAttendenceClassBindingSource;
            this.StudentAttendenceRecord.Location = new System.Drawing.Point(3, 3);
            this.StudentAttendenceRecord.Name = "StudentAttendenceRecord";
            this.StudentAttendenceRecord.Size = new System.Drawing.Size(685, 293);
            this.StudentAttendenceRecord.TabIndex = 0;
            this.StudentAttendenceRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentAttendenceRecord_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "AttendanceId1";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "AttendanceId1";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Home
            // 
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.LinkColor = System.Drawing.Color.MidnightBlue;
            this.Home.Location = new System.Drawing.Point(571, 11);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(80, 16);
            this.Home.TabIndex = 23;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Home_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 83);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // attendanceId1DataGridViewTextBoxColumn
            // 
            this.attendanceId1DataGridViewTextBoxColumn.DataPropertyName = "AttendanceId1";
            this.attendanceId1DataGridViewTextBoxColumn.HeaderText = "AttendanceId";
            this.attendanceId1DataGridViewTextBoxColumn.Name = "attendanceId1DataGridViewTextBoxColumn";
            // 
            // studentId1DataGridViewTextBoxColumn
            // 
            this.studentId1DataGridViewTextBoxColumn.DataPropertyName = "StudentId1";
            this.studentId1DataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentId1DataGridViewTextBoxColumn.Name = "studentId1DataGridViewTextBoxColumn";
            // 
            // attendanceStatus1DataGridViewTextBoxColumn
            // 
            this.attendanceStatus1DataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus1";
            this.attendanceStatus1DataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatus1DataGridViewTextBoxColumn.Name = "attendanceStatus1DataGridViewTextBoxColumn";
            // 
            // studentAttendenceClassBindingSource
            // 
            this.studentAttendenceClassBindingSource.DataSource = typeof(ProjectBLab.StudentAttendenceClass);
            // 
            // StudentAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentAttendence";
            this.Text = "StudentAttendence";
            this.Load += new System.EventHandler(this.StudentAttendence_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentAttendenceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label AttendenceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ClassAttendence;
        private System.Windows.Forms.ComboBox AttendenceAtatus;
        private System.Windows.Forms.ComboBox StudentName1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView StudentAttendenceRecord;
        private System.Windows.Forms.Label ATTDate;
        private System.Windows.Forms.ComboBox AttendencedateComobox;
        private System.Windows.Forms.BindingSource studentAttendenceClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatus1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.LinkLabel Home;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}