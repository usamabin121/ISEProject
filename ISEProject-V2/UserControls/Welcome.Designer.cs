namespace ISEProject_V2.UserControls
{
    partial class Welcome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Font = new System.Drawing.Font("Segoe UI Light", 36.25F);
            this.lbHi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.lbHi.Location = new System.Drawing.Point(0, 265);
            this.lbHi.MaximumSize = new System.Drawing.Size(1200, 70);
            this.lbHi.MinimumSize = new System.Drawing.Size(1200, 70);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(1200, 70);
            this.lbHi.TabIndex = 9;
            this.lbHi.Text = "Hi, Full Name";
            this.lbHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbHi);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHi;
    }
}
