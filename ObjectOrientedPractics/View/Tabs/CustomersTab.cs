using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Classes.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Хранит список покупателей. 
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                _currentCustomer = Customers[lbCustomers.SelectedIndex];
                tbID.Text = Convert.ToString(_currentCustomer.Id);
                tbName.Text = Convert.ToString(_currentCustomer.Name);
                addressControl.Address = _currentCustomer.Address;
                chbPriority.Checked = _currentCustomer.IsPriority;
                lbDiscount.Items.Clear();
                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    lbDiscount.Items.Add(discount.Info);
                }
            }
            else
            {
                tbID.Text = "";
                tbName.Text = "";
                addressControl.Address = new Address();
                chbPriority.Checked = false;
                lbDiscount.Items.Clear();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Customers.Add(new());
            lbCustomers.Items.Add("Unnamed Customer");
            lbCustomers.SelectedIndex = Customers.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customers.RemoveAt(lbCustomers.SelectedIndex);
            lbCustomers.Items.RemoveAt(lbCustomers.SelectedIndex);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                try
                {
                    _currentCustomer.Name = tbName.Text;
                    tbName.BackColor = Color.White;

                }
                catch
                {
                    tbName.BackColor = Color.LightPink;
                }
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                lbCustomers.Items[lbCustomers.SelectedIndex] = tbName.Text;
            }
        }

        public void RefreshData()
        {
            lbCustomers.Items.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                lbCustomers.Items.Add(Convert.ToString(Customers[i].Name));
            }
        }

        private void chbPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                _currentCustomer.IsPriority = chbPriority.Checked;
            }
        }

        private void lbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                FormAddDiscount formAddDiscount = new FormAddDiscount();
                formAddDiscount.Categoties.AddRange(Enum.GetNames(typeof(Model.Enums.Category)));
                formAddDiscount.Categoties.RemoveAt(0);
                formAddDiscount.ShowDialog();
                if (formAddDiscount.DialogResult == DialogResult.OK)
                {
                    _currentCustomer.Discounts.Add(new PercentDiscount(formAddDiscount.ChosenCategory));
                    lbDiscount.Items.Add(_currentCustomer.Discounts.Last().Info);
                }
                
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0 && lbDiscount.SelectedIndex >= 0)
            {

            }

        }
    }
}