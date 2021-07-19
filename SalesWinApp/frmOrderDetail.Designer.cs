
namespace SalesWinApp
{
    partial class frmOrderDetail
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
            this.lbOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.OrderDetailGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(14, 12);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(66, 20);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID";
            this.lbOrderId.Click += new System.EventHandler(this.lbOrderId_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(97, 6);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(114, 27);
            this.txtOrderId.TabIndex = 1;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(14, 50);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(84, 20);
            this.lbMemberId.TabIndex = 2;
            this.lbMemberId.Text = "Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(97, 45);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(114, 27);
            this.txtMemberId.TabIndex = 3;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(14, 86);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 4;
            this.lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(97, 83);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(114, 27);
            this.txtFreight.TabIndex = 5;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(226, 9);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 6;
            this.lbOrderDate.Text = "Order Date";
            this.lbOrderDate.Click += new System.EventHandler(this.lbOrderDate_Click);
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(226, 50);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 7;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(341, 8);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(183, 27);
            this.txtOrderDate.TabIndex = 8;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(341, 47);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(183, 27);
            this.txtRequiredDate.TabIndex = 9;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(341, 85);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(183, 27);
            this.txtShippedDate.TabIndex = 10;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(226, 89);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 11;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // OrderDetailGrid
            // 
            this.OrderDetailGrid.AllowUserToAddRows = false;
            this.OrderDetailGrid.AllowUserToDeleteRows = false;
            this.OrderDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailGrid.Enabled = false;
            this.OrderDetailGrid.Location = new System.Drawing.Point(14, 124);
            this.OrderDetailGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderDetailGrid.MultiSelect = false;
            this.OrderDetailGrid.Name = "OrderDetailGrid";
            this.OrderDetailGrid.ReadOnly = true;
            this.OrderDetailGrid.RowHeadersVisible = false;
            this.OrderDetailGrid.RowHeadersWidth = 51;
            this.OrderDetailGrid.RowTemplate.Height = 25;
            this.OrderDetailGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDetailGrid.Size = new System.Drawing.Size(511, 238);
            this.OrderDetailGrid.TabIndex = 12;
            this.OrderDetailGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrderDetailGrid_DataBindingComplete);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 375);
            this.Controls.Add(this.OrderDetailGrid);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lbOrderId);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrderDetail";
            this.Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.DataGridView OrderDetailGrid;
    }
}