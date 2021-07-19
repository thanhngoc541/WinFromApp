
namespace SalesWinApp
{
    partial class frmProductManagement
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
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.numericAddToCart = new System.Windows.Forms.NumericUpDown();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lbCreateOrder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.lbid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddToCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Location = new System.Drawing.Point(29, 85);
            this.ProductGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductGrid.MultiSelect = false;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.RowHeadersWidth = 51;
            this.ProductGrid.RowTemplate.Height = 25;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.Size = new System.Drawing.Size(746, 371);
            this.ProductGrid.TabIndex = 0;
            this.ProductGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGrid_CellContentClick);
            this.ProductGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductForm_DataBindingComplete);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 33);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(688, 33);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(389, 470);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(114, 31);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // numericAddToCart
            // 
            this.numericAddToCart.Location = new System.Drawing.Point(510, 473);
            this.numericAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericAddToCart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericAddToCart.Name = "numericAddToCart";
            this.numericAddToCart.Size = new System.Drawing.Size(73, 27);
            this.numericAddToCart.TabIndex = 4;
            this.numericAddToCart.ValueChanged += new System.EventHandler(this.numericAddToCart_ValueChanged);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(611, 470);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(102, 31);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "Buy";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lbCreateOrder
            // 
            this.lbCreateOrder.AutoSize = true;
            this.lbCreateOrder.Location = new System.Drawing.Point(720, 476);
            this.lbCreateOrder.Name = "lbCreateOrder";
            this.lbCreateOrder.Size = new System.Drawing.Size(67, 20);
            this.lbCreateOrder.TabIndex = 6;
            this.lbCreateOrder.Text = "(0 items)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "ProductName";
            this.textBox1.Size = new System.Drawing.Size(102, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(288, 33);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(99, 27);
            this.numericID.TabIndex = 11;
            this.numericID.Tag = "";
            this.numericID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericID.ValueChanged += new System.EventHandler(this.numericID_ValueChanged);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(203, 39);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(79, 20);
            this.lbid.TabIndex = 12;
            this.lbid.Text = "Product ID";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 520);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCreateOrder);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.numericAddToCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ProductGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductManagement";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddToCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown numericAddToCart;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lbCreateOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.Label lbid;
    }
}