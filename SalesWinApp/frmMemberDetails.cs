using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    using BusinessObject;
    using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        //----------------------------
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //False: Insert |True: Update
        public Member member { get; set; }
        //----------------------------
        private void frmMemberDetails_Load(Object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            if (InsertOrUpdate == true)
            {
               
                txtMemberId.Text = member.MemberId.ToString();
                txtCompanyName.Text = member.CompanyName.ToString();
                txtEmail.Text = member.Email.ToString();
                txtPassword.Text = member.Password.ToString();
                txtCity.Text = member.City.ToString();
                txtCountry.Text = member.Country.ToString();

            }
        }//end of frmMemberDetails_Load
        //----------------------------

        private void bntSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text == string.Empty) throw new Exception("Invalid CompanyName");
                if (new EmailAddressAttribute().IsValid(txtEmail.Text)==false) throw new Exception("Invalid Email");
                if (txtPassword.Text == string.Empty || txtPassword.Text.Length < 6) throw new Exception("Invalid Password");
                if (txtCity.Text == string.Empty || txtCountry.Text == string.Empty) throw new Exception("Invalid Location");

                
                
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(new Member
                    {
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        CompanyName = txtCompanyName.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                });
                }
                else
                {
                    MemberRepository.UpdateMember(new Member
                    {
                        MemberId = int.Parse(txtMemberId.Text),
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        CompanyName = txtCompanyName.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        //end save click

    }
}
