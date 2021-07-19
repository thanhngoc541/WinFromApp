
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string managerID { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            createMyMainMenu();
            this.Text = $"Welcome! {managerID}";
        }
        public void createMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuMember = new ToolStripMenuItem("&MemberManager");
            ToolStripMenuItem menuProduct = new ToolStripMenuItem("&ProductManager");
            ToolStripMenuItem menuOrder = new ToolStripMenuItem("&OrderManager");
            mainMenu.Items.AddRange(new ToolStripItem[] { menuMember, menuProduct, menuOrder });
            menuMember.Click += menuMember_Click;
            menuProduct.Click += menuProduct_Click;
            menuOrder.Click += menuOrder_Click;
        }
        private void menuMember_Click(object sender, EventArgs e)
        {
            frmMemberManagement memberManager = new frmMemberManagement();
            memberManager.Text = $"Welcome {managerID}";
            memberManager.MdiParent = this;
            memberManager.managerID = managerID;
            memberManager.Show();
            memberManager.BringToFront();
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            frmProductManagement productManager = new frmProductManagement();
            productManager.Text = $"Welcome {managerID}";
            productManager.MdiParent = this;
            productManager.managerID = managerID;
            productManager.Show();
            productManager.BringToFront();
        }
        private void menuOrder_Click(object sender, EventArgs e)
        {
            frmOrderManagement memberManager = new frmOrderManagement();
            memberManager.Text = $"Welcome {managerID}";
            memberManager.MdiParent = this;
            memberManager.managerID = managerID;
            memberManager.Show();
            memberManager.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
