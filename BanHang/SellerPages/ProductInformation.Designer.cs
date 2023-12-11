namespace BanHang.SellerPages
{
    partial class ProductInformation
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ListProducts = new Panel();
            filterControl = new Filter();
            panel1 = new Panel();
            FilterPB = new PictureBox();
            RefreshPB = new PictureBox();
            SeeVariantBtn = new Button();
            DelBtn = new Button();
            ModifyBtn = new Button();
            AddProductBtn = new Button();
            ProductsTable = new DataGridView();
            ImageCol = new DataGridViewImageColumn();
            IDCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            MinPriceCol = new DataGridViewTextBoxColumn();
            MaxPriceCol = new DataGridViewTextBoxColumn();
            DesCol = new DataGridViewTextBoxColumn();
            NoSaleCol = new DataGridViewTextBoxColumn();
            TotalRemainingCol = new DataGridViewTextBoxColumn();
            OnSaleCol = new DataGridViewTextBoxColumn();
            CatCol = new DataGridViewTextBoxColumn();
            ListProducts.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilterPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RefreshPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // ListProducts
            // 
            ListProducts.BackColor = Color.White;
            ListProducts.Controls.Add(filterControl);
            ListProducts.Controls.Add(panel1);
            ListProducts.Controls.Add(ProductsTable);
            ListProducts.Location = new Point(12, 12);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(1634, 951);
            ListProducts.TabIndex = 5;
            // 
            // filterControl
            // 
            filterControl.Enabled = false;
            filterControl.Location = new Point(25, 59);
            filterControl.Name = "filterControl";
            filterControl.Size = new Size(327, 309);
            filterControl.TabIndex = 6;
            filterControl.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FilterPB);
            panel1.Controls.Add(RefreshPB);
            panel1.Controls.Add(SeeVariantBtn);
            panel1.Controls.Add(DelBtn);
            panel1.Controls.Add(ModifyBtn);
            panel1.Controls.Add(AddProductBtn);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 56);
            panel1.TabIndex = 14;
            // 
            // FilterPB
            // 
            FilterPB.Image = Properties.Resources._1608702_filter_icon;
            FilterPB.Location = new Point(14, 12);
            FilterPB.Name = "FilterPB";
            FilterPB.Size = new Size(30, 30);
            FilterPB.SizeMode = PictureBoxSizeMode.StretchImage;
            FilterPB.TabIndex = 15;
            FilterPB.TabStop = false;
            FilterPB.Click += FilterPB_Click;
            // 
            // RefreshPB
            // 
            RefreshPB.Image = Properties.Resources.refresh_button;
            RefreshPB.Location = new Point(68, 11);
            RefreshPB.Name = "RefreshPB";
            RefreshPB.Size = new Size(30, 30);
            RefreshPB.SizeMode = PictureBoxSizeMode.StretchImage;
            RefreshPB.TabIndex = 14;
            RefreshPB.TabStop = false;
            RefreshPB.Click += RefreshPB_Click;
            // 
            // SeeVariantBtn
            // 
            SeeVariantBtn.BackColor = Color.OrangeRed;
            SeeVariantBtn.FlatStyle = FlatStyle.Popup;
            SeeVariantBtn.ForeColor = Color.White;
            SeeVariantBtn.Location = new Point(983, 11);
            SeeVariantBtn.Name = "SeeVariantBtn";
            SeeVariantBtn.Size = new Size(113, 29);
            SeeVariantBtn.TabIndex = 13;
            SeeVariantBtn.Text = "Variants";
            SeeVariantBtn.UseVisualStyleBackColor = false;
            SeeVariantBtn.Click += SeeVariantBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.OrangeRed;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(1319, 11);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(113, 29);
            DelBtn.TabIndex = 12;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // ModifyBtn
            // 
            ModifyBtn.BackColor = Color.OrangeRed;
            ModifyBtn.FlatStyle = FlatStyle.Popup;
            ModifyBtn.ForeColor = Color.White;
            ModifyBtn.Location = new Point(1481, 11);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(113, 29);
            ModifyBtn.TabIndex = 10;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = false;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.OrangeRed;
            AddProductBtn.FlatStyle = FlatStyle.Popup;
            AddProductBtn.ForeColor = Color.White;
            AddProductBtn.Location = new Point(1158, 11);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(113, 29);
            AddProductBtn.TabIndex = 6;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ProductsTable
            // 
            ProductsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { ImageCol, IDCol, NameCol, MinPriceCol, MaxPriceCol, DesCol, NoSaleCol, TotalRemainingCol, OnSaleCol, CatCol });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductsTable.DefaultCellStyle = dataGridViewCellStyle2;
            ProductsTable.Location = new Point(11, 74);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersWidth = 51;
            ProductsTable.Size = new Size(1611, 861);
            ProductsTable.TabIndex = 7;
            // 
            // ImageCol
            // 
            ImageCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImageCol.HeaderText = "Image";
            ImageCol.MinimumWidth = 6;
            ImageCol.Name = "ImageCol";
            ImageCol.Resizable = DataGridViewTriState.True;
            ImageCol.SortMode = DataGridViewColumnSortMode.Automatic;
            ImageCol.Width = 80;
            // 
            // IDCol
            // 
            IDCol.HeaderText = "ID";
            IDCol.MinimumWidth = 6;
            IDCol.Name = "IDCol";
            IDCol.Width = 125;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Name";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.Width = 160;
            // 
            // MinPriceCol
            // 
            MinPriceCol.HeaderText = "Minimum price";
            MinPriceCol.MinimumWidth = 6;
            MinPriceCol.Name = "MinPriceCol";
            MinPriceCol.Width = 140;
            // 
            // MaxPriceCol
            // 
            MaxPriceCol.HeaderText = "Maximum price";
            MaxPriceCol.MinimumWidth = 6;
            MaxPriceCol.Name = "MaxPriceCol";
            MaxPriceCol.Width = 140;
            // 
            // DesCol
            // 
            DesCol.HeaderText = "Description";
            DesCol.MinimumWidth = 6;
            DesCol.Name = "DesCol";
            DesCol.Width = 310;
            // 
            // NoSaleCol
            // 
            NoSaleCol.HeaderText = "Number of Sales";
            NoSaleCol.MinimumWidth = 6;
            NoSaleCol.Name = "NoSaleCol";
            NoSaleCol.Width = 101;
            // 
            // TotalRemainingCol
            // 
            TotalRemainingCol.HeaderText = "In Stock";
            TotalRemainingCol.MinimumWidth = 6;
            TotalRemainingCol.Name = "TotalRemainingCol";
            TotalRemainingCol.Width = 101;
            // 
            // OnSaleCol
            // 
            OnSaleCol.HeaderText = "On sale";
            OnSaleCol.MinimumWidth = 6;
            OnSaleCol.Name = "OnSaleCol";
            OnSaleCol.Width = 101;
            // 
            // CatCol
            // 
            CatCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CatCol.HeaderText = "Category";
            CatCol.MinimumWidth = 6;
            CatCol.Name = "CatCol";
            // 
            // ProductInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 975);
            Controls.Add(ListProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductInformation";
            Text = "ProductInformation";
            ListProducts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FilterPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)RefreshPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ListProducts;
        private Panel panel1;
        private Button SeeVariantBtn;
        private Button DelBtn;
        private Button ModifyBtn;
        private Button AddProductBtn;
        private DataGridView ProductsTable;
        private PictureBox RefreshPB;
        private DataGridViewImageColumn ImageCol;
        private DataGridViewTextBoxColumn IDCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn MinPriceCol;
        private DataGridViewTextBoxColumn MaxPriceCol;
        private DataGridViewTextBoxColumn DesCol;
        private DataGridViewTextBoxColumn NoSaleCol;
        private DataGridViewTextBoxColumn TotalRemainingCol;
        private DataGridViewTextBoxColumn OnSaleCol;
        private DataGridViewTextBoxColumn CatCol;
        private PictureBox FilterPB;
        private Filter filterControl;
    }
}