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
            MinPriceTxt = new TextBox();
            label5 = new Label();
            MaxPriceTxt = new TextBox();
            PriceLabel = new Label();
            TotalRemainFromTxt = new TextBox();
            AmountLabel = new Label();
            TotalRemainToTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NoSalesToTxt = new TextBox();
            NoSalesFromTxt = new TextBox();
            label3 = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            label4 = new Label();
            OnSalesToTxt = new TextBox();
            OnSaleFromTxt = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // MinPriceTxt
            // 
            MinPriceTxt.Location = new Point(133, 16);
            MinPriceTxt.Name = "MinPriceTxt";
            MinPriceTxt.Size = new Size(174, 27);
            MinPriceTxt.TabIndex = 17;
            MinPriceTxt.KeyPress += Double_KeyPress;
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
            // MaxPriceTxt
            // 
            MaxPriceTxt.Location = new Point(133, 64);
            MaxPriceTxt.Name = "MaxPriceTxt";
            MaxPriceTxt.Size = new Size(174, 27);
            MaxPriceTxt.TabIndex = 15;
            MaxPriceTxt.KeyPress += Double_KeyPress;
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
            // TotalRemainFromTxt
            // 
            TotalRemainFromTxt.Location = new Point(133, 123);
            TotalRemainFromTxt.Name = "TotalRemainFromTxt";
            TotalRemainFromTxt.Size = new Size(68, 27);
            TotalRemainFromTxt.TabIndex = 19;
            TotalRemainFromTxt.KeyPress += Int_KeyPress;
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
            // TotalRemainToTxt
            // 
            TotalRemainToTxt.Location = new Point(236, 123);
            TotalRemainToTxt.Name = "TotalRemainToTxt";
            TotalRemainToTxt.Size = new Size(68, 27);
            TotalRemainToTxt.TabIndex = 20;
            TotalRemainToTxt.KeyPress += Int_KeyPress;
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
            label2.Location = new Point(207, 218);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 25;
            label2.Text = "to";
            // 
            // NoSalesToTxt
            // 
            NoSalesToTxt.Location = new Point(236, 215);
            NoSalesToTxt.Name = "NoSalesToTxt";
            NoSalesToTxt.Size = new Size(68, 27);
            NoSalesToTxt.TabIndex = 24;
            NoSalesToTxt.KeyPress += Int_KeyPress;
            // 
            // NoSalesFromTxt
            // 
            NoSalesFromTxt.Location = new Point(133, 215);
            NoSalesFromTxt.Name = "NoSalesFromTxt";
            NoSalesFromTxt.Size = new Size(68, 27);
            NoSalesFromTxt.TabIndex = 23;
            NoSalesFromTxt.KeyPress += Int_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 218);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 22;
            label3.Text = "N.o Sales from";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(90, 267);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(217, 28);
            CategoryComboBox.TabIndex = 27;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(18, 270);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 26;
            CategoryLabel.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 173);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 31;
            label4.Text = "to";
            // 
            // OnSalesToTxt
            // 
            OnSalesToTxt.Location = new Point(236, 170);
            OnSalesToTxt.Name = "OnSalesToTxt";
            OnSalesToTxt.Size = new Size(68, 27);
            OnSalesToTxt.TabIndex = 30;
            OnSalesToTxt.KeyPress += Int_KeyPress;
            // 
            // OnSaleFromTxt
            // 
            OnSaleFromTxt.Location = new Point(133, 170);
            OnSaleFromTxt.Name = "OnSaleFromTxt";
            OnSaleFromTxt.Size = new Size(68, 27);
            OnSaleFromTxt.TabIndex = 29;
            OnSaleFromTxt.KeyPress += Int_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 173);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 28;
            label6.Text = "On sale from";
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(OnSalesToTxt);
            Controls.Add(OnSaleFromTxt);
            Controls.Add(label6);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(label2);
            Controls.Add(NoSalesToTxt);
            Controls.Add(NoSalesFromTxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(TotalRemainToTxt);
            Controls.Add(TotalRemainFromTxt);
            Controls.Add(AmountLabel);
            Controls.Add(MinPriceTxt);
            Controls.Add(label5);
            Controls.Add(MaxPriceTxt);
            Controls.Add(PriceLabel);
            Name = "Filter";
            Size = new Size(331, 316);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MinPriceTxt;
        private Label label5;
        private TextBox MaxPriceTxt;
        private Label PriceLabel;
        private TextBox TotalRemainFromTxt;
        private Label AmountLabel;
        private TextBox TotalRemainToTxt;
        private Label label1;
        private Label label2;
        private TextBox NoSalesToTxt;
        private TextBox NoSalesFromTxt;
        private Label label3;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Label label4;
        private TextBox OnSalesToTxt;
        private TextBox OnSaleFromTxt;
        private Label label6;
    }
}
