namespace SchoolsDatabase
{
    partial class frmView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.btnSDCancel = new System.Windows.Forms.Button();
            this.btnSDSave = new System.Windows.Forms.Button();
            this.btnEditS = new System.Windows.Forms.Button();
            this.lblSTitle = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.txtDateRegistered = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.pnlStudentClasses = new System.Windows.Forms.Panel();
            this.lblSC = new System.Windows.Forms.Label();
            this.lvStudentClasses = new System.Windows.Forms.ListView();
            this.className = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.professor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlStudents.SuspendLayout();
            this.pnlStudentClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(339, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(555, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Information Management System for Schools";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(463, 73);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(0, 13);
            this.lblAbout.TabIndex = 1;
            // 
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.SystemColors.Control;
            this.pnlStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudents.Controls.Add(this.btnSDCancel);
            this.pnlStudents.Controls.Add(this.btnSDSave);
            this.pnlStudents.Controls.Add(this.btnEditS);
            this.pnlStudents.Controls.Add(this.lblSTitle);
            this.pnlStudents.Controls.Add(this.btnPrevious);
            this.pnlStudents.Controls.Add(this.btnNext);
            this.pnlStudents.Controls.Add(this.txtEmail);
            this.pnlStudents.Controls.Add(this.lblEmail);
            this.pnlStudents.Controls.Add(this.txtTelNumber);
            this.pnlStudents.Controls.Add(this.lblFirstName);
            this.pnlStudents.Controls.Add(this.txtCourse);
            this.pnlStudents.Controls.Add(this.lblTelNumber);
            this.pnlStudents.Controls.Add(this.txtDateRegistered);
            this.pnlStudents.Controls.Add(this.lblStudentId);
            this.pnlStudents.Controls.Add(this.txtSecondName);
            this.pnlStudents.Controls.Add(this.lblCourse);
            this.pnlStudents.Controls.Add(this.txtFirstName);
            this.pnlStudents.Controls.Add(this.lblSecondName);
            this.pnlStudents.Controls.Add(this.txtStudentID);
            this.pnlStudents.Controls.Add(this.lblDateRegistered);
            this.pnlStudents.Location = new System.Drawing.Point(82, 90);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(337, 462);
            this.pnlStudents.TabIndex = 2;
            this.pnlStudents.Tag = "";
            // 
            // btnSDCancel
            // 
            this.btnSDCancel.Location = new System.Drawing.Point(238, 400);
            this.btnSDCancel.Name = "btnSDCancel";
            this.btnSDCancel.Size = new System.Drawing.Size(78, 28);
            this.btnSDCancel.TabIndex = 13;
            this.btnSDCancel.Text = "Cancel";
            this.btnSDCancel.UseVisualStyleBackColor = true;
            this.btnSDCancel.Visible = false;
            this.btnSDCancel.Click += new System.EventHandler(this.btnSDCancel_Click);
            // 
            // btnSDSave
            // 
            this.btnSDSave.Location = new System.Drawing.Point(131, 400);
            this.btnSDSave.Name = "btnSDSave";
            this.btnSDSave.Size = new System.Drawing.Size(90, 28);
            this.btnSDSave.TabIndex = 12;
            this.btnSDSave.Text = "Save Changes";
            this.btnSDSave.UseVisualStyleBackColor = true;
            this.btnSDSave.Visible = false;
            this.btnSDSave.Click += new System.EventHandler(this.btnSDSave_Click);
            // 
            // btnEditS
            // 
            this.btnEditS.Location = new System.Drawing.Point(14, 400);
            this.btnEditS.Name = "btnEditS";
            this.btnEditS.Size = new System.Drawing.Size(96, 29);
            this.btnEditS.TabIndex = 4;
            this.btnEditS.Text = "Edit Record";
            this.btnEditS.UseVisualStyleBackColor = true;
            this.btnEditS.Click += new System.EventHandler(this.btnEditS_Click);
            // 
            // lblSTitle
            // 
            this.lblSTitle.AutoSize = true;
            this.lblSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTitle.Location = new System.Drawing.Point(109, 13);
            this.lblSTitle.Name = "lblSTitle";
            this.lblSTitle.Size = new System.Drawing.Size(122, 18);
            this.lblSTitle.TabIndex = 11;
            this.lblSTitle.Text = "Student Details";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(47, 347);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(96, 29);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(189, 347);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 29);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 298);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(143, 251);
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.ReadOnly = true;
            this.txtTelNumber.Size = new System.Drawing.Size(173, 20);
            this.txtTelNumber.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 101);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(143, 213);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(173, 20);
            this.txtCourse.TabIndex = 7;
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(23, 258);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(101, 13);
            this.lblTelNumber.TabIndex = 6;
            this.lblTelNumber.Text = "Telephone Number:";
            // 
            // txtDateRegistered
            // 
            this.txtDateRegistered.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDateRegistered.Location = new System.Drawing.Point(143, 177);
            this.txtDateRegistered.MaxLength = 10;
            this.txtDateRegistered.Name = "txtDateRegistered";
            this.txtDateRegistered.ReadOnly = true;
            this.txtDateRegistered.Size = new System.Drawing.Size(173, 20);
            this.txtDateRegistered.TabIndex = 6;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(23, 64);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(58, 13);
            this.lblStudentId.TabIndex = 3;
            this.lblStudentId.Text = "Student ID";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(143, 138);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.ReadOnly = true;
            this.txtSecondName.Size = new System.Drawing.Size(173, 20);
            this.txtSecondName.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(23, 220);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "Course:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(145, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(171, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(23, 141);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(78, 13);
            this.lblSecondName.TabIndex = 3;
            this.lblSecondName.Text = "Second Name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(145, 57);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(110, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(23, 180);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(87, 13);
            this.lblDateRegistered.TabIndex = 4;
            this.lblDateRegistered.Text = "Date Registered:";
            // 
            // pnlStudentClasses
            // 
            this.pnlStudentClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentClasses.Controls.Add(this.lblSC);
            this.pnlStudentClasses.Controls.Add(this.lvStudentClasses);
            this.pnlStudentClasses.Location = new System.Drawing.Point(525, 90);
            this.pnlStudentClasses.Name = "pnlStudentClasses";
            this.pnlStudentClasses.Size = new System.Drawing.Size(548, 228);
            this.pnlStudentClasses.TabIndex = 3;
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(203, 13);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(131, 18);
            this.lblSC.TabIndex = 1;
            this.lblSC.Text = "Student Classes";
            // 
            // lvStudentClasses
            // 
            this.lvStudentClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.className,
            this.professor,
            this.roomNo});
            this.lvStudentClasses.Location = new System.Drawing.Point(33, 42);
            this.lvStudentClasses.Name = "lvStudentClasses";
            this.lvStudentClasses.Size = new System.Drawing.Size(482, 171);
            this.lvStudentClasses.TabIndex = 0;
            this.lvStudentClasses.UseCompatibleStateImageBehavior = false;
            this.lvStudentClasses.View = System.Windows.Forms.View.Details;
            // 
            // className
            // 
            this.className.Tag = "";
            this.className.Text = "Class Name";
            this.className.Width = 230;
            // 
            // professor
            // 
            this.professor.Text = "Professor";
            this.professor.Width = 150;
            // 
            // roomNo
            // 
            this.roomNo.Text = "Room Number";
            this.roomNo.Width = 100;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 626);
            this.Controls.Add(this.pnlStudentClasses);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlStudentClasses.ResumeLayout(false);
            this.pnlStudentClasses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtDateRegistered;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSTitle;
        private System.Windows.Forms.Panel pnlStudentClasses;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.ListView lvStudentClasses;
        private System.Windows.Forms.ColumnHeader className;
        private System.Windows.Forms.ColumnHeader professor;
        private System.Windows.Forms.ColumnHeader roomNo;
        private System.Windows.Forms.Button btnEditS;
        private System.Windows.Forms.Button btnSDCancel;
        private System.Windows.Forms.Button btnSDSave;
    }
}

