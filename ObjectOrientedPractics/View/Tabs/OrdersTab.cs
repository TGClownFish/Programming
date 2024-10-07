using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        public void RefreshData()
        {
            dgvOrders.Rows.Clear();
            foreach(Customer customer in Customers)
            {
                if (customer.Orders.Count > 0)
                {
                    foreach (Order order in customer.Orders)
                    {
                        dgvOrders.Rows.Add(order.Id, order.CreateDate.ToString("d.M.yy"), customer.Name, order.Address.ConvertToString(), order.Amount, Model.Enums.OrderStatus.New);
                    }
                }
            }
        }
    }
}
