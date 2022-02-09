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
            this.grpBoxStudents = new System.Windows.Forms.GroupBox();
            this.grpBoxStudentsSubjects = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBoxStudents.SuspendLayout();
            this.grpBoxStudentsSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.grpBoxStudentsSubjects.Controls.Add(this.dataGridView1);
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
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudents.Location = new System.Drawing.Point(6, 25);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1358, 266);
            this.dgvStudents.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 266);
            this.dataGridView1.TabIndex = 1;
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
            this.grpBoxStudents.ResumeLayout(false);
            this.grpBoxStudentsSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpBoxStudentsSubjects;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}