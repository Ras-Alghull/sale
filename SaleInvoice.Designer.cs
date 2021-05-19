namespace IT4solutionsPointOfSalesSoftware.Screens.SalesF
{
    partial class SaleInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleInvoice));
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextBx = new MetroFramework.Controls.MetroTextBox();
            this.SearchLabel = new MetroFramework.Controls.MetroLabel();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            this.DateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PriceLabel = new MetroFramework.Controls.MetroLabel();
            this.PriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductIDLabel = new MetroFramework.Controls.MetroLabel();
            this.PIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductNameLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StockTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StockLabel = new MetroFramework.Controls.MetroLabel();
            this.TotalTextLabel = new MetroFramework.Controls.MetroLabel();
            this.TotalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductInfoGroup = new System.Windows.Forms.GroupBox();
            this.SalesInvoiceGrid = new MetroFramework.Controls.MetroGrid();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.SaleButton = new MetroFramework.Controls.MetroButton();
            this.ProductInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesInvoiceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(23, 99);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(85, 19);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "USERNAME :";
            // 
            // UsernameTextBx
            // 
            // 
            // 
            // 
            this.UsernameTextBx.CustomButton.Image = null;
            this.UsernameTextBx.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.UsernameTextBx.CustomButton.Name = "";
            this.UsernameTextBx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTextBx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBx.CustomButton.TabIndex = 1;
            this.UsernameTextBx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBx.CustomButton.UseSelectable = true;
            this.UsernameTextBx.CustomButton.Visible = false;
            this.UsernameTextBx.Lines = new string[0];
            this.UsernameTextBx.Location = new System.Drawing.Point(140, 99);
            this.UsernameTextBx.MaxLength = 32767;
            this.UsernameTextBx.Name = "UsernameTextBx";
            this.UsernameTextBx.PasswordChar = '\0';
            this.UsernameTextBx.ReadOnly = true;
            this.UsernameTextBx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBx.SelectedText = "";
            this.UsernameTextBx.SelectionLength = 0;
            this.UsernameTextBx.SelectionStart = 0;
            this.UsernameTextBx.ShortcutsEnabled = true;
            this.UsernameTextBx.Size = new System.Drawing.Size(100, 23);
            this.UsernameTextBx.TabIndex = 1;
            this.UsernameTextBx.UseSelectable = true;
            this.UsernameTextBx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameTextBx.Click += new System.EventHandler(this.UsernameTextBx_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(23, 147);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(65, 19);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "SEARCH :";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchTextBox
            // 
            // 
            // 
            // 
            this.SearchTextBox.CustomButton.Image = null;
            this.SearchTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.SearchTextBox.CustomButton.Name = "";
            this.SearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTextBox.CustomButton.TabIndex = 1;
            this.SearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTextBox.CustomButton.UseSelectable = true;
            this.SearchTextBox.CustomButton.Visible = false;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.Location = new System.Drawing.Point(140, 147);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.Size = new System.Drawing.Size(100, 23);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.UseSelectable = true;
            this.SearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "QUANTITY:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(140, 184);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.QuantityTextBox.TabIndex = 1;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(323, 99);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(83, 19);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "DATE  TIME :";
            // 
            // DateTextBox
            // 
            // 
            // 
            // 
            this.DateTextBox.CustomButton.Image = null;
            this.DateTextBox.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.DateTextBox.CustomButton.Name = "";
            this.DateTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DateTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DateTextBox.CustomButton.TabIndex = 1;
            this.DateTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DateTextBox.CustomButton.UseSelectable = true;
            this.DateTextBox.CustomButton.Visible = false;
            this.DateTextBox.Lines = new string[0];
            this.DateTextBox.Location = new System.Drawing.Point(418, 99);
            this.DateTextBox.MaxLength = 32767;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.PasswordChar = '\0';
            this.DateTextBox.ReadOnly = true;
            this.DateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DateTextBox.SelectedText = "";
            this.DateTextBox.SelectionLength = 0;
            this.DateTextBox.SelectionStart = 0;
            this.DateTextBox.ShortcutsEnabled = true;
            this.DateTextBox.Size = new System.Drawing.Size(284, 23);
            this.DateTextBox.TabIndex = 1;
            this.DateTextBox.UseSelectable = true;
            this.DateTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DateTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(132, 78);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(47, 19);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "PRICE:";
            // 
            // PriceTextBox
            // 
            // 
            // 
            // 
            this.PriceTextBox.CustomButton.Image = null;
            this.PriceTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.PriceTextBox.CustomButton.Name = "";
            this.PriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceTextBox.CustomButton.TabIndex = 1;
            this.PriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceTextBox.CustomButton.UseSelectable = true;
            this.PriceTextBox.CustomButton.Visible = false;
            this.PriceTextBox.Lines = new string[0];
            this.PriceTextBox.Location = new System.Drawing.Point(132, 100);
            this.PriceTextBox.MaxLength = 32767;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.SelectionLength = 0;
            this.PriceTextBox.SelectionStart = 0;
            this.PriceTextBox.ShortcutsEnabled = true;
            this.PriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.PriceTextBox.TabIndex = 1;
            this.PriceTextBox.UseSelectable = true;
            this.PriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(6, 22);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(86, 19);
            this.ProductIDLabel.TabIndex = 0;
            this.ProductIDLabel.Text = "PRODUCT ID";
            // 
            // PIDTextBox
            // 
            // 
            // 
            // 
            this.PIDTextBox.CustomButton.Image = null;
            this.PIDTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.PIDTextBox.CustomButton.Name = "";
            this.PIDTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PIDTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PIDTextBox.CustomButton.TabIndex = 1;
            this.PIDTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PIDTextBox.CustomButton.UseSelectable = true;
            this.PIDTextBox.CustomButton.Visible = false;
            this.PIDTextBox.Lines = new string[0];
            this.PIDTextBox.Location = new System.Drawing.Point(6, 44);
            this.PIDTextBox.MaxLength = 32767;
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.PasswordChar = '\0';
            this.PIDTextBox.ReadOnly = true;
            this.PIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PIDTextBox.SelectedText = "";
            this.PIDTextBox.SelectionLength = 0;
            this.PIDTextBox.SelectionStart = 0;
            this.PIDTextBox.ShortcutsEnabled = true;
            this.PIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.PIDTextBox.TabIndex = 1;
            this.PIDTextBox.UseSelectable = true;
            this.PIDTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PIDTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(6, 78);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(50, 19);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "NAME:";
            // 
            // ProductNameTextBox
            // 
            // 
            // 
            // 
            this.ProductNameTextBox.CustomButton.Image = null;
            this.ProductNameTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.ProductNameTextBox.CustomButton.Name = "";
            this.ProductNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameTextBox.CustomButton.TabIndex = 1;
            this.ProductNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameTextBox.CustomButton.UseSelectable = true;
            this.ProductNameTextBox.CustomButton.Visible = false;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(6, 100);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.ReadOnly = true;
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.SelectionLength = 0;
            this.ProductNameTextBox.SelectionStart = 0;
            this.ProductNameTextBox.ShortcutsEnabled = true;
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductNameTextBox.TabIndex = 1;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StockTextBox
            // 
            // 
            // 
            // 
            this.StockTextBox.CustomButton.Image = null;
            this.StockTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.StockTextBox.CustomButton.Name = "";
            this.StockTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StockTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StockTextBox.CustomButton.TabIndex = 1;
            this.StockTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StockTextBox.CustomButton.UseSelectable = true;
            this.StockTextBox.CustomButton.Visible = false;
            this.StockTextBox.Lines = new string[0];
            this.StockTextBox.Location = new System.Drawing.Point(261, 100);
            this.StockTextBox.MaxLength = 32767;
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.PasswordChar = '\0';
            this.StockTextBox.ReadOnly = true;
            this.StockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StockTextBox.SelectedText = "";
            this.StockTextBox.SelectionLength = 0;
            this.StockTextBox.SelectionStart = 0;
            this.StockTextBox.ShortcutsEnabled = true;
            this.StockTextBox.Size = new System.Drawing.Size(100, 23);
            this.StockTextBox.TabIndex = 1;
            this.StockTextBox.UseSelectable = true;
            this.StockTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Location = new System.Drawing.Point(261, 78);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(52, 19);
            this.StockLabel.TabIndex = 0;
            this.StockLabel.Text = "STOCK:";
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Location = new System.Drawing.Point(589, 350);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(52, 19);
            this.TotalTextLabel.TabIndex = 0;
            this.TotalTextLabel.Text = "TOTAL :";
            // 
            // TotalTextBox
            // 
            // 
            // 
            // 
            this.TotalTextBox.CustomButton.Image = null;
            this.TotalTextBox.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.TotalTextBox.CustomButton.Name = "";
            this.TotalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalTextBox.CustomButton.TabIndex = 1;
            this.TotalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalTextBox.CustomButton.UseSelectable = true;
            this.TotalTextBox.CustomButton.Visible = false;
            this.TotalTextBox.Lines = new string[0];
            this.TotalTextBox.Location = new System.Drawing.Point(589, 381);
            this.TotalTextBox.MaxLength = 32767;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.PasswordChar = '\0';
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalTextBox.SelectedText = "";
            this.TotalTextBox.SelectionLength = 0;
            this.TotalTextBox.SelectionStart = 0;
            this.TotalTextBox.ShortcutsEnabled = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 23);
            this.TotalTextBox.TabIndex = 1;
            this.TotalTextBox.UseSelectable = true;
            this.TotalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductInfoGroup
            // 
            this.ProductInfoGroup.Controls.Add(this.ProductIDLabel);
            this.ProductInfoGroup.Controls.Add(this.PIDTextBox);
            this.ProductInfoGroup.Controls.Add(this.StockTextBox);
            this.ProductInfoGroup.Controls.Add(this.PriceLabel);
            this.ProductInfoGroup.Controls.Add(this.ProductNameTextBox);
            this.ProductInfoGroup.Controls.Add(this.PriceTextBox);
            this.ProductInfoGroup.Controls.Add(this.ProductNameLabel);
            this.ProductInfoGroup.Controls.Add(this.StockLabel);
            this.ProductInfoGroup.Location = new System.Drawing.Point(323, 144);
            this.ProductInfoGroup.Name = "ProductInfoGroup";
            this.ProductInfoGroup.Size = new System.Drawing.Size(390, 152);
            this.ProductInfoGroup.TabIndex = 2;
            this.ProductInfoGroup.TabStop = false;
            this.ProductInfoGroup.Text = "PRODUCT INFO :";
            this.ProductInfoGroup.Enter += new System.EventHandler(this.ProductInfoGroup_Enter);
            // 
            // SalesInvoiceGrid
            // 
            this.SalesInvoiceGrid.AllowUserToResizeRows = false;
            this.SalesInvoiceGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesInvoiceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesInvoiceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SalesInvoiceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesInvoiceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesInvoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesInvoiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProdctName,
            this.Price,
            this.Quantity,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesInvoiceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesInvoiceGrid.EnableHeadersVisualStyles = false;
            this.SalesInvoiceGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalesInvoiceGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesInvoiceGrid.Location = new System.Drawing.Point(23, 302);
            this.SalesInvoiceGrid.Name = "SalesInvoiceGrid";
            this.SalesInvoiceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesInvoiceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesInvoiceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesInvoiceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesInvoiceGrid.Size = new System.Drawing.Size(528, 191);
            this.SalesInvoiceGrid.TabIndex = 3;
            this.SalesInvoiceGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesInvoiceGrid_CellEndEdit);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProdctName
            // 
            this.ProdctName.HeaderText = "Product Name";
            this.ProdctName.Name = "ProdctName";
            this.ProdctName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PrintReceipt
            // 
            this.PrintReceipt.DocumentName = "CustomerReceipt";
            this.PrintReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintReceipt_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.PrintReceipt;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(219)))));
            this.ExitButton.BackgroundImage = global::IT4solutionsPointOfSalesSoftware.Properties.Resources.close__1___1_;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.Location = new System.Drawing.Point(589, 462);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 31);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "CLEAR| EXIT";
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(219)))));
            this.SaleButton.BackgroundImage = global::IT4solutionsPointOfSalesSoftware.Properties.Resources._10279332911558096440_24;
            this.SaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaleButton.Location = new System.Drawing.Point(589, 428);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(125, 28);
            this.SaleButton.TabIndex = 4;
            this.SaleButton.Text = "SALE | PRINT";
            this.SaleButton.UseSelectable = true;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // SaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 530);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaleButton);
            this.Controls.Add(this.SalesInvoiceGrid);
            this.Controls.Add(this.ProductInfoGroup);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.UsernameTextBx);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleInvoice";
            this.Text = "R S Motor | Sale Invoice";
            this.Load += new System.EventHandler(this.SaleInvoice_Load);
            this.ProductInfoGroup.ResumeLayout(false);
            this.ProductInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesInvoiceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextBx;
        private MetroFramework.Controls.MetroLabel SearchLabel;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroLabel DateLabel;
        private MetroFramework.Controls.MetroTextBox DateTextBox;
        private MetroFramework.Controls.MetroLabel PriceLabel;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private MetroFramework.Controls.MetroLabel ProductIDLabel;
        private MetroFramework.Controls.MetroTextBox PIDTextBox;
        private MetroFramework.Controls.MetroLabel ProductNameLabel;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroTextBox StockTextBox;
        private MetroFramework.Controls.MetroLabel StockLabel;
        private MetroFramework.Controls.MetroLabel TotalTextLabel;
        private MetroFramework.Controls.MetroTextBox TotalTextBox;
        private System.Windows.Forms.GroupBox ProductInfoGroup;
        private MetroFramework.Controls.MetroGrid SalesInvoiceGrid;
        private MetroFramework.Controls.MetroButton SaleButton;
        private MetroFramework.Controls.MetroButton ExitButton;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Drawing.Printing.PrintDocument PrintReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}