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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = new Product()
                {

                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32(numericCategoryId.Value),
                    Weight = txtWeight.Text,
                    UnitPrice = numericUnitPrice.Value,
                    UnitInStock = Convert.ToInt32(numericUnitInStock.Value)
                };
                //create repo for add
                var productRepo = new ProductRepository();
                productRepo.Add(newProduct);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
