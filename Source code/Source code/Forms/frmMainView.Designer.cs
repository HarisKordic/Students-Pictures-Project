namespace Source_code.Forms
{
    partial class frmMainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBoxStudents = new System.Windows.Forms.GroupBox();
            this.txtBoxStudentSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpBoxStudentsSubjects = new System.Windows.Forms.GroupBox();
            this.txtBoxSubjectSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudentsSubjects = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShowPictures = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveStudentToFile = new System.Windows.Forms.Button();
            this.btnSaveStudentsSubjectsToFile = new System.Windows.Forms.Button();
            this.grpBoxStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpBoxStudentsSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxStudents
            // 
            this.grpBoxStudents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxStudents.Controls.Add(this.btnSaveStudentToFile);
            this.grpBoxStudents.Controls.Add(this.txtBoxStudentSearch);
            this.grpBoxStudents.Controls.Add(this.label1);
            this.grpBoxStudents.Controls.Add(this.dgvStudents);
            this.grpBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxStudents.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudents.Name = "grpBoxStudents";
            this.grpBoxStudents.Size = new System.Drawing.Size(1370, 329);
            this.grpBoxStudents.TabIndex = 1;
            this.grpBoxStudents.TabStop = false;
            this.grpBoxStudents.Text = "Students";
            // 
            // txtBoxStudentSearch
            // 
            this.txtBoxStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxStudentSearch.Location = new System.Drawing.Point(286, 36);
            this.txtBoxStudentSearch.Multiline = true;
            this.txtBoxStudentSearch.Name = "txtBoxStudentSearch";
            this.txtBoxStudentSearch.Size = new System.Drawing.Size(341, 17);
            this.txtBoxStudentSearch.TabIndex = 4;
            this.txtBoxStudentSearch.TextChanged += new System.EventHandler(this.txtBoxStudentSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by student name ans surname:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Surname,
            this.Index,
            this.BirthDay,
            this.Gender,
            this.Semester,
            this.AcademicYear,
            this.Email,
            this.PhoneNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudents.Location = new System.Drawing.Point(6, 57);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1358, 266);
            this.dgvStudents.TabIndex = 0;
            // 
            // grpBoxStudentsSubjects
            // 
            this.grpBoxStudentsSubjects.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxStudentsSubjects.Controls.Add(this.btnSaveStudentsSubjectsToFile);
            this.grpBoxStudentsSubjects.Controls.Add(this.txtBoxSubjectSearch);
            this.grpBoxStudentsSubjects.Controls.Add(this.lblSearch);
            this.grpBoxStudentsSubjects.Controls.Add(this.dgvStudentsSubjects);
            this.grpBoxStudentsSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudentsSubjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxStudentsSubjects.Location = new System.Drawing.Point(12, 366);
            this.grpBoxStudentsSubjects.Name = "grpBoxStudentsSubjects";
            this.grpBoxStudentsSubjects.Size = new System.Drawing.Size(1370, 329);
            this.grpBoxStudentsSubjects.TabIndex = 2;
            this.grpBoxStudentsSubjects.TabStop = false;
            this.grpBoxStudentsSubjects.Text = "Students and passed subjects";
            // 
            // txtBoxSubjectSearch
            // 
            this.txtBoxSubjectSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSubjectSearch.Location = new System.Drawing.Point(186, 36);
            this.txtBoxSubjectSearch.Multiline = true;
            this.txtBoxSubjectSearch.Name = "txtBoxSubjectSearch";
            this.txtBoxSubjectSearch.Size = new System.Drawing.Size(341, 17);
            this.txtBoxSubjectSearch.TabIndex = 5;
            this.txtBoxSubjectSearch.TextChanged += new System.EventHandler(this.txtBoxSubjectSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(183, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search by subject name:";
            // 
            // dgvStudentsSubjects
            // 
            this.dgvStudentsSubjects.AllowUserToDeleteRows = false;
            this.dgvStudentsSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentsSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Subject,
            this.Grade,
            this.Date,
            this.DeleteSubject,
            this.ShowPictures});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsSubjects.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentsSubjects.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentsSubjects.Location = new System.Drawing.Point(6, 57);
            this.dgvStudentsSubjects.Name = "dgvStudentsSubjects";
            this.dgvStudentsSubjects.ReadOnly = true;
            this.dgvStudentsSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStudentsSubjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudentsSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsSubjects.Size = new System.Drawing.Size(1358, 266);
            this.dgvStudentsSubjects.TabIndex = 1;
            this.dgvStudentsSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsSubjects_CellContentClick);
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteSubject.HeaderText = "Delete subject";
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.ReadOnly = true;
            this.DeleteSubject.Text = "Delete subject";
            this.DeleteSubject.UseColumnTextForButtonValue = true;
            // 
            // ShowPictures
            // 
            this.ShowPictures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShowPictures.HeaderText = "Show pictures";
            this.ShowPictures.Name = "ShowPictures";
            this.ShowPictures.ReadOnly = true;
            this.ShowPictures.Text = "Show student\'s pictures";
            this.ShowPictures.UseColumnTextForButtonValue = true;
            // 
            // Namee
            // 
            this.Namee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Namee.DataPropertyName = "Name";
            this.Namee.HeaderText = "Name";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "DateToShow";
            this.BirthDay.HeaderText = "BirthDay";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // AcademicYear
            // 
            this.AcademicYear.DataPropertyName = "AcademicYear";
            this.AcademicYear.HeaderText = "Academic year";
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 110;
            // 
            // btnSaveStudentToFile
            // 
            this.btnSaveStudentToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveStudentToFile.FlatAppearance.BorderSize = 100;
            this.btnSaveStudentToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveStudentToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveStudentToFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveStudentToFile.Location = new System.Drawing.Point(1271, 25);
            this.btnSaveStudentToFile.Name = "btnSaveStudentToFile";
            this.btnSaveStudentToFile.Size = new System.Drawing.Size(93, 30);
            this.btnSaveStudentToFile.TabIndex = 7;
            this.btnSaveStudentToFile.Text = "Save to file";
            this.btnSaveStudentToFile.UseVisualStyleBackColor = false;
            this.btnSaveStudentToFile.Click += new System.EventHandler(this.btnSaveStudentToFile_Click);
            // 
            // btnSaveStudentsSubjectsToFile
            // 
            this.btnSaveStudentsSubjectsToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveStudentsSubjectsToFile.FlatAppearance.BorderSize = 100;
            this.btnSaveStudentsSubjectsToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveStudentsSubjectsToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveStudentsSubjectsToFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveStudentsSubjectsToFile.Location = new System.Drawing.Point(1271, 25);
            this.btnSaveStudentsSubjectsToFile.Name = "btnSaveStudentsSubjectsToFile";
            this.btnSaveStudentsSubjectsToFile.Size = new System.Drawing.Size(93, 30);
            this.btnSaveStudentsSubjectsToFile.TabIndex = 8;
            this.btnSaveStudentsSubjectsToFile.Text = "Save to file";
            this.btnSaveStudentsSubjectsToFile.UseVisualStyleBackColor = false;
            this.btnSaveStudentsSubjectsToFile.Click += new System.EventHandler(this.btnSaveStudentsSubjectsToFile_Click);
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 707);
            this.Controls.Add(this.grpBoxStudentsSubjects);
            this.Controls.Add(this.grpBoxStudents);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main view ";
            this.Load += new System.EventHandler(this.frmMainView_Load);
            this.grpBoxStudents.ResumeLayout(false);
            this.grpBoxStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpBoxStudentsSubjects.ResumeLayout(false);
            this.grpBoxStudentsSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpBoxStudentsSubjects;
        private System.Windows.Forms.DataGridView dgvStudentsSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSubject;
        private System.Windows.Forms.DataGridViewButtonColumn ShowPictures;
        private System.Windows.Forms.TextBox txtBoxStudentSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSubjectSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button btnSaveStudentToFile;
        private System.Windows.Forms.Button btnSaveStudentsSubjectsToFile;
    }
}