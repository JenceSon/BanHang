namespace BanHang.SellerPages
{
    partial class AddProduct
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
            panel3 = new Panel();
            ImgNameLabel = new Label();
            AddImgBtn = new Button();
            panel4 = new Panel();
            ImgPictureBox = new PictureBox();
            ResetButton = new Button();
            SaveButton = new Button();
            panel2 = new Panel();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            label4 = new Label();
            panel1 = new Panel();
            generateID = new PictureBox();
            PID = new TextBox();
            label1 = new Label();
            label3 = new Label();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            ProductNameTextBox = new TextBox();
            NameLabel = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgPictureBox).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generateID).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(ImgNameLabel);
            panel3.Controls.Add(AddImgBtn);
            panel3.Location = new Point(508, 313);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 302);
            panel3.TabIndex = 14;
            // 
            // ImgNameLabel
            // 
            ImgNameLabel.AutoSize = true;
            ImgNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            ImgNameLabel.Location = new Point(50, 96);
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
            AddImgBtn.Location = new Point(39, 26);
            AddImgBtn.Name = "AddImgBtn";
            AddImgBtn.Size = new Size(93, 29);
            AddImgBtn.TabIndex = 10;
            AddImgBtn.Text = "Add Image";
            AddImgBtn.UseVisualStyleBackColor = false;
            AddImgBtn.Click += AddImgBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(ImgPictureBox);
            panel4.Location = new Point(691, 312);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 300);
            panel4.TabIndex = 11;
            // 
            // ImgPictureBox
            // 
            ImgPictureBox.Location = new Point(0, 0);
            ImgPictureBox.Name = "ImgPictureBox";
            ImgPictureBox.Size = new Size(300, 300);
            ImgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgPictureBox.TabIndex = 0;
            ImgPictureBox.TabStop = false;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.White;
            ResetButton.FlatStyle = FlatStyle.Popup;
            ResetButton.ForeColor = Color.Black;
            ResetButton.Location = new Point(837, 13);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(81, 29);
            ResetButton.TabIndex = 13;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.OrangeRed;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(924, 13);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(81, 29);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(AmountTextBox);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(PriceTextBox);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(15, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 307);
            panel2.TabIndex = 11;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(125, 135);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(174, 27);
            AmountTextBox.TabIndex = 11;
            AmountTextBox.Text = "0";
            AmountTextBox.KeyPress += AmountTextBox_KeyPress;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(15, 138);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(62, 20);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Amount";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(125, 93);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(174, 27);
            PriceTextBox.TabIndex = 9;
            PriceTextBox.Text = "0";
            PriceTextBox.KeyPress += PriceTextBox_KeyPress;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(15, 96);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(41, 20);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Price";
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(generateID);
            panel1.Controls.Add(PID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(ProductNameTextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(15, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 259);
            panel1.TabIndex = 10;
            // 
            // generateID
            // 
            generateID.Image = Properties.Resources.automatic;
            generateID.Location = new Point(945, 53);
            generateID.Name = "generateID";
            generateID.Size = new Size(31, 28);
            generateID.SizeMode = PictureBoxSizeMode.StretchImage;
            generateID.TabIndex = 9;
            generateID.TabStop = false;
            generateID.Click += generateID_Click;
            // 
            // PID
            // 
            PID.Location = new Point(716, 53);
            PID.Name = "PID";
            PID.ReadOnly = true;
            PID.Size = new Size(202, 27);
            PID.TabIndex = 8;
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
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 633);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(ResetButton);
            Controls.Add(SaveButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddProduct";
            Text = "AddProduct";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImgPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)generateID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label ImgNameLabel;
        private Panel panel4;
        private Button AddImgBtn;
        private Button ResetButton;
        private Button SaveButton;
        private Panel panel2;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private Label label4;
        private Panel panel1;
        private PictureBox generateID;
        private TextBox PID;
        private Label label1;
        private Label label3;
        private TextBox DescriptionTextBox;
        private Label label2;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private TextBox ProductNameTextBox;
        private Label NameLabel;
        private PictureBox ImgPictureBox;
    }
}