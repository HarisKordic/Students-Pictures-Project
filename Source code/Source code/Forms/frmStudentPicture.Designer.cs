namespace Source_code.Forms
{
    partial class frmStudentPicture
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
            this.grpBoxAddNewPicture = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.lblAddPic = new System.Windows.Forms.Label();
            this.AddPicture = new System.Windows.Forms.PictureBox();
            this.opfFindPicture = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxAddNewPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxAddNewPicture
            // 
            this.grpBoxAddNewPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxAddNewPicture.Controls.Add(this.AddPicture);
            this.grpBoxAddNewPicture.Controls.Add(this.lblAddPic);
            this.grpBoxAddNewPicture.Controls.Add(this.btnSavePicture);
            this.grpBoxAddNewPicture.Controls.Add(this.txtBoxDescription);
            this.grpBoxAddNewPicture.Controls.Add(this.lblDescription);
            this.grpBoxAddNewPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxAddNewPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxAddNewPicture.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAddNewPicture.Name = "grpBoxAddNewPicture";
            this.grpBoxAddNewPicture.Size = new System.Drawing.Size(590, 576);
            this.grpBoxAddNewPicture.TabIndex = 3;
            this.grpBoxAddNewPicture.TabStop = false;
            this.grpBoxAddNewPicture.Text = "Add new picture to student:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 274);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Add desrciption:";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(10, 297);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(564, 206);
            this.txtBoxDescription.TabIndex = 5;
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSavePicture.FlatAppearance.BorderSize = 100;
            this.btnSavePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSavePicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSavePicture.Location = new System.Drawing.Point(481, 539);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(93, 30);
            this.btnSavePicture.TabIndex = 8;
            this.btnSavePicture.Text = "Add picture";
            this.btnSavePicture.UseVisualStyleBackColor = false;
            // 
            // lblAddPic
            // 
            this.lblAddPic.AutoSize = true;
            this.lblAddPic.Location = new System.Drawing.Point(255, 34);
            this.lblAddPic.Name = "lblAddPic";
            this.lblAddPic.Size = new System.Drawing.Size(94, 20);
            this.lblAddPic.TabIndex = 9;
            this.lblAddPic.Text = "Add picture:";
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(154, 58);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(294, 225);
            this.AddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPicture.TabIndex = 10;
            this.AddPicture.TabStop = false;
            // 
            // opfFindPicture
            // 
            this.opfFindPicture.FileName = "openFileDialog1";
            // 
            // frmStudentPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 600);
            this.Controls.Add(this.grpBoxAddNewPicture);
            this.IsMdiContainer = true;
            this.Name = "frmStudentPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s pictures";
            this.grpBoxAddNewPicture.ResumeLayout(false);
            this.grpBoxAddNewPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddNewPicture;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox AddPicture;
        private System.Windows.Forms.Label lblAddPic;
        private System.Windows.Forms.Button btnSavePicture;
        private System.Windows.Forms.OpenFileDialog opfFindPicture;
    }
}