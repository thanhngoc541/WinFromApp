
namespace SalesWinApp
{
    partial class frmOrderManagement
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
            this.pickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.pickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.lbTotalSale = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.lbNumberOfOrder = new System.Windows.Forms.Label();
            this.txtNumberOfOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pickerStartDate
            // 
            this.pickerStartDate.Location = new System.Drawing.Point(71, 24);
            this.pickerStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pickerStartDate.Name = "pickerStartDate";
            this.pickerStartDate.Size = new System.Drawing.Size(252, 27);
            this.pickerStartDate.TabIndex = 0;
            // 
            // pickerEndDate
            // 
            this.pickerEndDate.Location = new System.Drawing.Point(369, 24);
            this.pickerEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pickerEndDate.Name = "pickerEndDate";
            this.pickerEndDate.Size = new System.Drawing.Size(286, 27);
            this.pickerEndDate.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(678, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // OrderGrid
            // 
            this.OrderGrid.AllowUserToAddRows = false;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Location = new System.Drawing.Point(22, 68);
            this.OrderGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.RowHeadersWidth = 51;
            this.OrderGrid.RowTemplate.Height = 25;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(742, 380);
            this.OrderGrid.TabIndex = 3;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            this.OrderGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_DoubleClick);
            this.OrderGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrderForm_DataBindingComplete);
            // 
            // lbTotalSale
            // 
            this.lbTotalSale.AutoSize = true;
            this.lbTotalSale.Location = new System.Drawing.Point(22, 476);
            this.lbTotalSale.Name = "lbTotalSale";
            this.lbTotalSale.Size = new System.Drawing.Size(77, 20);
            this.lbTotalSale.TabIndex = 4;
            this.lbTotalSale.Text = "Total Sale:";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Location = new System.Drawing.Point(125, 472);
            this.txtTotalSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalSale.Size = new System.Drawing.Size(219, 27);
            this.txtTotalSale.TabIndex = 5;
            this.txtTotalSale.Text = "0.0";
            // 
            // lbNumberOfOrder
            // 
            this.lbNumberOfOrder.AutoSize = true;
            this.lbNumberOfOrder.Location = new System.Drawing.Point(387, 476);
            this.lbNumberOfOrder.Name = "lbNumberOfOrder";
            this.lbNumberOfOrder.Size = new System.Drawing.Size(130, 20);
            this.lbNumberOfOrder.TabIndex = 6;
            this.lbNumberOfOrder.Text = "Number of orders:";
            this.lbNumberOfOrder.Click += new System.EventHandler(this.lbNumberOfOrder_Click);
            // 
            // txtNumberOfOrder
            // 
            this.txtNumberOfOrder.Location = new System.Drawing.Point(538, 472);
            this.txtNumberOfOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfOrder.Name = "txtNumberOfOrder";
            this.txtNumberOfOrder.ReadOnly = true;
            this.txtNumberOfOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberOfOrder.Size = new System.Drawing.Size(223, 27);
            this.txtNumberOfOrder.TabIndex = 7;
            this.txtNumberOfOrder.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfOrder);
            this.Controls.Add(this.lbNumberOfOrder);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.lbTotalSale);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pickerEndDate);
            this.Controls.Add(this.pickerStartDate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrderManagement";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pickerStartDate;
        private System.Windows.Forms.DateTimePicker pickerEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Label lbTotalSale;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.Label lbNumberOfOrder;
        private System.Windows.Forms.TextBox txtNumberOfOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}