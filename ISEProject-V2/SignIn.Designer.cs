namespace ISEProject_V2
{
    partial class formSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSignIn));
            this.labelExit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelErrors = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbSignInAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignInAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelExit.Location = new System.Drawing.Point(690, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(28, 17);
            this.labelExit.TabIndex = 13;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelErrors.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrors.ForeColor = System.Drawing.Color.White;
            this.labelErrors.Location = new System.Drawing.Point(430, 363);
            this.labelErrors.MaximumSize = new System.Drawing.Size(254, 29);
            this.labelErrors.MinimumSize = new System.Drawing.Size(254, 29);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelErrors.Size = new System.Drawing.Size(254, 29);
            this.labelErrors.TabIndex = 12;
            this.labelErrors.Text = "Label for Errors";
            this.labelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSignIn.Location = new System.Drawing.Point(429, 312);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(254, 37);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.HintForeColor = System.Drawing.Color.White;
            this.tbPassword.HintText = "Password";
            this.tbPassword.isPassword = true;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.White;
            this.tbPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tbPassword.LineThickness = 2;
            this.tbPassword.Location = new System.Drawing.Point(429, 255);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(254, 33);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Text = "1234";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUsername
            // 
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.HintForeColor = System.Drawing.Color.White;
            this.tbUsername.HintText = "Username";
            this.tbUsername.isPassword = false;
            this.tbUsername.LineFocusedColor = System.Drawing.Color.White;
            this.tbUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tbUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tbUsername.LineThickness = 2;
            this.tbUsername.Location = new System.Drawing.Point(429, 197);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(254, 33);
            this.tbUsername.TabIndex = 8;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbSignInAvatar
            // 
            this.pbSignInAvatar.ErrorImage = null;
            this.pbSignInAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbSignInAvatar.Image")));
            this.pbSignInAvatar.InitialImage = null;
            this.pbSignInAvatar.Location = new System.Drawing.Point(429, 37);
            this.pbSignInAvatar.Name = "pbSignInAvatar";
            this.pbSignInAvatar.Size = new System.Drawing.Size(254, 138);
            this.pbSignInAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSignInAvatar.TabIndex = 11;
            this.pbSignInAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 429);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(101, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 70F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(77, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 125);
            this.label1.TabIndex = 16;
            this.label1.Text = "V S D";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(730, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.pbSignInAvatar);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In - VSD Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pbSignInAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel labelExit;
        private Bunifu.Framework.UI.BunifuCustomLabel labelErrors;
        private System.Windows.Forms.Button btnSignIn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        private System.Windows.Forms.PictureBox pbSignInAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

