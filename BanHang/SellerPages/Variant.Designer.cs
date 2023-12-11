namespace BanHang.SellerPages
{
    partial class Variant
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
            panel2 = new Panel();
            DelBtn = new Button();
            ModifyBtn = new Button();
            AddVariantBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 649);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(DelBtn);
            panel2.Controls.Add(ModifyBtn);
            panel2.Controls.Add(AddVariantBtn);
            panel2.Location = new Point(17, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 56);
            panel2.TabIndex = 15;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.OrangeRed;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(712, 11);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(113, 29);
            DelBtn.TabIndex = 12;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            // 
            // ModifyBtn
            // 
            ModifyBtn.BackColor = Color.OrangeRed;
            ModifyBtn.FlatStyle = FlatStyle.Popup;
            ModifyBtn.ForeColor = Color.White;
            ModifyBtn.Location = new Point(844, 11);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(113, 29);
            ModifyBtn.TabIndex = 10;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = false;
            // 
            // AddVariantBtn
            // 
            AddVariantBtn.BackColor = Color.OrangeRed;
            AddVariantBtn.FlatStyle = FlatStyle.Popup;
            AddVariantBtn.ForeColor = Color.White;
            AddVariantBtn.Location = new Point(576, 11);
            AddVariantBtn.Name = "AddVariantBtn";
            AddVariantBtn.Size = new Size(113, 29);
            AddVariantBtn.TabIndex = 6;
            AddVariantBtn.Text = "Add Variant";
            AddVariantBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 558);
            dataGridView1.TabIndex = 16;
            // 
            // Variant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 644);
            Controls.Add(panel1);
            Name = "Variant";
            Text = "Variant";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button DelBtn;
        private Button ModifyBtn;
        private Button AddVariantBtn;
    }
}