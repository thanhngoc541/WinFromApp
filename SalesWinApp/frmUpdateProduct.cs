using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmUpdateProduct : Form
    {
        public Product product { get; set; }
        public frmUpdateProduct()
        {
            InitializeComponent();
        }

     

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Text = product.ProductName;
            txtWeight.Text = product.Weight;
            numericCategoryId.Value = product.CategoryId;
            numericUnitPrice.Value = product.UnitPrice;
            numericUnitInStock.Value = product.UnitInStock;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = new Product()
                {
                    ProductId = product.ProductId,
                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32(numericCategoryId.Value),
                    Weight = txtWeight.Text,
                    UnitPrice = numericUnitPrice.Value,
                    UnitInStock = Convert.ToInt32(numericUnitInStock.Value)
                };
                //create repo for add
                var productRepo = new ProductRepository();
                productRepo.Update(newProduct);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericCategoryId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
