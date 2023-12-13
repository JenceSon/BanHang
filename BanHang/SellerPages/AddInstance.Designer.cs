namespace BanHang.SellerPages
{
    partial class AddInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInstance));
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            PriceTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(27, 43);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(161, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Location = new Point(80, 169);
            button1.Name = "button1";
            button1.Size = new Size(42, 27);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 2;
            label1.Text = "Fill the number of instances";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 89);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 3;
            label2.Text = "Fill the price of instances";
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(27, 121);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(161, 27);
            PriceTxt.TabIndex = 4;
            PriceTxt.Text = "0";
            PriceTxt.TextAlign = HorizontalAlignment.Center;
            PriceTxt.KeyPress += PriceTextBox_KeyPress;
            // 
            // AddInstance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 208);
            Controls.Add(PriceTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddInstance";
            Text = "AddInstance";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox PriceTxt;
    }
}