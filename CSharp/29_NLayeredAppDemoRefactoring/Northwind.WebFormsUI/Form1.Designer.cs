namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            gbxCategory = new GroupBox();
            gbxProductName = new GroupBox();
            lblCategory = new Label();
            lblProductName = new Label();
            cbxCategory = new ComboBox();
            tbxProductName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            gbxCategory.SuspendLayout();
            gbxProductName.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(35, 249);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(705, 150);
            dgvProducts.TabIndex = 0;
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(35, 23);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(705, 100);
            gbxCategory.TabIndex = 1;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // gbxProductName
            // 
            gbxProductName.Controls.Add(tbxProductName);
            gbxProductName.Controls.Add(lblProductName);
            gbxProductName.Location = new Point(35, 129);
            gbxProductName.Name = "gbxProductName";
            gbxProductName.Size = new Size(705, 100);
            gbxProductName.TabIndex = 2;
            gbxProductName.TabStop = false;
            gbxProductName.Text = "Ürün İsmine Göre Listele";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(37, 46);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategori:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(37, 49);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(45, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Search:";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(112, 43);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(236, 23);
            cbxCategory.TabIndex = 1;
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(112, 46);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(236, 23);
            tbxProductName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxProductName);
            Controls.Add(gbxCategory);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxProductName.ResumeLayout(false);
            gbxProductName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxProductName;
        private Label lblProductName;
        private TextBox tbxProductName;
    }
}
