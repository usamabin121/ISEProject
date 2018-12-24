namespace ISEProject_V2.UserControls.GO
{
    partial class Requests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.reqID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelErrors = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 42);
            this.label1.TabIndex = 31;
            this.label1.Text = "Received Requests";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1188, 18);
            this.bunifuSeparator1.TabIndex = 32;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.AllowUserToOrderColumns = true;
            this.dataProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqID,
            this.reqDate,
            this.reqIncharge,
            this.reqUnit,
            this.reqProduct,
            this.reqQuantity,
            this.reqCategory,
            this.reqNote});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataProducts.Location = new System.Drawing.Point(10, 89);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataProducts.Size = new System.Drawing.Size(1173, 489);
            this.dataProducts.TabIndex = 35;
            // 
            // reqID
            // 
            this.reqID.HeaderText = "ID";
            this.reqID.Name = "reqID";
            this.reqID.ReadOnly = true;
            this.reqID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reqID.Width = 35;
            // 
            // reqDate
            // 
            this.reqDate.HeaderText = "Date & Time";
            this.reqDate.Name = "reqDate";
            this.reqDate.ReadOnly = true;
            // 
            // reqIncharge
            // 
            this.reqIncharge.HeaderText = "Incharge";
            this.reqIncharge.Name = "reqIncharge";
            this.reqIncharge.ReadOnly = true;
            this.reqIncharge.Width = 200;
            // 
            // reqUnit
            // 
            this.reqUnit.HeaderText = "Unit";
            this.reqUnit.Name = "reqUnit";
            this.reqUnit.ReadOnly = true;
            this.reqUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reqUnit.Width = 200;
            // 
            // reqProduct
            // 
            this.reqProduct.HeaderText = "Product";
            this.reqProduct.Name = "reqProduct";
            this.reqProduct.ReadOnly = true;
            this.reqProduct.Width = 250;
            // 
            // reqQuantity
            // 
            this.reqQuantity.HeaderText = "Quantity";
            this.reqQuantity.Name = "reqQuantity";
            this.reqQuantity.ReadOnly = true;
            this.reqQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reqQuantity.Width = 60;
            // 
            // reqCategory
            // 
            this.reqCategory.HeaderText = "Category";
            this.reqCategory.Name = "reqCategory";
            this.reqCategory.ReadOnly = true;
            // 
            // reqNote
            // 
            this.reqNote.HeaderText = "Note";
            this.reqNote.Name = "reqNote";
            this.reqNote.ReadOnly = true;
            this.reqNote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reqNote.Width = 250;
            // 
            // btnApprove
            // 
            this.btnApprove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApprove.BorderRadius = 0;
            this.btnApprove.ButtonText = "Approve";
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.DisabledColor = System.Drawing.Color.Gray;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Iconcolor = System.Drawing.Color.Transparent;
            this.btnApprove.Iconimage = null;
            this.btnApprove.Iconimage_right = null;
            this.btnApprove.Iconimage_right_Selected = null;
            this.btnApprove.Iconimage_Selected = null;
            this.btnApprove.IconMarginLeft = 0;
            this.btnApprove.IconMarginRight = 0;
            this.btnApprove.IconRightVisible = true;
            this.btnApprove.IconRightZoom = 0D;
            this.btnApprove.IconVisible = true;
            this.btnApprove.IconZoom = 90D;
            this.btnApprove.IsTab = false;
            this.btnApprove.Location = new System.Drawing.Point(1016, 57);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(6);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnApprove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnApprove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnApprove.selected = false;
            this.btnApprove.Size = new System.Drawing.Size(81, 23);
            this.btnApprove.TabIndex = 37;
            this.btnApprove.Text = "Approve";
            this.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApprove.Textcolor = System.Drawing.Color.White;
            this.btnApprove.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnReject
            // 
            this.btnReject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReject.BorderRadius = 0;
            this.btnReject.ButtonText = "Reject";
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.DisabledColor = System.Drawing.Color.Gray;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReject.Iconimage = null;
            this.btnReject.Iconimage_right = null;
            this.btnReject.Iconimage_right_Selected = null;
            this.btnReject.Iconimage_Selected = null;
            this.btnReject.IconMarginLeft = 0;
            this.btnReject.IconMarginRight = 0;
            this.btnReject.IconRightVisible = true;
            this.btnReject.IconRightZoom = 0D;
            this.btnReject.IconVisible = true;
            this.btnReject.IconZoom = 90D;
            this.btnReject.IsTab = false;
            this.btnReject.Location = new System.Drawing.Point(1109, 57);
            this.btnReject.Margin = new System.Windows.Forms.Padding(6);
            this.btnReject.Name = "btnReject";
            this.btnReject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReject.selected = false;
            this.btnReject.Size = new System.Drawing.Size(74, 23);
            this.btnReject.TabIndex = 36;
            this.btnReject.Text = "Reject";
            this.btnReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReject.Textcolor = System.Drawing.Color.White;
            this.btnReject.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelErrors.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrors.ForeColor = System.Drawing.Color.White;
            this.labelErrors.Location = new System.Drawing.Point(381, 55);
            this.labelErrors.MaximumSize = new System.Drawing.Size(400, 30);
            this.labelErrors.MinimumSize = new System.Drawing.Size(400, 30);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelErrors.Size = new System.Drawing.Size(400, 30);
            this.labelErrors.TabIndex = 38;
            this.labelErrors.Text = "Label for Errors";
            this.labelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "Requests";
            this.Size = new System.Drawing.Size(1200, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqNote;
        private Bunifu.Framework.UI.BunifuFlatButton btnApprove;
        private Bunifu.Framework.UI.BunifuFlatButton btnReject;
        private Bunifu.Framework.UI.BunifuCustomLabel labelErrors;
    }
}
