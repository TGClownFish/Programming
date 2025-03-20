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
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public delegate bool FilterType (Item item);

    public class ItemEventArgs : EventArgs
    {
        public List<Item> Value { get; set; }
    }

    public partial class ItemsTab : UserControl
    {
        public event EventHandler<ItemEventArgs> ItemsChanged;

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> _items;
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        public List<Item> Items 
        { 
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                if (_items != value)
                {
                    var args = new ItemEventArgs();
                    args.Value = _items;
                    ItemsChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item СurrentItem { get; set; }

        /// <summary>
        /// Хранит список показываемых товаров.
        /// </summary>
        private List<Item> DisplayedItems { get; set; } = new List<Item>();

        public ItemsTab()
        {
            InitializeComponent();
            cbCategory.Items.AddRange(Enum.GetNames(typeof(Category)));
            cbOrderBy.SelectedIndex = 0;
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                СurrentItem = Items[Items.IndexOf(DisplayedItems[lbItems.SelectedIndex])];
                tbID.Text = Convert.ToString(СurrentItem.Id);
                tbCost.Text = Convert.ToString(СurrentItem.Cost);
                tbName.Text = Convert.ToString(СurrentItem.Name);
                tbDescription.Text = Convert.ToString(СurrentItem.Description);
                cbCategory.SelectedIndex = (int)СurrentItem.Category;
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
            DisplayedItems.Add(Items.Last());
            lbItems.SelectedIndex = DisplayedItems.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Items.Remove(СurrentItem);
            lbItems.Items.Remove(СurrentItem.Name);
            DisplayedItems.Remove(СurrentItem);
        }

        private void tbCost_TextChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                try
                {
                    СurrentItem.Cost = Convert.ToInt32(tbCost.Text);
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
                    СurrentItem.Name = tbName.Text;
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
                    СurrentItem.Description = tbDescription.Text;
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
                    СurrentItem.Category = (Category)cbCategory.SelectedIndex;
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

        public void RefreshData()
        {
            Refresh_lbItems(HasSubString);
        }

        private void Refresh_lbItems(Func<Item, bool> filterType)
        {
            lbItems.Items.Clear();
            DisplayedItems.Clear();
            foreach (var item in Items)
            {
                if (filterType(item))
                {
                    DisplayedItems.Add(item);
                }
            }
            switch (cbOrderBy.SelectedIndex)
            {
                case 0:
                    Sort_lbItems(ByName);
                    break;
                case 1:
                    Sort_lbItems(ByCost);
                    break;
                case 2:
                    Sort_lbItems(ByCostDescending);
                    break;
            }
            foreach (var item in DisplayedItems)
            {
                lbItems.Items.Add(item.Name);
            }
        }

        public bool HasSubString(Item item)
        {
            return item.Name.Contains(tbFind.Text);
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            Refresh_lbItems(HasSubString);
        }

        private void Sort_lbItems(Func<Item, Item, int> filter)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < DisplayedItems.Count - 1; i++)
                {
                    if (filter(DisplayedItems[i], DisplayedItems[i + 1]) == 1)
                    {
                        Item temporaryItem = (Item) DisplayedItems[i].Clone();
                        DisplayedItems[i] = (Item)DisplayedItems[i + 1].Clone();
                        DisplayedItems[i + 1] = temporaryItem;
                        isSorted = false;
                    }
                }
            }
        }

        public int ByName(Item item1, Item item2)
        {
            return item1.Name.CompareTo(item2.Name);
        }

        public int ByCost(Item item1, Item item2)
        {
            return item1.Cost.CompareTo(item2.Cost);
        }

        public int ByCostDescending(Item item1, Item item2)
        {
            return item2.Cost.CompareTo(item1.Cost);
        }

        private void cbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbOrderBy.SelectedIndex)
            {
                case 0:
                    Sort_lbItems(ByName);
                    break;
                case 1:
                    Sort_lbItems(ByCost);
                    break;
                case 2:
                    Sort_lbItems(ByCostDescending);
                    break;
            }
            lbItems.Items.Clear();
            foreach (var item in DisplayedItems)
            {
                lbItems.Items.Add(item.Name);
            }
        }
    }
}