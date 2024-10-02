﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Model.Item> _items = new List<Model.Item>();
        Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
            cbCategory.Items.AddRange(Enum.GetNames(typeof(Model.Category)));
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                _currentItem = _items[lbItems.SelectedIndex];
                tbID.Text = Convert.ToString(_currentItem.Id);
                tbCost.Text = Convert.ToString(_currentItem.Cost);
                tbName.Text = Convert.ToString(_currentItem.Name);
                tbDescription.Text = Convert.ToString(_currentItem.Description);
                cbCategory.SelectedIndex = (int) _currentItem.Category;
            }
            else
            {
                tbID.Text = "";
                tbCost.Text = "";
                tbName.Text = "";
                tbDescription.Text = "";
                cbCategory.SelectedIndex = -1;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _items.Add(new());
            lbItems.Items.Add("Unnamed Item");
            lbItems.SelectedIndex = _items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _items.RemoveAt(lbItems.SelectedIndex);
            lbItems.Items.RemoveAt(lbItems.SelectedIndex);
        }

        private void tbCost_TextChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                try
                {
                    _currentItem.Cost = Convert.ToInt32(tbCost.Text);
                    tbCost.BackColor = Color.White;
                }
                catch
                {
                    tbCost.BackColor = Color.LightPink;
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                try
                {
                    _currentItem.Name = tbName.Text;
                    tbCost.BackColor = Color.White;

                }
                catch
                {
                    tbCost.BackColor = Color.LightPink;
                }
            }
        }

        private void tbDescrption_TextChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                try
                {
                    _currentItem.Description = tbDescription.Text;
                    tbCost.BackColor = Color.White;
                }
                catch
                {
                    tbCost.BackColor = Color.LightPink;
                }
            }
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                try
                {
                    _currentItem.Category = (Category) cbCategory.SelectedIndex;
                    cbCategory.BackColor = Color.White;
                }
                catch
                {
                    cbCategory.BackColor = Color.LightPink;
                }
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                lbItems.Items[lbItems.SelectedIndex] = tbName.Text;
            }
        }
    }
}
