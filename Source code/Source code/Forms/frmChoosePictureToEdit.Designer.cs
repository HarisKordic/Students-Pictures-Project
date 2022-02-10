namespace Source_code.Forms
{
    partial class frmChoosePictureToEdit
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
            this.grpBoxStudents = new System.Windows.Forms.GroupBox();
            this.btnSaveStudentToFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudentsPictures = new System.Windows.Forms.DataGridView();
            this.Ssudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpBoxStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxStudents
            // 
            this.grpBoxStudents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxStudents.Controls.Add(this.dgvStudentsPictures);
            this.grpBoxStudents.Controls.Add(this.btnSaveStudentToFile);
            this.grpBoxStudents.Controls.Add(this.label1);
            this.grpBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxStudents.Location = new System.Drawing.Point(-2, 12);
            this.grpBoxStudents.Name = "grpBoxStudents";
            this.grpBoxStudents.Size = new System.Drawing.Size(695, 271);
            this.grpBoxStudents.TabIndex = 2;
            this.grpBoxStudents.TabStop = false;
            this.grpBoxStudents.Text = "Students pictures";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double click on a column to select the record you want to edit.";
            // 
            // dgvStudentsPictures
            // 
            this.dgvStudentsPictures.AllowUserToDeleteRows = false;
            this.dgvStudentsPictures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsPictures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentsPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsPictures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ssudent,
            this.Picture,
            this.Description,
            this.Date,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsPictures.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentsPictures.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentsPictures.Location = new System.Drawing.Point(10, 59);
            this.dgvStudentsPictures.Name = "dgvStudentsPictures";
            this.dgvStudentsPictures.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsPictures.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvStudentsPictures.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentsPictures.RowTemplate.Height = 35;
            this.dgvStudentsPictures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudentsPictures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentsPictures.Size = new System.Drawing.Size(679, 206);
            this.dgvStudentsPictures.TabIndex = 8;
            this.dgvStudentsPictures.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsPictures_CellClick);
            // 
            // Ssudent
            // 
            this.Ssudent.DataPropertyName = "Student";
            this.Ssudent.HeaderText = "Student";
            this.Ssudent.Name = "Ssudent";
            // 
            // Picture
            // 
            this.Picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete ";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmChoosePictureToEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 291);
            this.Controls.Add(this.grpBoxStudents);
            this.IsMdiContainer = true;
            this.Name = "frmChoosePictureToEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChoosePictureToEdit";
            this.Load += new System.EventHandler(this.frmChoosePictureToEdit_Load);
            this.grpBoxStudents.ResumeLayout(false);
            this.grpBoxStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudents;
        private System.Windows.Forms.Button btnSaveStudentToFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudentsPictures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ssudent;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}