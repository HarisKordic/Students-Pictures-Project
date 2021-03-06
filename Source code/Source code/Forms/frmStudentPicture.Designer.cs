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
            this.btnEdit = new System.Windows.Forms.Button();
            this.AddPicture = new System.Windows.Forms.PictureBox();
            this.lblAddPic = new System.Windows.Forms.Label();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.llblDescription = new System.Windows.Forms.Label();
            this.opfFindPicture = new System.Windows.Forms.OpenFileDialog();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxDisplayPics = new System.Windows.Forms.GroupBox();
            this.Description = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.DisplayPicture = new System.Windows.Forms.PictureBox();
            this.lblCurrentPicture = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblDateOfPicture = new System.Windows.Forms.Label();
            this.grpBoxAddNewPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.grpBoxDisplayPics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxAddNewPicture
            // 
            this.grpBoxAddNewPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxAddNewPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxAddNewPicture.Controls.Add(this.btnEdit);
            this.grpBoxAddNewPicture.Controls.Add(this.AddPicture);
            this.grpBoxAddNewPicture.Controls.Add(this.lblAddPic);
            this.grpBoxAddNewPicture.Controls.Add(this.btnSavePicture);
            this.grpBoxAddNewPicture.Controls.Add(this.txtBoxDescription);
            this.grpBoxAddNewPicture.Controls.Add(this.llblDescription);
            this.grpBoxAddNewPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxAddNewPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxAddNewPicture.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAddNewPicture.Name = "grpBoxAddNewPicture";
            this.grpBoxAddNewPicture.Size = new System.Drawing.Size(614, 638);
            this.grpBoxAddNewPicture.TabIndex = 3;
            this.grpBoxAddNewPicture.TabStop = false;
            this.grpBoxAddNewPicture.Text = "Add new picture to student";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.FlatAppearance.BorderSize = 100;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(10, 602);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(154, 58);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(294, 225);
            this.AddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPicture.TabIndex = 10;
            this.AddPicture.TabStop = false;
            this.AddPicture.Click += new System.EventHandler(this.AddPicture_Click);
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
            // btnSavePicture
            // 
            this.btnSavePicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSavePicture.FlatAppearance.BorderSize = 100;
            this.btnSavePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSavePicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSavePicture.Location = new System.Drawing.Point(498, 602);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(93, 30);
            this.btnSavePicture.TabIndex = 8;
            this.btnSavePicture.Text = "Add picture";
            this.btnSavePicture.UseVisualStyleBackColor = false;
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(10, 297);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(581, 206);
            this.txtBoxDescription.TabIndex = 5;
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
            this.grpBoxDisplayPics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxDisplayPics.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBoxDisplayPics.Controls.Add(this.Description);
            this.grpBoxDisplayPics.Controls.Add(this.lblDescription);
            this.grpBoxDisplayPics.Controls.Add(this.btnLeft);
            this.grpBoxDisplayPics.Controls.Add(this.DisplayPicture);
            this.grpBoxDisplayPics.Controls.Add(this.lblCurrentPicture);
            this.grpBoxDisplayPics.Controls.Add(this.btnRight);
            this.grpBoxDisplayPics.Controls.Add(this.lblDateOfPicture);
            this.grpBoxDisplayPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxDisplayPics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxDisplayPics.Location = new System.Drawing.Point(645, 12);
            this.grpBoxDisplayPics.Name = "grpBoxDisplayPics";
            this.grpBoxDisplayPics.Size = new System.Drawing.Size(929, 638);
            this.grpBoxDisplayPics.TabIndex = 11;
            this.grpBoxDisplayPics.TabStop = false;
            this.grpBoxDisplayPics.Text = "Student\'s avaliable pictures";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Description.Location = new System.Drawing.Point(6, 436);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(93, 20);
            this.Description.TabIndex = 12;
            this.Description.Text = "Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescription.Location = new System.Drawing.Point(6, 456);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(900, 176);
            this.lblDescription.TabIndex = 11;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeft.FlatAppearance.BorderSize = 100;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeft.Location = new System.Drawing.Point(179, 366);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(93, 30);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "<==";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // DisplayPicture
            // 
            this.DisplayPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPicture.Location = new System.Drawing.Point(288, 70);
            this.DisplayPicture.Name = "DisplayPicture";
            this.DisplayPicture.Size = new System.Drawing.Size(425, 326);
            this.DisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisplayPicture.TabIndex = 10;
            this.DisplayPicture.TabStop = false;
            // 
            // lblCurrentPicture
            // 
            this.lblCurrentPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPicture.Location = new System.Drawing.Point(284, 22);
            this.lblCurrentPicture.Name = "lblCurrentPicture";
            this.lblCurrentPicture.Size = new System.Drawing.Size(429, 45);
            this.lblCurrentPicture.TabIndex = 9;
            this.lblCurrentPicture.Text = "cp";
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRight.FlatAppearance.BorderSize = 100;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRight.Location = new System.Drawing.Point(730, 366);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(93, 30);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "==>";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblDateOfPicture
            // 
            this.lblDateOfPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfPicture.AutoSize = true;
            this.lblDateOfPicture.Location = new System.Drawing.Point(430, 399);
            this.lblDateOfPicture.Name = "lblDateOfPicture";
            this.lblDateOfPicture.Size = new System.Drawing.Size(48, 20);
            this.lblDateOfPicture.TabIndex = 4;
            this.lblDateOfPicture.Text = "Date:";
            // 
            // frmStudentPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 662);
            this.Controls.Add(this.grpBoxDisplayPics);
            this.Controls.Add(this.grpBoxAddNewPicture);
            this.IsMdiContainer = true;
            this.Name = "frmStudentPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s pictures";
            this.Load += new System.EventHandler(this.frmStudentPicture_Load);
            this.grpBoxAddNewPicture.ResumeLayout(false);
            this.grpBoxAddNewPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.grpBoxDisplayPics.ResumeLayout(false);
            this.grpBoxDisplayPics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).EndInit();
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
        private System.Windows.Forms.PictureBox DisplayPicture;
        private System.Windows.Forms.Label lblCurrentPicture;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblDateOfPicture;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button btnEdit;
    }
}