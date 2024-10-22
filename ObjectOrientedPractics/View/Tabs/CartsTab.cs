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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит данные о товарах. Является списком типа <see cref="Model.Item"/>.
        /// </summary>
        public List<Model.Classes.Item> Items { get; set; }
        /// <summary>
        /// Хранит данные о покупателях. Является списком типа <see cref="Model.Classes.Customer"/>.
        /// </summary>
        public List<Model.Classes.Customer> Customers { get; set; }
        /// <summary>
        /// Выбранные покупатель.
        /// </summary>
        private Model.Classes.Customer _curentCustomer;
        public CartsTab()
        {
            InitializeComponent();

        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomers.SelectedIndex >= 0)
            {
                _curentCustomer = Customers[cbCustomers.SelectedIndex];
                if (_curentCustomer.Cart.Items.Count > 0 && _curentCustomer.Cart != null)
                {
                    lbCart.Items.Clear();
                    foreach (var i in _curentCustomer.Cart.Items)
                    {
                        lbCart.Items.Add(i.Name);
                    }

                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0 && _curentCustomer.Cart != null)
            {
                _curentCustomer.Cart.Items.Add(Items[lbItems.SelectedIndex]);
                lbCart.Items.Add(Items[lbItems.SelectedIndex].Name);
                labelAmount.Text = _curentCustomer.Cart.Amount.ToString();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (lbCart.Items.Count > 0)
            {
                if (_curentCustomer.IsPriority == true)
                {
                    _curentCustomer.Orders.Add(new Model.Classes.Orders.PriorityOrder(
                        _curentCustomer.Address, new List<Model.Classes.Item>(_curentCustomer.Cart.Items)));
                }
                else
                {
                    _curentCustomer.Orders.Add(new Model.Classes.Orders.Order(
                        _curentCustomer.Address, new List<Model.Classes.Item>(_curentCustomer.Cart.Items)));
                }
                _curentCustomer.Cart.Items.Clear();
                lbCart.Items.Clear();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbCart.SelectedIndex >= 0)
            {
                _curentCustomer.Cart.Items.RemoveAt(lbCart.SelectedIndex);
                lbCart.Items.RemoveAt(lbCart.SelectedIndex);
                labelAmount.Text = _curentCustomer.Cart.Amount.ToString();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _curentCustomer.Cart.Items.Clear();
            lbCart.Items.Clear();
            labelAmount.Text = "0.0";
        }

        public void RefreshData()
        {
            lbItems.Items.Clear();
            cbCustomers.Items.Clear();
            foreach (var i in Items)
            {
                lbItems.Items.Add(i.Name);
            }
            foreach (var i in Customers)
            {
                cbCustomers.Items.Add(i.Name);
            }
        }
    }
}
