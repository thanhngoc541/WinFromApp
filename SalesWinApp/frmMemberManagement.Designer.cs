
namespace SalesWinApp
{
    partial class frmMemberManagement
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.seaID = new System.Windows.Forms.TextBox();
            this.seaName = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(566, 151);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(221, 27);
            this.txtCountry.TabIndex = 23;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(566, 96);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(221, 27);
            this.txtCity.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 151);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(221, 27);
            this.txtEmail.TabIndex = 20;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(211, 96);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(221, 27);
            this.txtCompanyName.TabIndex = 19;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(211, 33);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(221, 27);
            this.txtMemberId.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Company Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Member ID";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(41, 293);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(803, 280);
            this.dgvMemberList.TabIndex = 24;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentClick);
            this.dgvMemberList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMemberList_CellFormatting);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(211, 204);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 31);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(385, 204);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 31);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(566, 204);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 31);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(566, 33);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(221, 27);
            this.txtPassword.TabIndex = 29;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(473, 40);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(41, 257);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 20);
            this.lbSearch.TabIndex = 30;
            this.lbSearch.Text = "Search";
            // 
            // seaID
            // 
            this.seaID.Location = new System.Drawing.Point(100, 254);
            this.seaID.Name = "seaID";
            this.seaID.PlaceholderText = "ID";
            this.seaID.Size = new System.Drawing.Size(120, 27);
            this.seaID.TabIndex = 31;
            this.seaID.TextChanged += new System.EventHandler(this.searching);
            // 
            // seaName
            // 
            this.seaName.Location = new System.Drawing.Point(226, 254);
            this.seaName.Name = "seaName";
            this.seaName.PlaceholderText = "Company Name";
            this.seaName.Size = new System.Drawing.Size(123, 27);
            this.seaName.TabIndex = 32;
            this.seaName.TextChanged += new System.EventHandler(this.searching);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(591, 254);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(123, 28);
            this.cbCity.TabIndex = 33;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.filtering);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(720, 254);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(123, 28);
            this.cbCountry.TabIndex = 34;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.filtering);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(540, 262);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(42, 20);
            this.lbFilter.TabIndex = 35;
            this.lbFilter.Text = "Filter";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 615);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.seaName);
            this.Controls.Add(this.seaID);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Managerment";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox seaID;
        private System.Windows.Forms.TextBox seaName;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lbFilter;
    }
}