
namespace SalesWinApp
{
    partial class frmUpdateProduct
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
            this.numericUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numericUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.numericCategoryId = new System.Windows.Forms.NumericUpDown();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCategoryId)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUnitPrice
            // 
            this.numericUnitPrice.DecimalPlaces = 2;
            this.numericUnitPrice.Location = new System.Drawing.Point(131, 132);
            this.numericUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUnitPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUnitPrice.Name = "numericUnitPrice";
            this.numericUnitPrice.Size = new System.Drawing.Size(196, 27);
            this.numericUnitPrice.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 206);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numericUnitInStock
            // 
            this.numericUnitInStock.Location = new System.Drawing.Point(131, 171);
            this.numericUnitInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUnitInStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUnitInStock.Name = "numericUnitInStock";
            this.numericUnitInStock.Size = new System.Drawing.Size(196, 27);
            this.numericUnitInStock.TabIndex = 22;
            // 
            // numericCategoryId
            // 
            this.numericCategoryId.Location = new System.Drawing.Point(131, 55);
            this.numericCategoryId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericCategoryId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericCategoryId.Name = "numericCategoryId";
            this.numericCategoryId.Size = new System.Drawing.Size(196, 27);
            this.numericCategoryId.TabIndex = 19;
            this.numericCategoryId.ValueChanged += new System.EventHandler(this.numericCategoryId_ValueChanged);
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(21, 172);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(92, 20);
            this.lbUnitInStock.TabIndex = 24;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(21, 133);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 25;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(21, 94);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 26;
            this.lbWeight.Text = "Weight";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(21, 56);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryId.TabIndex = 27;
            this.lbCategoryId.Text = "Category ID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(21, 18);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 28;
            this.lbProductName.Text = "Product Name";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(131, 92);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(196, 27);
            this.txtWeight.TabIndex = 20;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(131, 15);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 27);
            this.txtProductName.TabIndex = 18;
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 257);
            this.Controls.Add(this.numericUnitPrice);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numericUnitInStock);
            this.Controls.Add(this.numericCategoryId);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbCategoryId);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Name = "frmUpdateProduct";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCategoryId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUnitPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numericUnitInStock;
        private System.Windows.Forms.NumericUpDown txtCategoryId;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.NumericUpDown numericCategoryId;
    }
}