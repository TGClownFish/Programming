using System;
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
        private List<Model.Item> _items;
        public List<Model.Item> Items 
        { 
            get 
            { 
                return _items; 
            } 
            set 
            { 
                _items = value; 

            }
        }
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
            cbCategory.Items.AddRange(Enum.GetNames(typeof(Model.Category)));
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                _currentItem = Items[lbItems.SelectedIndex];
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
            Items.Add(new());
            lbItems.Items.Add("Unnamed Item");
            lbItems.SelectedIndex = Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Items.RemoveAt(lbItems.SelectedIndex);
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
                    tbName.BackColor = Color.White;

                }
                catch
                {
                    tbName.BackColor = Color.LightPink;
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
                    tbDescription.BackColor = Color.White;
                }
                catch
                {
                    tbDescription.BackColor = Color.LightPink;
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
