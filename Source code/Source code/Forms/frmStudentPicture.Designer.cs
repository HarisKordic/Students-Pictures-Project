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
            this.components = new System.ComponentModel.Container();
            this.grpBoxAddNewPicture = new System.Windows.Forms.GroupBox();
            this.llblDescription = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.lblAddPic = new System.Windows.Forms.Label();
            this.AddPicture = new System.Windows.Forms.PictureBox();
            this.opfFindPicture = new System.Windows.Forms.OpenFileDialog();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxDisplayPics = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentPicture = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblDateOfPicture = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.grpBoxAddNewPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.grpBoxDisplayPics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxAddNewPicture
            // 
            this.grpBoxAddNewPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxAddNewPicture.Controls.Add(this.AddPicture);
            this.grpBoxAddNewPicture.Controls.Add(this.lblAddPic);
            this.grpBoxAddNewPicture.Controls.Add(this.btnSavePicture);
            this.grpBoxAddNewPicture.Controls.Add(this.txtBoxDescription);
            this.grpBoxAddNewPicture.Controls.Add(this.llblDescription);
            this.grpBoxAddNewPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxAddNewPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxAddNewPicture.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAddNewPicture.Name = "grpBoxAddNewPicture";
            this.grpBoxAddNewPicture.Size = new System.Drawing.Size(590, 576);
            this.grpBoxAddNewPicture.TabIndex = 3;
            this.grpBoxAddNewPicture.TabStop = false;
            this.grpBoxAddNewPicture.Text = "Add new picture to student:";
            // 
            // llblDescription
            // 
            this.llblDescription.AutoSize = true;
            this.llblDescription.Location = new System.Drawing.Point(6, 274);
            this.llblDescription.Name = "llblDescription";
            this.llblDescription.Size = new System.Drawing.Size(123, 20);
            this.llblDescription.TabIndex = 4;
            this.llblDescription.Text = "Add desrciption:";
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
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
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
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // grpBoxDisplayPics
            // 
            this.grpBoxDisplayPics.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxDisplayPics.Controls.Add(this.Description);
            this.grpBoxDisplayPics.Controls.Add(this.lblDescription);
            this.grpBoxDisplayPics.Controls.Add(this.btnLeft);
            this.grpBoxDisplayPics.Controls.Add(this.pictureBox1);
            this.grpBoxDisplayPics.Controls.Add(this.lblCurrentPicture);
            this.grpBoxDisplayPics.Controls.Add(this.btnRight);
            this.grpBoxDisplayPics.Controls.Add(this.lblDateOfPicture);
            this.grpBoxDisplayPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxDisplayPics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxDisplayPics.Location = new System.Drawing.Point(645, 12);
            this.grpBoxDisplayPics.Name = "grpBoxDisplayPics";
            this.grpBoxDisplayPics.Size = new System.Drawing.Size(929, 576);
            this.grpBoxDisplayPics.TabIndex = 11;
            this.grpBoxDisplayPics.TabStop = false;
            this.grpBoxDisplayPics.Text = "Student\'s avaliable pictures:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(288, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentPicture
            // 
            this.lblCurrentPicture.AutoSize = true;
            this.lblCurrentPicture.Location = new System.Drawing.Point(489, 22);
            this.lblCurrentPicture.Name = "lblCurrentPicture";
            this.lblCurrentPicture.Size = new System.Drawing.Size(26, 20);
            this.lblCurrentPicture.TabIndex = 9;
            this.lblCurrentPicture.Text = "cp";
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRight.FlatAppearance.BorderSize = 100;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRight.Location = new System.Drawing.Point(730, 341);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(93, 30);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "==>";
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // lblDateOfPicture
            // 
            this.lblDateOfPicture.AutoSize = true;
            this.lblDateOfPicture.Location = new System.Drawing.Point(430, 374);
            this.lblDateOfPicture.Name = "lblDateOfPicture";
            this.lblDateOfPicture.Size = new System.Drawing.Size(48, 20);
            this.lblDateOfPicture.TabIndex = 4;
            this.lblDateOfPicture.Text = "Date:";
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeft.FlatAppearance.BorderSize = 100;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeft.Location = new System.Drawing.Point(179, 341);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(93, 30);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "<==";
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 468);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 20);
            this.lblDescription.TabIndex = 11;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(6, 436);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(93, 20);
            this.Description.TabIndex = 12;
            this.Description.Text = "Description:";
            // 
            // frmStudentPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 600);
            this.Controls.Add(this.grpBoxDisplayPics);
            this.Controls.Add(this.grpBoxAddNewPicture);
            this.IsMdiContainer = true;
            this.Name = "frmStudentPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s pictures";
            this.grpBoxAddNewPicture.ResumeLayout(false);
            this.grpBoxAddNewPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.grpBoxDisplayPics.ResumeLayout(false);
            this.grpBoxDisplayPics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddNewPicture;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label llblDescription;
        private System.Windows.Forms.PictureBox AddPicture;
        private System.Windows.Forms.Label lblAddPic;
        private System.Windows.Forms.Button btnSavePicture;
        private System.Windows.Forms.OpenFileDialog opfFindPicture;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox grpBoxDisplayPics;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentPicture;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblDateOfPicture;
        private System.Windows.Forms.Label Description;
    }
}