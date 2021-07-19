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
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = MemberRepository.Instance;
        //creating a new data source
        public string managerID { get; set; }
        BindingSource source;
        private List<Member> members;
        //-----------------------------------
        public frmMemberManagement()
        {
            InitializeComponent();
            members = (List<Member>)memberRepository.GetMembers();
            seaID.Text = "";
            seaName.Text = "";
         
            LoadMemberList(null);
            setfilter();
        }
        private void setfilter()
        {
            members = (List<Member>)memberRepository.GetMembers();
            HashSet<string> citys = new HashSet<string>();
            HashSet<string> countries = new HashSet<string>();
            cbCity.Items.Clear();
            cbCity.Items.Add("All city");
            cbCountry.Items.Clear();
            cbCountry.Items.Add("All country");
            foreach (Member member in members) { citys.Add(member.City); countries.Add(member.Country); }
            foreach (string city in citys) cbCity.Items.Add(city);
            foreach (string country in countries) cbCountry.Items.Add(country);
            LoadMemberList(null);
        }
        //-----------------------------------
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
            // Register this event to open the frmMemberDetail from that performs updating
            dgvMemberList.CellDoubleClick += dvgMemberList_DoubleClick;

        }
        private void dvgMemberList_DoubleClick(object sender, EventArgs e)
        {
            Member temp = GetMemberObject();
            if (managerID.Equals("admin") || managerID.Equals(temp.MemberId.ToString()))
            {
                frmMemberDetails frmMemberDetail = new frmMemberDetails
                {
                    Text = "Update Member",
                    InsertOrUpdate = true,
                    member = GetMemberObject(),
                    MemberRepository = memberRepository
                };
                if (frmMemberDetail.ShowDialog() == DialogResult.OK)
                {
                    setfilter();
                   
                    //set focus on updated member
                    source.Position = source.Count - 1;
                }
            }
            else MessageBox.Show("You are only allowed to update your infomation, please login as admin to use this feature.");
        }
        //------------------------------------
        //Used to get Member Object from the text boxes data
        private void clearText()
        {
            txtMemberId.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
        }
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "get Member");
            }
            return member;
        }
  
        private void LoadMemberList(List<Member> Members)
        {
            if (Members == null) Members = members;
            Members.Sort(delegate (Member m1, Member m2) { return m1.MemberId.CompareTo(m2.MemberId); });
            try
            {
                //The Binding Source Component is designed to simplify
                //The process of binding control to an underlying data source
                source = new BindingSource();
                source.DataSource = Members;

                //clear the text boxes
                txtMemberId.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtEmail.DataBindings.Clear(); 
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear(); 
                txtCountry.DataBindings.Clear();

                //re-bind the databind
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
       
                
                if (members.Count() == 0)
                {
                    clearText();
                    BtnDelete.Enabled = false;
                }
                else
                {
                    BtnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }
        //------------------------------------
        //when the user clicks on Delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (managerID.Equals("admin"))
            {
                try
                {
                    var member = GetMemberObject();
                    memberRepository.DeleteMember(member.MemberId);
                    setfilter();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a member");
                }
            } else  MessageBox.Show("Please login as admin to use this feature.");
        }
        //------------------------------------
        //when the user clicks on New
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (managerID.Equals("admin"))
            {
                frmMemberDetails frmMemberDetails = new frmMemberDetails
                {
                    Text = "Add Member",
                    InsertOrUpdate = false,
                    MemberRepository = memberRepository
                };
                if (frmMemberDetails.ShowDialog() == DialogResult.OK)
                {
                    setfilter();
                
                    //set focus on new member
                    source.Position = source.Count - 1;
                }
            }
            else MessageBox.Show("Please login as admin to use this feature.");
        }
        //------------------------------------
        //when the user clicks on Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            members = (List<Member>)memberRepository.GetMembers();
            seaID.Text = "";
            seaName.Text = "";
            cbCity.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
            LoadMemberList(null);
        }

        private void searching(object sender, EventArgs e)
        {
            members = (List<Member>)memberRepository.GetMembers();
            List<Member> lst = new List<Member>();
            foreach (Member member in members)
            {
                if ((seaID.Text == string.Empty||member.MemberId.ToString().ToLower().StartsWith(seaID.Text.ToLower()))&&
                    (seaName.Text == string.Empty || member.CompanyName.ToString().ToLower().StartsWith(seaName.Text.ToLower()))) lst.Add(member);
            }
            members = lst;
            filtering(sender,e);
        }
        private void filtering(object sender, EventArgs e)
        {
            List<Member> lst = new List<Member>();
            if (cbCity.SelectedIndex ==0)
            { 
                lst = members;
            } 
            else
            {
                foreach (Member member in members) if (member.City.Equals(cbCity.Text)) lst.Add(member);
             
            }
            List<Member> lst2 = new List<Member>();
            if (cbCountry.SelectedIndex == 0)
            {
                
                lst2 = lst;
            }
            else
            {
                foreach (Member member in lst) if (member.Country.Equals(cbCountry.Text)) lst2.Add(member);
  
            }
            if (cbCity.SelectedIndex == 0 && cbCountry.SelectedIndex == 0) LoadMemberList(null); else
            LoadMemberList(lst2);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        

        private void dgvMemberList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2&&e.Value!=null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
