namespace BanHang.SellerPages
{
    partial class ModifyProduct
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
            panel1 = new Panel();
            generateID = new PictureBox();
            PidTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            ProductNameTextBox = new TextBox();
            NameLabel = new Label();
            ResetButton = new Button();
            SaveButton = new Button();
            panel2 = new Panel();
            addInstanceBtn = new Button();
            OnSaleLabel = new Label();
            label8 = new Label();
            MinPriceTextBox = new TextBox();
            label5 = new Label();
            TotalRemainTextBox = new TextBox();
            AmountLabel = new Label();
            MaxPriceTextBox = new TextBox();
            PriceLabel = new Label();
            label4 = new Label();
            panel3 = new Panel();
            ImagePB = new PictureBox();
            ImgNameLabel = new Label();
            AddImgBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generateID).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagePB).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(generateID);
            panel1.Controls.Add(PidTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(ProductNameTextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 259);
            panel1.TabIndex = 11;
            // 
            // generateID
            // 
            generateID.Image = Properties.Resources.automatic;
            generateID.Location = new Point(945, 53);
            generateID.Name = "generateID";
            generateID.Size = new Size(31, 28);
            generateID.SizeMode = PictureBoxSizeMode.StretchImage;
            generateID.TabIndex = 10;
            generateID.TabStop = false;
            generateID.Click += generateID_Click;
            // 
            // PidTextBox
            // 
            PidTextBox.Location = new Point(716, 53);
            PidTextBox.Name = "PidTextBox";
            PidTextBox.Size = new Size(202, 27);
            PidTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 12);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 6;
            label3.Text = "Basic Infomation";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(125, 94);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(851, 149);
            DescriptionTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 97);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(408, 52);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(217, 28);
            CategoryComboBox.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(333, 55);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(125, 52);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(202, 27);
            ProductNameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(104, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Product Name";
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.White;
            ResetButton.FlatStyle = FlatStyle.Popup;
            ResetButton.ForeColor = Color.Black;
            ResetButton.Location = new Point(836, 11);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(81, 29);
            ResetButton.TabIndex = 15;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.OrangeRed;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(923, 11);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(81, 29);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addInstanceBtn);
            panel2.Controls.Add(OnSaleLabel);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(MinPriceTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TotalRemainTextBox);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(MaxPriceTextBox);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 307);
            panel2.TabIndex = 16;
            // 
            // addInstanceBtn
            // 
            addInstanceBtn.BackColor = Color.White;
            addInstanceBtn.FlatStyle = FlatStyle.Popup;
            addInstanceBtn.ForeColor = Color.Black;
            addInstanceBtn.Location = new Point(222, 178);
            addInstanceBtn.Name = "addInstanceBtn";
            addInstanceBtn.Size = new Size(114, 29);
            addInstanceBtn.TabIndex = 15;
            addInstanceBtn.Text = "Add Instance";
            addInstanceBtn.UseVisualStyleBackColor = false;
            // 
            // OnSaleLabel
            // 
            OnSaleLabel.AutoSize = true;
            OnSaleLabel.Location = new Point(162, 182);
            OnSaleLabel.Name = "OnSaleLabel";
            OnSaleLabel.Size = new Size(17, 20);
            OnSaleLabel.TabIndex = 17;
            OnSaleLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 182);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 15;
            label8.Text = "On Sale";
            // 
            // MinPriceTextBox
            // 
            MinPriceTextBox.Location = new Point(162, 45);
            MinPriceTextBox.Name = "MinPriceTextBox";
            MinPriceTextBox.Size = new Size(174, 27);
            MinPriceTextBox.TabIndex = 13;
            MinPriceTextBox.KeyPress += PriceTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 48);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 12;
            label5.Text = "Minimum price";
            // 
            // TotalRemainTextBox
            // 
            TotalRemainTextBox.Location = new Point(162, 135);
            TotalRemainTextBox.Name = "TotalRemainTextBox";
            TotalRemainTextBox.Size = new Size(174, 27);
            TotalRemainTextBox.TabIndex = 11;
            TotalRemainTextBox.KeyPress += AmountTextBox_KeyPress;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(15, 138);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(61, 20);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "In Stock";
            // 
            // MaxPriceTextBox
            // 
            MaxPriceTextBox.Location = new Point(162, 93);
            MaxPriceTextBox.Name = "MaxPriceTextBox";
            MaxPriceTextBox.Size = new Size(174, 27);
            MaxPriceTextBox.TabIndex = 9;
            MaxPriceTextBox.KeyPress += PriceTextBox_KeyPress;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(15, 96);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(112, 20);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Maximum price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(15, 12);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 6;
            label4.Text = "Sales Infomation";
            // 
            // panel3
            // 
            panel3.Controls.Add(ImagePB);
            panel3.Controls.Add(ImgNameLabel);
            panel3.Controls.Add(AddImgBtn);
            panel3.Location = new Point(506, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 307);
            panel3.TabIndex = 17;
            // 
            // ImagePB
            // 
            ImagePB.Location = new Point(184, 3);
            ImagePB.Name = "ImagePB";
            ImagePB.Size = new Size(250, 300);
            ImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagePB.TabIndex = 14;
            ImagePB.TabStop = false;
            // 
            // ImgNameLabel
            // 
            ImgNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImgNameLabel.AutoSize = true;
            ImgNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            ImgNameLabel.Location = new Point(17, 68);
            ImgNameLabel.Name = "ImgNameLabel";
            ImgNameLabel.Size = new Size(70, 20);
            ImgNameLabel.TabIndex = 13;
            ImgNameLabel.Text = "not found";
            ImgNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddImgBtn
            // 
            AddImgBtn.BackColor = Color.White;
            AddImgBtn.FlatStyle = FlatStyle.Popup;
            AddImgBtn.ForeColor = Color.Black;
            AddImgBtn.Location = new Point(17, 11);
            AddImgBtn.Name = "AddImgBtn";
            AddImgBtn.Size = new Size(93, 29);
            AddImgBtn.TabIndex = 10;
            AddImgBtn.Text = "Add Image";
            AddImgBtn.UseVisualStyleBackColor = false;
            AddImgBtn.Click += AddImgBtn_Click;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 633);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(ResetButton);
            Controls.Add(SaveButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)generateID).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox generateID;
        private TextBox PidTextBox;
        private Label label1;
        private Label label3;
        private TextBox DescriptionTextBox;
        private Label label2;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private TextBox ProductNameTextBox;
        private Label NameLabel;
        private Button ResetButton;
        private Button SaveButton;
        private Panel panel2;
        private Button addInstanceBtn;
        private Label OnSaleLabel;
        private Label label8;
        private TextBox MinPriceTextBox;
        private Label label5;
        private TextBox TotalRemainTextBox;
        private Label AmountLabel;
        private TextBox MaxPriceTextBox;
        private Label PriceLabel;
        private Label label4;
        private Panel panel3;
        private PictureBox ImagePB;
        private Label ImgNameLabel;
        private Button AddImgBtn;
    }
}