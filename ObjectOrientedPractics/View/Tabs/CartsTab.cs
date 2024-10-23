using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Classes.Orders;

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
                lbCart.Items.Clear();
                if (_curentCustomer.Cart.Items.Count > 0 && _curentCustomer.Cart != null)
                {
                    foreach (Item item in _curentCustomer.Cart.Items)
                    {
                        lbCart.Items.Add(item.Name);
                    }
                }
                UpdateDiscountInfo();
                CalculateAmounts();
            }
        }

        private void CalculateAmounts()
        {
            if (_curentCustomer != null)
            {
                labelAmount.Text = _curentCustomer.Cart.Amount.ToString();
                double discountAmount = 0;
                for (int i = 0; i < clbDiscounts.Items.Count; i++)
                {
                    if (clbDiscounts.GetItemChecked(i) == true)
                    {
                        discountAmount += _curentCustomer.Discounts[i].Calculate(_curentCustomer.Cart.Items);
                    }
                }
                labelDiscount.Text = discountAmount.ToString();
                labelTotal.Text = Convert.ToString(_curentCustomer.Cart.Amount - discountAmount);
            }
            else
            {
                labelAmount.Text = "0";
                labelDiscount.Text = "0";
                labelTotal.Text = "0";
            }
        }

        private void UpdateDiscountInfo()
        {
            clbDiscounts.Items.Clear();
            foreach (IDiscount discount in _curentCustomer.Discounts)
            {
                clbDiscounts.Items.Add(discount.Info);
                clbDiscounts.SetItemChecked(clbDiscounts.Items.Count - 1, true);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0 && _curentCustomer.Cart != null)
            {
                _curentCustomer.Cart.Items.Add(Items[lbItems.SelectedIndex]);
                lbCart.Items.Add(Items[lbItems.SelectedIndex].Name);
                CalculateAmounts();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (lbCart.Items.Count > 0)
            {
                foreach (IDiscount discount in _curentCustomer.Discounts)
                {
                    discount.Apply(_curentCustomer.Cart.Items);
                }
                foreach (IDiscount discount in _curentCustomer.Discounts)
                {
                    discount.Update(_curentCustomer.Cart.Items);
                }
                if (_curentCustomer.IsPriority == true)
                {
                    _curentCustomer.Orders.Add(new PriorityOrder(
                        _curentCustomer.Address, new List<Item>(_curentCustomer.Cart.Items), Convert.ToDouble(labelDiscount.Text)));
                }
                else
                {
                    _curentCustomer.Orders.Add(new Order(
                        _curentCustomer.Address, new List<Item>(_curentCustomer.Cart.Items), Convert.ToDouble(labelDiscount.Text)));
                }
                _curentCustomer.Cart.Items.Clear();
                lbCart.Items.Clear();
                UpdateDiscountInfo();
                CalculateAmounts();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbCart.SelectedIndex >= 0)
            {
                _curentCustomer.Cart.Items.RemoveAt(lbCart.SelectedIndex);
                lbCart.Items.RemoveAt(lbCart.SelectedIndex);
                CalculateAmounts();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _curentCustomer.Cart.Items.Clear();
            lbCart.Items.Clear();
            CalculateAmounts();
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
            if (_curentCustomer != null)
            {
                UpdateDiscountInfo();
            }
            CalculateAmounts();
        }

        private void clbDiscounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAmounts();
        }
    }
}
