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
    public partial class frmOrderManagement : Form
    {
        public string managerID { get; set; }
        public frmOrderManagement()
        {
            InitializeComponent();
            pickerStartDate.Value = DateTime.Now.Date;
            pickerEndDate.Value = DateTime.Now.Date.AddDays(1).AddTicks(-1);
            Search(pickerStartDate.Value.Date, pickerEndDate.Value.Date.AddDays(1).AddTicks(-1));
        }

        private void OrderForm_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (var columnName in new string[] { "Member", "OrderDetails" })
            {
                if (OrderGrid.Columns[columnName] != null)
                {
                    OrderGrid.Columns[columnName].Visible = false;
                }
            }
        }

        private void Search(DateTime starDateTime, DateTime endDateTime)
        {
            OrderGrid.DataSource = null;
            var datasource = new OrderRepository().Search(starDateTime, endDateTime,managerID);
            
            OrderGrid.DataSource = datasource;
 
            txtTotalSale.Text = datasource.Sum(Order => (Order.OrderDetails is null ? 0 :
                Order.OrderDetails.Sum(item => item.UnitPrice * item.Quantity * (decimal) (1 - item.Discount / 100)))).ToString();
            txtNumberOfOrder.Text = datasource.Count.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(pickerStartDate.Value.Date, pickerEndDate.Value.Date.AddDays(1).AddTicks(-1));
        }

        private Order GetCurrentOrder()
        {
            Order currentOrder = null;
            try
            {
                Int32 selectedRowCount =
                    OrderGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    currentOrder = new Order();
                    var selectedrow = OrderGrid.SelectedRows[0];
                    currentOrder.OrderId = Convert.ToInt32(selectedrow.Cells[0].Value.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return currentOrder;
        }

        private void OrderGrid_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Order currentOrder = GetCurrentOrder();
            if (currentOrder != null)
            {
                var orderDetailForm = new frmOrderDetail(currentOrder.OrderId);
                orderDetailForm.Show();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void lbNumberOfOrder_Click(object sender, EventArgs e)
        {

        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
