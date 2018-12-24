namespace ISEProject_V2.UserControls.GO
{
    partial class Transport
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
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelErrors = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rTDestination = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rtSource = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnUpdateProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.trID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
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
            this.btnRefresh.Location = new System.Drawing.Point(948, 87);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Textcolor = System.Drawing.Color.White;
            this.btnRefresh.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BorderRadius = 0;
            this.btnAddProduct.ButtonText = "Request Now";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = null;
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = true;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = true;
            this.btnAddProduct.IconZoom = 90D;
            this.btnAddProduct.IsTab = false;
            this.btnAddProduct.Location = new System.Drawing.Point(10, 366);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(286, 39);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Request Now";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.labelErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelErrors.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrors.ForeColor = System.Drawing.Color.White;
            this.labelErrors.Location = new System.Drawing.Point(10, 423);
            this.labelErrors.MaximumSize = new System.Drawing.Size(286, 29);
            this.labelErrors.MinimumSize = new System.Drawing.Size(286, 29);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelErrors.Size = new System.Drawing.Size(286, 29);
            this.labelErrors.TabIndex = 39;
            this.labelErrors.Text = "Label for Errors";
            this.labelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTDestination
            // 
            this.rTDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rTDestination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTDestination.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.rTDestination.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.rTDestination.HintText = "Destination";
            this.rTDestination.isPassword = false;
            this.rTDestination.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.rTDestination.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(200)))));
            this.rTDestination.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.rTDestination.LineThickness = 2;
            this.rTDestination.Location = new System.Drawing.Point(10, 243);
            this.rTDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rTDestination.Name = "rTDestination";
            this.rTDestination.Size = new System.Drawing.Size(286, 39);
            this.rTDestination.TabIndex = 32;
            this.rTDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rtSource
            // 
            this.rtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtSource.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.rtSource.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.rtSource.HintText = "Source";
            this.rtSource.isPassword = false;
            this.rtSource.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.rtSource.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(200)))));
            this.rtSource.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.rtSource.LineThickness = 2;
            this.rtSource.Location = new System.Drawing.Point(10, 184);
            this.rtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtSource.Name = "rtSource";
            this.rtSource.Size = new System.Drawing.Size(286, 39);
            this.rtSource.TabIndex = 30;
            this.rtSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProduct.BorderRadius = 0;
            this.btnUpdateProduct.ButtonText = "Update Product";
            this.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateProduct.Iconimage = null;
            this.btnUpdateProduct.Iconimage_right = null;
            this.btnUpdateProduct.Iconimage_right_Selected = null;
            this.btnUpdateProduct.Iconimage_Selected = null;
            this.btnUpdateProduct.IconMarginLeft = 0;
            this.btnUpdateProduct.IconMarginRight = 0;
            this.btnUpdateProduct.IconRightVisible = true;
            this.btnUpdateProduct.IconRightZoom = 0D;
            this.btnUpdateProduct.IconVisible = true;
            this.btnUpdateProduct.IconZoom = 90D;
            this.btnUpdateProduct.IsTab = false;
            this.btnUpdateProduct.Location = new System.Drawing.Point(10, 366);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUpdateProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnUpdateProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateProduct.selected = false;
            this.btnUpdateProduct.Size = new System.Drawing.Size(286, 39);
            this.btnUpdateProduct.TabIndex = 40;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateProduct.Textcolor = System.Drawing.Color.White;
            this.btnUpdateProduct.TextFont = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = null;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(1034, 87);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(120)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(74, 23);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Cancel";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(1120, 87);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Cancel";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(432, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "List of Requested Transport";
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
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
            this.trID,
            this.trVehicle,
            this.trFrom,
            this.trDestination,
            this.trDateTime,
            this.trStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProducts.Location = new System.Drawing.Point(438, 125);
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
            this.dataProducts.Size = new System.Drawing.Size(756, 459);
            this.dataProducts.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Request Transport";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1188, 18);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Request Transportation";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(10, 307);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(286, 36);
            this.bunifuDatepicker1.TabIndex = 42;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 12, 23, 15, 21, 56, 921);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(10, 141);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(286, 35);
            this.bunifuDropdown1.TabIndex = 44;
            // 
            // trID
            // 
            this.trID.HeaderText = "ID";
            this.trID.Name = "trID";
            this.trID.ReadOnly = true;
            this.trID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trID.Width = 35;
            // 
            // trVehicle
            // 
            this.trVehicle.HeaderText = "Vehicle";
            this.trVehicle.Name = "trVehicle";
            this.trVehicle.ReadOnly = true;
            this.trVehicle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trVehicle.Width = 150;
            // 
            // trFrom
            // 
            this.trFrom.HeaderText = "From";
            this.trFrom.Name = "trFrom";
            this.trFrom.ReadOnly = true;
            this.trFrom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trFrom.Width = 180;
            // 
            // trDestination
            // 
            this.trDestination.HeaderText = "To";
            this.trDestination.Name = "trDestination";
            this.trDestination.ReadOnly = true;
            this.trDestination.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trDestination.Width = 180;
            // 
            // trDateTime
            // 
            this.trDateTime.HeaderText = "Date & Time";
            this.trDateTime.Name = "trDateTime";
            this.trDateTime.ReadOnly = true;
            this.trDateTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // trStatus
            // 
            this.trStatus.HeaderText = "Status";
            this.trStatus.Name = "trStatus";
            this.trStatus.ReadOnly = true;
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.rTDestination);
            this.Controls.Add(this.rtSource);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Name = "Transport";
            this.Size = new System.Drawing.Size(1200, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel labelErrors;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rTDestination;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rtSource;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trID;
        private System.Windows.Forms.DataGridViewTextBoxColumn trVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn trFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn trDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn trDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn trStatus;
    }
}
