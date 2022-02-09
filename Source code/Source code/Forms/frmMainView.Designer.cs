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
            this.grpBoxStudents = new System.Windows.Forms.GroupBox();
            this.grpBoxStudentsSubjects = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvStudentsSubjects = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxStudents.SuspendLayout();
            this.grpBoxStudentsSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxStudents
            // 
            this.grpBoxStudents.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            // grpBoxStudentsSubjects
            // 
            this.grpBoxStudentsSubjects.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudents.Location = new System.Drawing.Point(6, 25);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1358, 266);
            this.dgvStudents.TabIndex = 0;
            // 
            // dgvStudentsSubjects
            // 
            this.dgvStudentsSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStudentsSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsSubjects.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentsSubjects.Location = new System.Drawing.Point(6, 25);
            this.dgvStudentsSubjects.Name = "dgvStudentsSubjects";
            this.dgvStudentsSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudentsSubjects.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvStudentsSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsSubjects.Size = new System.Drawing.Size(1358, 266);
            this.dgvStudentsSubjects.TabIndex = 1;
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
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
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
            this.grpBoxStudentsSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpBoxStudentsSubjects;
        private System.Windows.Forms.DataGridView dgvStudentsSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}