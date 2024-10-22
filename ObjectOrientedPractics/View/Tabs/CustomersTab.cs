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
using ObjectOrientedPractics.Model.Enums;

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

        /// <summary>
        /// Хранит названия категорий товара (<see cref="Category"/>)
        /// </summary>
        public List<string> AddedCategoryNames { get; set; } = new List<string>();

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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customers.Add(new());
            lbCustomers.Items.Add("Unnamed Customer");
            lbCustomers.SelectedIndex = Customers.Count - 1;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
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
            lbDiscount.Items.Clear();
            if (_currentCustomer != null)
            {
                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    lbDiscount.Items.Add(discount.Info);
                }
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

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                labelError.Text = "";
                FormAddDiscount formAddDiscount = new FormAddDiscount();
                formAddDiscount.Categoties.AddRange(Enum.GetNames(typeof(Category)));
                foreach (string addedName in AddedCategoryNames)
                {
                    formAddDiscount.Categoties.Remove(addedName);
                }
                // if formAddDiscount.Categoties.Count == 1, than its only have "None" element
                if (formAddDiscount.Categoties.Count == 1)
                {
                    labelError.Text = "No Discounts To Add!";
                    formAddDiscount.Dispose();
                }
                else
                {
                    formAddDiscount.ShowDialog();
                }
                if (formAddDiscount.DialogResult == DialogResult.OK && formAddDiscount.ChosenCategory != Category.None)
                {
                    _currentCustomer.Discounts.Add(new PercentDiscount(formAddDiscount.ChosenCategory));
                    lbDiscount.Items.Add(_currentCustomer.Discounts.Last().Info);
                    AddedCategoryNames.Add(Convert.ToString(formAddDiscount.ChosenCategory));
                }
            }
            else
            {
                labelError.Text = "No Customer Selected!";
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            // lbDiscount.SelectedIndex must be > 0 beacause you should not be able to delete its first element
            if (lbCustomers.SelectedIndex >= 0 && lbDiscount.SelectedIndex > 0)
            {
                _currentCustomer.Discounts.RemoveAt(lbDiscount.SelectedIndex);
                AddedCategoryNames.RemoveAt(lbDiscount.SelectedIndex - 1);
                lbDiscount.Items.RemoveAt(lbDiscount.SelectedIndex);
            }
            if (lbDiscount.SelectedIndex == 0)
            {
                labelError.Text = "You can`t delete this!";
            }
        }
    }
}