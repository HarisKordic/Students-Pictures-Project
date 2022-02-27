namespace Source_code.Forms
{
    partial class frmEditStudent
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
            this.grpBoxStudents = new System.Windows.Forms.GroupBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBoxAcademicYear = new System.Windows.Forms.TextBox();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBoxStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxStudents
            // 
            this.grpBoxStudents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxStudents.Controls.Add(this.txtBoxPhoneNumber);
            this.grpBoxStudents.Controls.Add(this.lblPhone);
            this.grpBoxStudents.Controls.Add(this.txtBoxAcademicYear);
            this.grpBoxStudents.Controls.Add(this.lblAcademicYear);
            this.grpBoxStudents.Controls.Add(this.cmbGender);
            this.grpBoxStudents.Controls.Add(this.lblGender);
            this.grpBoxStudents.Controls.Add(this.dtpBirthday);
            this.grpBoxStudents.Controls.Add(this.lblBirthDay);
            this.grpBoxStudents.Controls.Add(this.cmbSemester);
            this.grpBoxStudents.Controls.Add(this.lblSemester);
            this.grpBoxStudents.Controls.Add(this.txtBoxSurname);
            this.grpBoxStudents.Controls.Add(this.lblSurname);
            this.grpBoxStudents.Controls.Add(this.btnSaveStudent);
            this.grpBoxStudents.Controls.Add(this.txtBoxName);
            this.grpBoxStudents.Controls.Add(this.lblName);
            this.grpBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxStudents.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudents.Name = "grpBoxStudents";
            this.grpBoxStudents.Size = new System.Drawing.Size(385, 276);
            this.grpBoxStudents.TabIndex = 1;
            this.grpBoxStudents.TabStop = false;
            this.grpBoxStudents.Text = "Edit student:";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(141, 206);
            this.txtBoxPhoneNumber.Multiline = true;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(223, 19);
            this.txtBoxPhoneNumber.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 204);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(117, 20);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone number:";
            // 
            // txtBoxAcademicYear
            // 
            this.txtBoxAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxAcademicYear.Location = new System.Drawing.Point(141, 182);
            this.txtBoxAcademicYear.Multiline = true;
            this.txtBoxAcademicYear.Name = "txtBoxAcademicYear";
            this.txtBoxAcademicYear.Size = new System.Drawing.Size(223, 19);
            this.txtBoxAcademicYear.TabIndex = 5;
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Location = new System.Drawing.Point(18, 180);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(117, 20);
            this.lblAcademicYear.TabIndex = 16;
            this.lblAcademicYear.Text = "Academic year:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(105, 155);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(90, 21);
            this.cmbGender.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(18, 155);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpBirthday.Location = new System.Drawing.Point(105, 126);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(259, 21);
            this.dtpBirthday.TabIndex = 3;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(18, 126);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(71, 20);
            this.lblBirthDay.TabIndex = 12;
            this.lblBirthDay.Text = "Birthday:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(105, 99);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(90, 21);
            this.cmbSemester.TabIndex = 2;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(18, 99);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(82, 20);
            this.lblSemester.TabIndex = 10;
            this.lblSemester.Text = "Semester:";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSurname.Location = new System.Drawing.Point(105, 77);
            this.txtBoxSurname.Multiline = true;
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(259, 19);
            this.txtBoxSurname.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 75);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname:";
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveStudent.FlatAppearance.BorderSize = 100;
            this.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveStudent.Location = new System.Drawing.Point(300, 231);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(64, 30);
            this.btnSaveStudent.TabIndex = 7;
            this.btnSaveStudent.Text = "Edit";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxName.Location = new System.Drawing.Point(105, 52);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(259, 19);
            this.txtBoxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name: ";
            // 
            // frmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 293);
            this.Controls.Add(this.grpBoxStudents);
            this.IsMdiContainer = true;
            this.Name = "frmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit student";
            this.grpBoxStudents.ResumeLayout(false);
            this.grpBoxStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudents;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBoxAcademicYear;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
    }
}