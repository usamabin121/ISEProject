namespace ISEProject_V2.UserControls.MTO
{
    partial class AvaiableTransports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvaiableTransports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestTrasportGrdvw = new System.Windows.Forms.Panel();
            this.BtnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestTrasportGrdvw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 39);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1188, 18);
            this.bunifuSeparator1.TabIndex = 43;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 42);
            this.label1.TabIndex = 42;
            this.label1.Text = "Available Transport";
            // 
            // RequestTrasportGrdvw
            // 
            this.RequestTrasportGrdvw.Controls.Add(this.BtnBack);
            this.RequestTrasportGrdvw.Controls.Add(this.bunifuFlatButton3);
            this.RequestTrasportGrdvw.Controls.Add(this.dataProducts);
            this.RequestTrasportGrdvw.Location = new System.Drawing.Point(110, 63);
            this.RequestTrasportGrdvw.Name = "RequestTrasportGrdvw";
            this.RequestTrasportGrdvw.Size = new System.Drawing.Size(980, 474);
            this.RequestTrasportGrdvw.TabIndex = 44;
            // 
            // BtnBack
            // 
            this.BtnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.BorderRadius = 0;
            this.BtnBack.ButtonText = "Back";
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnBack.Iconimage")));
            this.BtnBack.Iconimage_right = null;
            this.BtnBack.Iconimage_right_Selected = null;
            this.BtnBack.Iconimage_Selected = null;
            this.BtnBack.IconMarginLeft = 0;
            this.BtnBack.IconMarginRight = 0;
            this.BtnBack.IconRightVisible = true;
            this.BtnBack.IconRightZoom = 0D;
            this.BtnBack.IconVisible = true;
            this.BtnBack.IconZoom = 90D;
            this.BtnBack.IsTab = false;
            this.BtnBack.Location = new System.Drawing.Point(559, 367);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBack.selected = false;
            this.BtnBack.Size = new System.Drawing.Size(108, 48);
            this.BtnBack.TabIndex = 42;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Textcolor = System.Drawing.Color.White;
            this.BtnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Delete ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(382, 367);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(108, 48);
            this.bunifuFlatButton3.TabIndex = 40;
            this.bunifuFlatButton3.Text = "Delete ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.AllowUserToOrderColumns = true;
            this.dataProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Desination,
            this.Category,
            this.Quantity,
            this.IssueDate,
            this.Timings});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataProducts.Location = new System.Drawing.Point(107, 3);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataProducts.Size = new System.Drawing.Size(789, 306);
            this.dataProducts.TabIndex = 34;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductID.Width = 35;
            // 
            // Desination
            // 
            this.Desination.HeaderText = "Destination";
            this.Desination.Name = "Desination";
            this.Desination.ReadOnly = true;
            this.Desination.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            this.IssueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Timings
            // 
            this.Timings.HeaderText = "Timings";
            this.Timings.Name = "Timings";
            this.Timings.ReadOnly = true;
            this.Timings.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Timings.Width = 200;
            // 
            // AvaiableTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequestTrasportGrdvw);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Name = "AvaiableTransports";
            this.Size = new System.Drawing.Size(1200, 600);
            this.RequestTrasportGrdvw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RequestTrasportGrdvw;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBack;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timings;
    }
}
