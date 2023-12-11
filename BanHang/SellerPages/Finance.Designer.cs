namespace BanHang.SellerPages
{
    partial class Finance
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
            panel2 = new Panel();
            EnddatePicker = new DateTimePicker();
            StartdatePicker = new DateTimePicker();
            SearchButton = new Button();
            EndDateLabel = new Label();
            StartDateLabel = new Label();
            panel3 = new Panel();
            TotalRevenue = new Label();
            label3 = new Label();
            ListProductRevenue = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListProductRevenue).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(EnddatePicker);
            panel2.Controls.Add(StartdatePicker);
            panel2.Controls.Add(SearchButton);
            panel2.Controls.Add(EndDateLabel);
            panel2.Controls.Add(StartDateLabel);
            panel2.Location = new Point(13, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 104);
            panel2.TabIndex = 7;
            // 
            // EnddatePicker
            // 
            EnddatePicker.Format = DateTimePickerFormat.Short;
            EnddatePicker.Location = new Point(125, 57);
            EnddatePicker.Name = "EnddatePicker";
            EnddatePicker.Size = new Size(125, 27);
            EnddatePicker.TabIndex = 6;
            // 
            // StartdatePicker
            // 
            StartdatePicker.Format = DateTimePickerFormat.Short;
            StartdatePicker.Location = new Point(125, 15);
            StartdatePicker.Name = "StartdatePicker";
            StartdatePicker.Size = new Size(125, 27);
            StartdatePicker.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.OrangeRed;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(484, 58);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(81, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(39, 62);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(73, 20);
            EndDateLabel.TabIndex = 2;
            EndDateLabel.Text = "End Date:";
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Location = new Point(33, 20);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(79, 20);
            StartDateLabel.TabIndex = 0;
            StartDateLabel.Text = "Start Date:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TotalRevenue);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(ListProductRevenue);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(13, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 267);
            panel3.TabIndex = 8;
            // 
            // TotalRevenue
            // 
            TotalRevenue.AutoSize = true;
            TotalRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TotalRevenue.Location = new Point(105, 15);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new Size(39, 28);
            TotalRevenue.TabIndex = 10;
            TotalRevenue.Text = "0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 22);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 9;
            label3.Text = "VND";
            // 
            // ListProductRevenue
            // 
            ListProductRevenue.AllowUserToAddRows = false;
            ListProductRevenue.AllowUserToDeleteRows = false;
            ListProductRevenue.AllowUserToOrderColumns = true;
            ListProductRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListProductRevenue.Columns.AddRange(new DataGridViewColumn[] { ID, NameProduct, Revenue });
            ListProductRevenue.Location = new Point(5, 46);
            ListProductRevenue.Name = "ListProductRevenue";
            ListProductRevenue.ReadOnly = true;
            ListProductRevenue.RowHeadersWidth = 51;
            ListProductRevenue.Size = new Size(560, 218);
            ListProductRevenue.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // NameProduct
            // 
            NameProduct.HeaderText = "Name";
            NameProduct.MinimumWidth = 6;
            NameProduct.Name = "NameProduct";
            NameProduct.ReadOnly = true;
            NameProduct.Width = 200;
            // 
            // Revenue
            // 
            Revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Revenue.HeaderText = "Revenue";
            Revenue.MinimumWidth = 6;
            Revenue.Name = "Revenue";
            Revenue.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(11, 22);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 1;
            label4.Text = "Total:";
            // 
            // Finance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Finance";
            Size = new Size(598, 384);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListProductRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DateTimePicker EnddatePicker;
        private DateTimePicker StartdatePicker;
        private Button SearchButton;
        private Label EndDateLabel;
        private Label StartDateLabel;
        private Panel panel3;
        private Label TotalRevenue;
        private Label label3;
        private DataGridView ListProductRevenue;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Revenue;
        private Label label4;
    }
}
