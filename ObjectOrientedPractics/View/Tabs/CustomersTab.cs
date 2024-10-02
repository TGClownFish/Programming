﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Model.Customer> _customers = new List<Model.Customer>();
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void lbCusomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                tbID.Text = Convert.ToString(_customers[lbCustomers.SelectedIndex].Id);
                tbName.Text = Convert.ToString(_customers[lbCustomers.SelectedIndex].Name);
                addressControl.Address = _customers[lbCustomers.SelectedIndex].Address;
            }
            else
            {
                tbID.Text = "";
                tbName.Text = "";
                addressControl.Address = new Address();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _customers.Add(new());
            lbCustomers.Items.Add("Unnamed Customer");
            lbCustomers.SelectedIndex = _customers.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customers.RemoveAt(lbCustomers.SelectedIndex);
            lbCustomers.Items.RemoveAt(lbCustomers.SelectedIndex);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _customers[lbCustomers.SelectedIndex].Name = tbName.Text;
                tbName.BackColor = Color.White;

            }
            catch
            {
                tbName.BackColor = Color.LightPink;
            }
        }

    }
}
