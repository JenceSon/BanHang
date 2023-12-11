namespace BanHang.SellerPages
{
    partial class ListProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ProductTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            TotalRemaining = new DataGridViewTextBoxColumn();
            OnSale = new DataGridViewTextBoxColumn();
            MinPrice = new DataGridViewTextBoxColumn();
            MaxPrice = new DataGridViewTextBoxColumn();
            SeeMoreBtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ProductTable);
            panel1.Controls.Add(SeeMoreBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 384);
            panel1.TabIndex = 0;
            // 
            // ProductTable
            // 
            ProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductTable.Columns.AddRange(new DataGridViewColumn[] { ID, NameProduct, TotalRemaining, OnSale, MinPrice, MaxPrice });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductTable.DefaultCellStyle = dataGridViewCellStyle1;
            ProductTable.Location = new Point(11, 53);
            ProductTable.Name = "ProductTable";
            ProductTable.RowHeadersWidth = 51;
            ProductTable.Size = new Size(584, 328);
            ProductTable.TabIndex = 10;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 90;
            // 
            // NameProduct
            // 
            NameProduct.HeaderText = "Name";
            NameProduct.MinimumWidth = 6;
            NameProduct.Name = "NameProduct";
            NameProduct.Width = 120;
            // 
            // TotalRemaining
            // 
            TotalRemaining.HeaderText = "In stock";
            TotalRemaining.MinimumWidth = 6;
            TotalRemaining.Name = "TotalRemaining";
            TotalRemaining.Width = 60;
            // 
            // OnSale
            // 
            OnSale.HeaderText = "On Sale";
            OnSale.MinimumWidth = 6;
            OnSale.Name = "OnSale";
            OnSale.Width = 60;
            // 
            // MinPrice
            // 
            MinPrice.HeaderText = "Minimum price";
            MinPrice.MinimumWidth = 6;
            MinPrice.Name = "MinPrice";
            MinPrice.Width = 101;
            // 
            // MaxPrice
            // 
            MaxPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaxPrice.HeaderText = "Maximum Price";
            MaxPrice.MinimumWidth = 6;
            MaxPrice.Name = "MaxPrice";
            // 
            // SeeMoreBtn
            // 
            SeeMoreBtn.BackColor = Color.OrangeRed;
            SeeMoreBtn.FlatStyle = FlatStyle.Popup;
            SeeMoreBtn.ForeColor = Color.White;
            SeeMoreBtn.Location = new Point(497, 10);
            SeeMoreBtn.Name = "SeeMoreBtn";
            SeeMoreBtn.Size = new Size(98, 29);
            SeeMoreBtn.TabIndex = 9;
            SeeMoreBtn.Text = "See more...";
            SeeMoreBtn.UseVisualStyleBackColor = false;
            SeeMoreBtn.Click += SeeMoreBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 8;
            label1.Text = "Product";
            // 
            // ListProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ListProducts";
            Size = new Size(598, 384);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SeeMoreBtn;
        private Label label1;
        private DataGridView ProductTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn TotalRemaining;
        private DataGridViewTextBoxColumn OnSale;
        private DataGridViewTextBoxColumn MinPrice;
        private DataGridViewTextBoxColumn MaxPrice;
    }
}
