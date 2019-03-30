namespace ProjectBLab
{
    partial class Attendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClassAttendence = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AttendenceDatepicker = new System.Windows.Forms.DateTimePicker();
            this.AttendenceDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ClassAttendenceRecord = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Save = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentAttendence = new System.Windows.Forms.LinkLabel();
            this.id1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendenceDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classAttendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassAttendenceRecord)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ClassAttendence, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(146, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClassAttendence
            // 
            this.ClassAttendence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClassAttendence.AutoSize = true;
            this.ClassAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassAttendence.Location = new System.Drawing.Point(14, 15);
            this.ClassAttendence.Name = "ClassAttendence";
            this.ClassAttendence.Size = new System.Drawing.Size(197, 25);
            this.ClassAttendence.TabIndex = 0;
            this.ClassAttendence.Text = "Class Attendence";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.58392F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.18913F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.06147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.929078F));
            this.tableLayoutPanel2.Controls.Add(this.AttendenceDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AttendenceDatepicker, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(56, 149);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(423, 35);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AttendenceDatepicker
            // 
            this.AttendenceDatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendenceDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AttendenceDatepicker.Location = new System.Drawing.Point(222, 7);
            this.AttendenceDatepicker.Name = "AttendenceDatepicker";
            this.AttendenceDatepicker.Size = new System.Drawing.Size(155, 20);
            this.AttendenceDatepicker.TabIndex = 20;
            this.AttendenceDatepicker.ValueChanged += new System.EventHandler(this.AttendenceDatepicker_ValueChanged);
            // 
            // AttendenceDate
            // 
            this.AttendenceDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttendenceDate.AutoSize = true;
            this.AttendenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendenceDate.Location = new System.Drawing.Point(63, 7);
            this.AttendenceDate.Name = "AttendenceDate";
            this.AttendenceDate.Size = new System.Drawing.Size(141, 20);
            this.AttendenceDate.TabIndex = 1;
            this.AttendenceDate.Text = "AttendenceDate";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ClassAttendenceRecord, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(56, 249);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(681, 290);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ClassAttendenceRecord
            // 
            this.ClassAttendenceRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassAttendenceRecord.AutoGenerateColumns = false;
            this.ClassAttendenceRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassAttendenceRecord.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.ClassAttendenceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassAttendenceRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1DataGridViewTextBoxColumn,
            this.attendenceDate1DataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.ClassAttendenceRecord.DataSource = this.classAttendenceBindingSource;
            this.ClassAttendenceRecord.Location = new System.Drawing.Point(3, 3);
            this.ClassAttendenceRecord.Name = "ClassAttendenceRecord";
            this.ClassAttendenceRecord.Size = new System.Drawing.Size(675, 284);
            this.ClassAttendenceRecord.TabIndex = 0;
            this.ClassAttendenceRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassAttendenceRecord_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Controls.Add(this.Save, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.ADD, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Home, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.StudentAttendence, 5, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(56, 204);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(678, 39);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(229, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(107, 33);
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
            this.ADD.Location = new System.Drawing.Point(116, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(107, 33);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Home
            // 
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.LinkColor = System.Drawing.Color.MidnightBlue;
            this.Home.Location = new System.Drawing.Point(455, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(107, 29);
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
            this.pictureBox1.Location = new System.Drawing.Point(507, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 202);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StudentAttendence
            // 
            this.StudentAttendence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentAttendence.AutoSize = true;
            this.StudentAttendence.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StudentAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAttendence.LinkColor = System.Drawing.Color.MidnightBlue;
            this.StudentAttendence.Location = new System.Drawing.Point(568, 3);
            this.StudentAttendence.Name = "StudentAttendence";
            this.StudentAttendence.Size = new System.Drawing.Size(107, 32);
            this.StudentAttendence.TabIndex = 24;
            this.StudentAttendence.TabStop = true;
            this.StudentAttendence.Text = "StudentAttendence";
            this.StudentAttendence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StudentAttendence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentAttendence_LinkClicked);
            // 
            // id1DataGridViewTextBoxColumn
            // 
            this.id1DataGridViewTextBoxColumn.DataPropertyName = "Id1";
            this.id1DataGridViewTextBoxColumn.HeaderText = "Id";
            this.id1DataGridViewTextBoxColumn.Name = "id1DataGridViewTextBoxColumn";
            // 
            // attendenceDate1DataGridViewTextBoxColumn
            // 
            this.attendenceDate1DataGridViewTextBoxColumn.DataPropertyName = "AttendenceDate1";
            this.attendenceDate1DataGridViewTextBoxColumn.HeaderText = "AttendenceDate";
            this.attendenceDate1DataGridViewTextBoxColumn.Name = "attendenceDate1DataGridViewTextBoxColumn";
            // 
            // classAttendenceBindingSource
            // 
            this.classAttendenceBindingSource.DataSource = typeof(ProjectBLab.ClassAttendence);
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(789, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Attendence";
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendence_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassAttendenceRecord)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendenceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ClassAttendence;
        private System.Windows.Forms.Label AttendenceDate;
        private System.Windows.Forms.DataGridView ClassAttendenceRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.BindingSource classAttendenceBindingSource;
        private System.Windows.Forms.DateTimePicker AttendenceDatepicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendenceDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.LinkLabel Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel StudentAttendence;
    }
}