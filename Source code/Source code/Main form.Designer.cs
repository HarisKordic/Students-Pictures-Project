namespace Source_code
{
    partial class Main_form
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
            this.llblMail = new System.Windows.Forms.LinkLabel();
            this.llblGithub = new System.Windows.Forms.LinkLabel();
            this.btnStartProgram = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llblMail
            // 
            this.llblMail.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.llblMail.AutoSize = true;
            this.llblMail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.llblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llblMail.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.llblMail.Location = new System.Drawing.Point(353, 327);
            this.llblMail.Name = "llblMail";
            this.llblMail.Size = new System.Drawing.Size(74, 20);
            this.llblMail.TabIndex = 2;
            this.llblMail.TabStop = true;
            this.llblMail.Text = "Email me";
            this.llblMail.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.llblMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMail_LinkClicked);
            // 
            // llblGithub
            // 
            this.llblGithub.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.llblGithub.AutoSize = true;
            this.llblGithub.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.llblGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llblGithub.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.llblGithub.Location = new System.Drawing.Point(360, 300);
            this.llblGithub.Name = "llblGithub";
            this.llblGithub.Size = new System.Drawing.Size(57, 20);
            this.llblGithub.TabIndex = 4;
            this.llblGithub.TabStop = true;
            this.llblGithub.Text = "Github";
            this.llblGithub.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.llblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGithub_LinkClicked);
            // 
            // btnStartProgram
            // 
            this.btnStartProgram.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartProgram.FlatAppearance.BorderSize = 100;
            this.btnStartProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartProgram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartProgram.Location = new System.Drawing.Point(288, 408);
            this.btnStartProgram.Name = "btnStartProgram";
            this.btnStartProgram.Size = new System.Drawing.Size(203, 30);
            this.btnStartProgram.TabIndex = 6;
            this.btnStartProgram.Text = "Start program";
            this.btnStartProgram.UseVisualStyleBackColor = false;
            this.btnStartProgram.Click += new System.EventHandler(this.btnStartProgram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = global::Source_code.Properties.Resources.sp_logo;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartProgram);
            this.Controls.Add(this.llblGithub);
            this.Controls.Add(this.llblMail);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblMail;
        private System.Windows.Forms.LinkLabel llblGithub;
        private System.Windows.Forms.Button btnStartProgram;
    }
}