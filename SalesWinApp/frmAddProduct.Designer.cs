
namespace SalesWinApp
{
    partial class frmAddProduct
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.numericCategoryId = new System.Windows.Forms.NumericUpDown();
            this.numericUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericUnitPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(124, 17);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 27);
            this.txtProductName.TabIndex = 0;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(124, 94);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(196, 27);
            this.txtWeight.TabIndex = 2;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(14, 20);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 17;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(14, 58);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryId.TabIndex = 16;
            this.lbCategoryId.Text = "Category ID";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(14, 96);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 15;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(14, 135);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 14;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(14, 174);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(92, 20);
            this.lbUnitInStock.TabIndex = 13;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // numericCategoryId
            // 
            this.numericCategoryId.Location = new System.Drawing.Point(124, 57);
            this.numericCategoryId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericCategoryId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericCategoryId.Name = "numericCategoryId";
            this.numericCategoryId.Size = new System.Drawing.Size(196, 27);
            this.numericCategoryId.TabIndex = 1;
            // 
            // numericUnitInStock
            // 
            this.numericUnitInStock.Location = new System.Drawing.Point(124, 173);
            this.numericUnitInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUnitInStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUnitInStock.Name = "numericUnitInStock";
            this.numericUnitInStock.Size = new System.Drawing.Size(196, 27);
            this.numericUnitInStock.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numericUnitPrice
            // 
            this.numericUnitPrice.DecimalPlaces = 2;
            this.numericUnitPrice.Location = new System.Drawing.Point(124, 134);
            this.numericUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUnitPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUnitPrice.Name = "numericUnitPrice";
            this.numericUnitPrice.Size = new System.Drawing.Size(196, 27);
            this.numericUnitPrice.TabIndex = 3;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 248);
            this.Controls.Add(this.numericUnitPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUnitInStock);
            this.Controls.Add(this.numericCategoryId);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbCategoryId);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.NumericUpDown numericCategoryId;
        private System.Windows.Forms.NumericUpDown numericUnitInStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUnitPrice;
    }
}