namespace ISEProject_V2.UserControls.GO
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductFridge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.ProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefresh.Iconimage = null;
            this.btnRefresh.Iconimage_right = null;
            this.btnRefresh.Iconimage_right_Selected = null;
            this.btnRefresh.Iconimage_Selected = null;
            this.btnRefresh.IconMarginLeft = 0;
            this.btnRefresh.IconMarginRight = 0;
            this.btnRefresh.IconRightVisible = true;
            this.btnRefresh.IconRightZoom = 0D;
            this.btnRefresh.IconVisible = true;
            this.btnRefresh.IconZoom = 90D;
            this.btnRefresh.IsTab = false;
            this.btnRefresh.Location = new System.Drawing.Point(1109, 95);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Textcolor = System.Drawing.Color.White;
            this.btnRefresh.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Inventory";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 39);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1188, 18);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.AllowUserToOrderColumns = true;
            this.dataProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductCode,
            this.ProductTitle,
            this.ProductCategory,
            this.ProductQty,
            this.ProductDescription,
            this.ProductFridge,
            this.ProductInStock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProducts.Location = new System.Drawing.Point(14, 3);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataProducts.Size = new System.Drawing.Size(951, 306);
            this.dataProducts.TabIndex = 34;
            this.dataProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducts_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductID.Width = 35;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 150;
            // 
            // ProductTitle
            // 
            this.ProductTitle.HeaderText = "Product Name";
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.ReadOnly = true;
            this.ProductTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductTitle.Width = 200;
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            // 
            // ProductQty
            // 
            this.ProductQty.HeaderText = "Quantity";
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.ReadOnly = true;
            this.ProductQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductQty.Width = 60;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDescription.Width = 200;
            // 
            // ProductFridge
            // 
            this.ProductFridge.HeaderText = "Fridge ID";
            this.ProductFridge.Name = "ProductFridge";
            this.ProductFridge.ReadOnly = true;
            // 
            // ProductInStock
            // 
            this.ProductInStock.HeaderText = "In-Stock";
            this.ProductInStock.Name = "ProductInStock";
            this.ProductInStock.ReadOnly = true;
            this.ProductInStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductInStock.Width = 80;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.dataProducts);
            this.ProductPanel.Location = new System.Drawing.Point(10, 66);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(1173, 517);
            this.ProductPanel.TabIndex = 33;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ProductPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductFridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInStock;
        private System.Windows.Forms.Panel ProductPanel;
    }
}
