namespace ProjectBLab
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.StuManagement = new System.Windows.Forms.LinkLabel();
            this.StuResultManagement = new System.Windows.Forms.LinkLabel();
            this.CloManagement = new System.Windows.Forms.LinkLabel();
            this.ASSMAnagement = new System.Windows.Forms.LinkLabel();
            this.RubManagement = new System.Windows.Forms.LinkLabel();
            this.AssComManage = new System.Windows.Forms.LinkLabel();
            this.RLManagement = new System.Windows.Forms.LinkLabel();
            this.Attendene = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(65, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64029F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35971F));
            this.tableLayoutPanel2.Controls.Add(this.Attendene, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.RLManagement, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AssComManage, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.RubManagement, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ASSMAnagement, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CloManagement, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.StuResultManagement, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.StuManagement, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 152);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(556, 168);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management system";
            // 
            // StuManagement
            // 
            this.StuManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StuManagement.AutoSize = true;
            this.StuManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuManagement.Location = new System.Drawing.Point(3, 13);
            this.StuManagement.Name = "StuManagement";
            this.StuManagement.Size = new System.Drawing.Size(270, 16);
            this.StuManagement.TabIndex = 0;
            this.StuManagement.TabStop = true;
            this.StuManagement.Text = "Student Management";
            this.StuManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StuManagement_LinkClicked);
            // 
            // StuResultManagement
            // 
            this.StuResultManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StuResultManagement.AutoSize = true;
            this.StuResultManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuResultManagement.Location = new System.Drawing.Point(279, 13);
            this.StuResultManagement.Name = "StuResultManagement";
            this.StuResultManagement.Size = new System.Drawing.Size(274, 16);
            this.StuResultManagement.TabIndex = 1;
            this.StuResultManagement.TabStop = true;
            this.StuResultManagement.Text = "Student  Result  Management";
            this.StuResultManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StuResultManagement_LinkClicked);
            // 
            // CloManagement
            // 
            this.CloManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CloManagement.AutoSize = true;
            this.CloManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloManagement.Location = new System.Drawing.Point(3, 55);
            this.CloManagement.Name = "CloManagement";
            this.CloManagement.Size = new System.Drawing.Size(270, 16);
            this.CloManagement.TabIndex = 2;
            this.CloManagement.TabStop = true;
            this.CloManagement.Text = "Clo Management";
            this.CloManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloManagement_LinkClicked);
            // 
            // ASSMAnagement
            // 
            this.ASSMAnagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ASSMAnagement.AutoSize = true;
            this.ASSMAnagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASSMAnagement.Location = new System.Drawing.Point(279, 55);
            this.ASSMAnagement.Name = "ASSMAnagement";
            this.ASSMAnagement.Size = new System.Drawing.Size(274, 16);
            this.ASSMAnagement.TabIndex = 3;
            this.ASSMAnagement.TabStop = true;
            this.ASSMAnagement.Text = "Assessment Management";
            this.ASSMAnagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ASSMAnagement_LinkClicked);
            // 
            // RubManagement
            // 
            this.RubManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RubManagement.AutoSize = true;
            this.RubManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RubManagement.Location = new System.Drawing.Point(3, 97);
            this.RubManagement.Name = "RubManagement";
            this.RubManagement.Size = new System.Drawing.Size(270, 16);
            this.RubManagement.TabIndex = 4;
            this.RubManagement.TabStop = true;
            this.RubManagement.Text = "Rubric Management";
            this.RubManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RubManagement_LinkClicked);
            // 
            // AssComManage
            // 
            this.AssComManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AssComManage.AutoSize = true;
            this.AssComManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssComManage.Location = new System.Drawing.Point(279, 97);
            this.AssComManage.Name = "AssComManage";
            this.AssComManage.Size = new System.Drawing.Size(274, 16);
            this.AssComManage.TabIndex = 5;
            this.AssComManage.TabStop = true;
            this.AssComManage.Text = "Assessment Component Management";
            this.AssComManage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AssComManage_LinkClicked);
            // 
            // RLManagement
            // 
            this.RLManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RLManagement.AutoSize = true;
            this.RLManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLManagement.Location = new System.Drawing.Point(3, 139);
            this.RLManagement.Name = "RLManagement";
            this.RLManagement.Size = new System.Drawing.Size(270, 16);
            this.RLManagement.TabIndex = 6;
            this.RLManagement.TabStop = true;
            this.RLManagement.Text = "Rubric Level Management";
            this.RLManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RLManagement_LinkClicked);
            // 
            // Attendene
            // 
            this.Attendene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Attendene.AutoSize = true;
            this.Attendene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendene.Location = new System.Drawing.Point(279, 139);
            this.Attendene.Name = "Attendene";
            this.Attendene.Size = new System.Drawing.Size(274, 16);
            this.Attendene.TabIndex = 7;
            this.Attendene.TabStop = true;
            this.Attendene.Text = "Attendence Management";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 488);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home";
            this.Text = "Home";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel Attendene;
        private System.Windows.Forms.LinkLabel RLManagement;
        private System.Windows.Forms.LinkLabel AssComManage;
        private System.Windows.Forms.LinkLabel RubManagement;
        private System.Windows.Forms.LinkLabel ASSMAnagement;
        private System.Windows.Forms.LinkLabel CloManagement;
        private System.Windows.Forms.LinkLabel StuResultManagement;
        private System.Windows.Forms.LinkLabel StuManagement;
    }
}