namespace BanHang.SellerPages
{
    partial class Filter
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
            textBox2 = new TextBox();
            label5 = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 19);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 16;
            label5.Text = "Minimum price";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(133, 64);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(174, 27);
            PriceTextBox.TabIndex = 15;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(18, 67);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(112, 20);
            PriceLabel.TabIndex = 14;
            PriceLabel.Text = "Maximum price";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(133, 123);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(68, 27);
            AmountTextBox.TabIndex = 19;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(18, 126);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(97, 20);
            AmountLabel.TabIndex = 18;
            AmountLabel.Text = "In Stock from";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 27);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 126);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 21;
            label1.Text = "to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 174);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 25;
            label2.Text = "to";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(236, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(68, 27);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 27);
            textBox4.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 174);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 22;
            label3.Text = "N.o Sales from";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(90, 223);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(217, 28);
            CategoryComboBox.TabIndex = 27;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(18, 226);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 26;
            CategoryLabel.Text = "Category";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.OrangeRed;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(226, 263);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(81, 29);
            SearchButton.TabIndex = 28;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(AmountTextBox);
            Controls.Add(AmountLabel);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(PriceTextBox);
            Controls.Add(PriceLabel);
            Name = "Filter";
            Size = new Size(331, 306);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label5;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Button SearchButton;
    }
}
