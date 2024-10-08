using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public OrdersTab()
        {
            InitializeComponent();
            cbStatus.Items.AddRange(Enum.GetNames(typeof(Model.Enums.OrderStatus)));
        }
        public void RefreshData()
        {
            dgvOrders.Rows.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders.Count > 0)
                {
                    foreach (Order order in customer.Orders)
                    {
                        dgvOrders.Rows.Add(order.Id, order.CreateDate.ToString("dd.MM.yyyy"), customer.Name, order.Address.ConvertToString(), 
                            order.Amount, order.Status);
                        Orders.Add(order);
                    }
                }
            }
            //if (this.dgvOrders.CurrentCell.Selected!=null)
            this.dgvOrders.CurrentRow.Selected = false;

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvOrders.CurrentRow.Index >= 0)
            {
                tbId.Text = Convert.ToString(Orders[this.dgvOrders.CurrentRow.Index].Id);
                tbCreated.Text = Convert.ToString(Orders[this.dgvOrders.CurrentRow.Index].CreateDate);
                cbStatus.Text = Convert.ToString(Orders[this.dgvOrders.CurrentRow.Index].Status);
                addressControl1.Address = Orders[this.dgvOrders.CurrentRow.Index].Address;
                foreach (Model.Item item in Orders[this.dgvOrders.CurrentRow.Index].Items)
                {
                    lbOrderItems.Items.Add(item.Name);
                }
            }
            else
            {
                tbId.Text = "";
                tbCreated.Text = "";
                cbStatus.Text = "";
                addressControl1.Address = new Address();
                lbOrderItems.Items.Clear();
            }
        }
    }
}
