using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty) { MessageBox.Show("Email must not be empty!"); return; }
            if (txtPassword.Text == string.Empty) { MessageBox.Show("Password must not be empty!"); return; }
           
            Member member = MemberRepository.Instance.GetMemberByEmail(txtEmail.Text);
            if (member == null) { MessageBox.Show("Account does not exist!"); return; }
            if (member.Login(txtPassword.Text))
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.managerID = member.Email.Equals("admin@fstore.com")?"admin":member.MemberId.ToString();
                frmMain.Show();
            }
            else MessageBox.Show("Wrong Password");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
