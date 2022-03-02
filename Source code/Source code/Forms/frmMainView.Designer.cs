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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBoxStudents = new System.Windows.Forms.GroupBox();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.btnSaveStudentToFile = new System.Windows.Forms.Button();
            this.txtBoxStudentSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShowPictures = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpBoxStudentsSubjects = new System.Windows.Forms.GroupBox();
            this.btnAddSubjectToStudent = new System.Windows.Forms.Button();
            this.btnSaveStudentsSubjectsToFile = new System.Windows.Forms.Button();
            this.txtBoxSubjectSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvStudentsSubjects = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.grpBoxStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpBoxStudentsSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxStudents
            // 
            this.grpBoxStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxStudents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxStudents.Controls.Add(this.btnAddStudents);
            this.grpBoxStudents.Controls.Add(this.btnSaveStudentToFile);
            this.grpBoxStudents.Controls.Add(this.txtBoxStudentSearch);
            this.grpBoxStudents.Controls.Add(this.label1);
            this.grpBoxStudents.Controls.Add(this.dgvStudents);
            this.grpBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxStudents.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudents.Name = "grpBoxStudents";
            this.grpBoxStudents.Size = new System.Drawing.Size(1741, 329);
            this.grpBoxStudents.TabIndex = 1;
            this.grpBoxStudents.TabStop = false;
            this.grpBoxStudents.Text = "Students";
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddStudents.FlatAppearance.BorderSize = 100;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddStudents.Location = new System.Drawing.Point(1499, 25);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(137, 30);
            this.btnAddStudents.TabIndex = 8;
            this.btnAddStudents.Text = "Add new student";
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // btnSaveStudentToFile
            // 
            this.btnSaveStudentToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStudentToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveStudentToFile.FlatAppearance.BorderSize = 100;
            this.btnSaveStudentToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveStudentToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveStudentToFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveStudentToFile.Location = new System.Drawing.Point(1642, 25);
            this.btnSaveStudentToFile.Name = "btnSaveStudentToFile";
            this.btnSaveStudentToFile.Size = new System.Drawing.Size(93, 30);
            this.btnSaveStudentToFile.TabIndex = 7;
            this.btnSaveStudentToFile.Text = "Save to file";
            this.btnSaveStudentToFile.UseVisualStyleBackColor = false;
            this.btnSaveStudentToFile.Click += new System.EventHandler(this.btnSaveStudentToFile_Click);
            // 
            // txtBoxStudentSearch
            // 
            this.txtBoxStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxStudentSearch.Location = new System.Drawing.Point(286, 34);
            this.txtBoxStudentSearch.Multiline = true;
            this.txtBoxStudentSearch.Name = "txtBoxStudentSearch";
            this.txtBoxStudentSearch.Size = new System.Drawing.Size(725, 19);
            this.txtBoxStudentSearch.TabIndex = 4;
            this.txtBoxStudentSearch.TextChanged += new System.EventHandler(this.txtBoxStudentSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by student name and surname:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
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
            this.PhoneNumber,
            this.Delete,
            this.ShowPictures});
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle58;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudents.Location = new System.Drawing.Point(6, 57);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1729, 266);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // Namee
            // 
            this.Namee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Namee.DataPropertyName = "Name";
            this.Namee.HeaderText = "Name";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            this.Namee.Width = 235;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 235;
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
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete student";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 200;
            // 
            // ShowPictures
            // 
            this.ShowPictures.HeaderText = "Show pictures";
            this.ShowPictures.Name = "ShowPictures";
            this.ShowPictures.ReadOnly = true;
            this.ShowPictures.Text = "Show students pictures";
            this.ShowPictures.UseColumnTextForButtonValue = true;
            this.ShowPictures.Width = 200;
            // 
            // grpBoxStudentsSubjects
            // 
            this.grpBoxStudentsSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxStudentsSubjects.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxStudentsSubjects.Controls.Add(this.btnAddSubjectToStudent);
            this.grpBoxStudentsSubjects.Controls.Add(this.btnSaveStudentsSubjectsToFile);
            this.grpBoxStudentsSubjects.Controls.Add(this.txtBoxSubjectSearch);
            this.grpBoxStudentsSubjects.Controls.Add(this.lblSearch);
            this.grpBoxStudentsSubjects.Controls.Add(this.dgvStudentsSubjects);
            this.grpBoxStudentsSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudentsSubjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxStudentsSubjects.Location = new System.Drawing.Point(12, 366);
            this.grpBoxStudentsSubjects.Name = "grpBoxStudentsSubjects";
            this.grpBoxStudentsSubjects.Size = new System.Drawing.Size(1741, 329);
            this.grpBoxStudentsSubjects.TabIndex = 2;
            this.grpBoxStudentsSubjects.TabStop = false;
            this.grpBoxStudentsSubjects.Text = "Students and passed subjects";
            // 
            // btnAddSubjectToStudent
            // 
            this.btnAddSubjectToStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubjectToStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddSubjectToStudent.FlatAppearance.BorderSize = 100;
            this.btnAddSubjectToStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSubjectToStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddSubjectToStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSubjectToStudent.Location = new System.Drawing.Point(1472, 25);
            this.btnAddSubjectToStudent.Name = "btnAddSubjectToStudent";
            this.btnAddSubjectToStudent.Size = new System.Drawing.Size(164, 30);
            this.btnAddSubjectToStudent.TabIndex = 9;
            this.btnAddSubjectToStudent.Text = "Add subject to student";
            this.btnAddSubjectToStudent.UseVisualStyleBackColor = false;
            this.btnAddSubjectToStudent.Click += new System.EventHandler(this.btnAddSubjectToStudent_Click);
            // 
            // btnSaveStudentsSubjectsToFile
            // 
            this.btnSaveStudentsSubjectsToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStudentsSubjectsToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveStudentsSubjectsToFile.FlatAppearance.BorderSize = 100;
            this.btnSaveStudentsSubjectsToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveStudentsSubjectsToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveStudentsSubjectsToFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveStudentsSubjectsToFile.Location = new System.Drawing.Point(1642, 25);
            this.btnSaveStudentsSubjectsToFile.Name = "btnSaveStudentsSubjectsToFile";
            this.btnSaveStudentsSubjectsToFile.Size = new System.Drawing.Size(93, 30);
            this.btnSaveStudentsSubjectsToFile.TabIndex = 8;
            this.btnSaveStudentsSubjectsToFile.Text = "Save to file";
            this.btnSaveStudentsSubjectsToFile.UseVisualStyleBackColor = false;
            this.btnSaveStudentsSubjectsToFile.Click += new System.EventHandler(this.btnSaveStudentsSubjectsToFile_Click);
            // 
            // txtBoxSubjectSearch
            // 
            this.txtBoxSubjectSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSubjectSearch.Location = new System.Drawing.Point(186, 34);
            this.txtBoxSubjectSearch.Multiline = true;
            this.txtBoxSubjectSearch.Name = "txtBoxSubjectSearch";
            this.txtBoxSubjectSearch.Size = new System.Drawing.Size(825, 19);
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
            this.dgvStudentsSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentsSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvStudentsSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Subject,
            this.Grade,
            this.Date,
            this.DeleteSubject});
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsSubjects.DefaultCellStyle = dataGridViewCellStyle62;
            this.dgvStudentsSubjects.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentsSubjects.Location = new System.Drawing.Point(6, 57);
            this.dgvStudentsSubjects.Name = "dgvStudentsSubjects";
            this.dgvStudentsSubjects.ReadOnly = true;
            this.dgvStudentsSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvStudentsSubjects.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvStudentsSubjects.RowTemplate.Height = 35;
            this.dgvStudentsSubjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudentsSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsSubjects.Size = new System.Drawing.Size(1729, 266);
            this.dgvStudentsSubjects.TabIndex = 1;
            this.dgvStudentsSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsSubjects_CellClick);
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
            this.Date.DataPropertyName = "DateToShow";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 318;
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.HeaderText = "Delete subject";
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.ReadOnly = true;
            this.DeleteSubject.Text = "Delete subject";
            this.DeleteSubject.UseColumnTextForButtonValue = true;
            this.DeleteSubject.Width = 150;
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 707);
            this.Controls.Add(this.grpBoxStudentsSubjects);
            this.Controls.Add(this.grpBoxStudents);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.TextBox txtBoxStudentSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSubjectSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSaveStudentToFile;
        private System.Windows.Forms.Button btnSaveStudentsSubjectsToFile;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Button btnAddSubjectToStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn ShowPictures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSubject;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}