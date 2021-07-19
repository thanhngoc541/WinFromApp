using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProductManagement : Form
    {
        public string managerID { get; set; }
        private BindingList<Product> products;
        BindingList<Product> result;
        public frmProductManagement()
        {
            InitializeComponent();
            loadProduct("");
        }

        public void loadProduct(string  name)
        {
            products = new ProductRepository().GetAll();
            result = new BindingList<Product>() ;
            foreach (Product product in products)
                if (product.ProductName.Contains(name)) result.Add(product);
            ProductGrid.DataSource = result;
        }
        public void loadProductID(int id)
        {
            products = new ProductRepository().GetAll();
            result = new BindingList<Product>();
            foreach (Product product in products)
                if (product.ProductId==id) result.Add(product);
            ProductGrid.DataSource = result;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (managerID.Equals("admin"))
            {
                var addProductForm = new frmAddProduct();
                addProductForm.Show();
               
            }
            else
            {
                MessageBox.Show("Login as admin to use this feature");
            }
           
        }

        private Product GetCurrentProduct()
        {
            Product currentProduct = null;

            try
            {
                Int32 selectedRowCount =
                    ProductGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    currentProduct = new Product();
                    var selectedrow = ProductGrid.SelectedRows[0];
                    currentProduct.ProductId = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());
                    currentProduct.CategoryId = Convert.ToInt32(selectedrow.Cells[1].Value.ToString());
                    currentProduct.ProductName = selectedrow.Cells[2].Value.ToString();
                    currentProduct.Weight = selectedrow.Cells[3].Value.ToString();
                    currentProduct.UnitPrice = Convert.ToDecimal(selectedrow.Cells[4].Value.ToString());
                    currentProduct.UnitInStock = Convert.ToInt32(selectedrow.Cells[5].Value.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return currentProduct;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (managerID.Equals("admin"))
            {
                try
                {
                    Product currentProduct = GetCurrentProduct();
                    if (currentProduct != null)
                    {
                        new ProductRepository().Remove(currentProduct.ProductId);
                    }
                    loadProduct(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Login as admin to use this feature");
            }
        }

        private void ProductForm_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (ProductGrid.Columns["OrderDetails"] != null)
            {
                ProductGrid.Columns["OrderDetails"].Visible = false;
            } 
        }


        private IDictionary<int, int> cart = new Dictionary<int, int>();

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                return;
            }
            try {
                var orderRepository = new OrderRepository();
                var productRepository = new ProductRepository();
                var newOrder = new Order()
                {
                    MemberId = managerID.Equals("admin")?1:int.Parse(managerID),
                    OrderDate = DateTime.Now,
                    RequiredDate = DateTime.Now.AddDays(5),
                    ShippedDate = DateTime.Now.AddDays(2),
                    Freight = 54000,
                };
                orderRepository.Add(newOrder);
                foreach (var entry in cart)
                {
                    productRepository.SubstractStock(entry.Key, entry.Value);
                    var orderDetail = new OrderDetail()
                    {
                        Discount = 0,
                        OrderId = newOrder.OrderId,
                        ProductId = entry.Key,
                        Quantity = entry.Value,
                        UnitPrice = productRepository.Get(entry.Key).UnitPrice
                    };
                    var orderDetailRepository = new OrderDetailRepository();
                    orderDetailRepository.Add(orderDetail);
                }
                cart.Clear();
                loadProduct(textBox1.Text);
                lbCreateOrder.Text = "(" + cart.Count + " items)";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Product currentProduct = GetCurrentProduct();
                if (currentProduct is null) return; //user haven't selected any item
                int unitToAdd = Convert.ToInt32(numericAddToCart.Value);
                int unitInCart = (cart.ContainsKey(currentProduct.ProductId) ? cart[currentProduct.ProductId] : 0);
                if (0 < unitToAdd && unitToAdd <= currentProduct.UnitInStock - unitInCart)
                {
                    unitInCart = unitInCart + unitToAdd;
                    if (cart.ContainsKey(currentProduct.ProductId))
                    {
                        cart[currentProduct.ProductId] = unitInCart;
                    }
                    else cart.Add(currentProduct.ProductId, unitInCart);
                    lbCreateOrder.Text = "(" + cart.Count + " items)";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void numericAddToCart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductGrid.CellDoubleClick += ProductGrid_DoubleClick;
        }
        private void ProductGrid_DoubleClick(object sender, EventArgs e)
        {
            if (managerID.Equals("admin"))
            {
                frmUpdateProduct updateProduct = new frmUpdateProduct();
                updateProduct.product = GetCurrentProduct();
                updateProduct.Show();
                updateProduct.BringToFront();
            }
            else
            {
                MessageBox.Show("Login as admin to use this feature");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadProduct("");
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadProduct(textBox1.Text);
        }


        private void numericID_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            loadProductID(Convert.ToInt32(numericID.Value));
        }

        private void ProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
