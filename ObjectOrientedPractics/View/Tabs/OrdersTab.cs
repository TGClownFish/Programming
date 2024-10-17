using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Enums;
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
        /// <summary>
        /// Хранит данные о покупателях. Является списком типа <see cref="Model.Classes.Customer"/>.
        /// </summary>
        public List<Customer> Customers { get; set; }
        /// <summary>
        /// Хранит данные о заказах. Является списком типа <see cref="Model.Classes.Order"/>.
        /// </summary>
        public List<Order> Orders { get; set; } = new List<Order>();
        /// <summary>
        /// Выбранные товар.
        /// </summary>
        private Order _curentOrder;

        private PriorityOrder _curentPriorityOrder;

        public OrdersTab()
        {
            InitializeComponent();
            cbStatus.Items.AddRange(Enum.GetNames(typeof(Model.Enums.OrderStatus)));
        }
        public void RefreshData()
        {
            dgvOrders.Rows.Clear();
            Orders.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders.Count > 0)
                {
                    foreach (Order order in customer.Orders)
                    {
                        dgvOrders.Rows.Add(order.Id, order.CreateDate.ToString("dd.MM.yyyy"), 
                            customer.Name, order.Address.ConvertToString(),
                            order.Amount, order.Status);
                        Orders.Add(order);
                    }
                }
            }
        }

        private void dgvOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvOrders.CurrentCell != null && Orders.Count != 0)
            {
                _curentOrder = Orders[this.dgvOrders.CurrentCell.RowIndex];
                labelAmount.Text = Convert.ToString(_curentOrder.Amount);
                tbId.Text = Convert.ToString(_curentOrder.Id);
                tbCreated.Text = Convert.ToString(_curentOrder.CreateDate);
                cbStatus.Text = Convert.ToString(_curentOrder.Status);
                addressControl1.Address = _curentOrder.Address;
                lbOrderItems.Items.Clear();
                foreach (Model.Classes.Item item in _curentOrder.Items)
                {
                    lbOrderItems.Items.Add(item.Name);
                }
                if (_curentOrder is PriorityOrder)
                {
                    label7.Visible = true;
                    cbDeliveryTime.Visible = true;
                    _curentPriorityOrder = (PriorityOrder) _curentOrder;
                    cbDeliveryTime.SelectedIndex = (int)_curentPriorityOrder.DesiredDeliveryTime;
                }
                else
                {
                    label7.Visible = false;
                    cbDeliveryTime.Visible = false;
                }
            }
            else
            {
                tbId.Text = "";
                tbCreated.Text = "";
                cbStatus.Text = "";
                addressControl1.Address = new Address();
                lbOrderItems.Items.Clear();
                labelAmount.Text = "0.0";
                label7.Visible = false;
                cbDeliveryTime.Visible = false;
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dgvOrders.CurrentCell != null)
            {
                _curentOrder.Status = (Model.Enums.OrderStatus)cbStatus.SelectedIndex;
                this.dgvOrders.Rows[this.dgvOrders.CurrentCell.RowIndex].Cells[5].Value = 
                    Convert.ToString(_curentOrder.Status);
            }
        }

        private void cbDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curentPriorityOrder.DesiredDeliveryTime = (PriorityOrderDeliveryTime)cbDeliveryTime.SelectedIndex;
        }
    }
}
