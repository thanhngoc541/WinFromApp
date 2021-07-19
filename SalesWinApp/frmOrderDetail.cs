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
    public partial class frmOrderDetail : Form
    {
        private int orderId = 0;
        public frmOrderDetail(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            Order order = new OrderRepository().Get(orderId);
            txtOrderId.Text = order.OrderId.ToString();
            txtOrderDate.Text = order.OrderDate.ToString();
            txtRequiredDate.Text = order.RequiredDate.ToString();
            txtShippedDate.Text = order.ShippedDate.ToString();
            txtFreight.Text = order.Freight.ToString();
            txtMemberId.Text = order.MemberId.ToString();
            var datasource = order.OrderDetails.ToList();
            OrderDetailGrid.DataSource = datasource;
        }

        private void OrderDetailGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clear not needed columns
            foreach (var columnName in new string[] { "Product", "OrderId", "Order"})
            {
                if (OrderDetailGrid.Columns[columnName] != null)
                {
                    OrderDetailGrid.Columns[columnName].Visible = false;
                }
            }
        }

        private void lbOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void lbOrderId_Click(object sender, EventArgs e)
        {

        }
    }
}
