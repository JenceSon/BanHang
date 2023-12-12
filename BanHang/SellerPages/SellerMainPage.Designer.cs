namespace BanHang.SellerPages
{
    partial class SellerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerMainPage));
            panel1 = new Panel();
            RefreshPictureBox = new PictureBox();
            label1 = new Label();
            LogoButton = new Button();
            panel2 = new Panel();
            LogoutButton = new Button();
            OverviewButton = new Button();
            FinanceButton = new Button();
            ProductsButton = new Button();
            finance = new Finance();
            listProducts = new ListProducts();
            shopInformation = new ShopInformation();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RefreshPictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RefreshPictureBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoButton);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 47);
            panel1.TabIndex = 0;
            // 
            // RefreshPictureBox
            // 
            RefreshPictureBox.Image = Properties.Resources.refresh_button;
            RefreshPictureBox.Location = new Point(754, 7);
            RefreshPictureBox.Name = "RefreshPictureBox";
            RefreshPictureBox.Size = new Size(30, 30);
            RefreshPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RefreshPictureBox.TabIndex = 4;
            RefreshPictureBox.TabStop = false;
            RefreshPictureBox.Click += RefreshPictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Bold);
            label1.Location = new Point(121, 14);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 3;
            label1.Text = "Seller Centre";
            // 
            // LogoButton
            // 
            LogoButton.BackColor = Color.White;
            LogoButton.Cursor = Cursors.Hand;
            LogoButton.FlatAppearance.BorderColor = Color.White;
            LogoButton.FlatAppearance.BorderSize = 0;
            LogoButton.FlatStyle = FlatStyle.Flat;
            LogoButton.Image = (Image)resources.GetObject("LogoButton.Image");
            LogoButton.Location = new Point(5, 7);
            LogoButton.Margin = new Padding(0);
            LogoButton.Name = "LogoButton";
            LogoButton.Size = new Size(113, 35);
            LogoButton.TabIndex = 2;
            LogoButton.TextImageRelation = TextImageRelation.ImageAboveText;
            LogoButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogoutButton);
            panel2.Controls.Add(OverviewButton);
            panel2.Controls.Add(FinanceButton);
            panel2.Controls.Add(ProductsButton);
            panel2.Location = new Point(8, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 388);
            panel2.TabIndex = 1;
            // 
            // LogoutButton
            // 
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(3, 329);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(160, 32);
            LogoutButton.TabIndex = 13;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // OverviewButton
            // 
            OverviewButton.FlatAppearance.BorderSize = 0;
            OverviewButton.FlatStyle = FlatStyle.Flat;
            OverviewButton.Location = new Point(4, 120);
            OverviewButton.Name = "OverviewButton";
            OverviewButton.Size = new Size(157, 32);
            OverviewButton.TabIndex = 12;
            OverviewButton.Text = "Shop Information";
            OverviewButton.UseVisualStyleBackColor = true;
            OverviewButton.Click += OverviewButton_Click;
            // 
            // FinanceButton
            // 
            FinanceButton.FlatAppearance.BorderSize = 0;
            FinanceButton.FlatStyle = FlatStyle.Flat;
            FinanceButton.Location = new Point(4, 82);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(157, 32);
            FinanceButton.TabIndex = 11;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            FinanceButton.Click += FinanceButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.Location = new Point(4, 44);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(157, 32);
            ProductsButton.TabIndex = 10;
            ProductsButton.Text = "My Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // finance
            // 
            finance.BackColor = Color.White;
            finance.Location = new Point(190, 56);
            finance.Name = "finance";
            finance.Size = new Size(598, 384);
            finance.TabIndex = 2;
            // 
            // listProducts
            // 
            listProducts.BackColor = Color.White;
            listProducts.Location = new Point(190, 56);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(598, 384);
            listProducts.TabIndex = 3;
            // 
            // shopInformation
            // 
            shopInformation.BackColor = Color.White;
            shopInformation.Location = new Point(190, 56);
            shopInformation.Name = "shopInformation";
            shopInformation.Size = new Size(598, 384);
            shopInformation.TabIndex = 4;
            // 
            // SellerMainPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(shopInformation);
            Controls.Add(listProducts);
            Controls.Add(finance);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SellerMainPage";
            Text = "SellerMainPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RefreshPictureBox).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button LogoButton;
        private Panel panel2;
        private Button LogoutButton;
        private Button OverviewButton;
        private Button FinanceButton;
        private Button ProductsButton;
        private Finance finance;
        private ListProducts listProducts;
        private ShopInformation shopInformation;
        private PictureBox RefreshPictureBox;
    }
}