using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
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
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Хранит данные о приоритетном заказе.
        /// </summary>
        public Model.Classes.PriorityOrder PriorityOrder { get; set; }

        public List<Model.Classes.Item> Items { get; set; }

        private Random _random = new Random();
        public PriorityOrdersTab()
        {
            InitializeComponent();
            PriorityOrder = new Model.Classes.PriorityOrder();
            cbStatus.Items.AddRange(Enum.GetNames(typeof(Model.Enums.OrderStatus)));
            addressControl1.IsReadOnly = true;
            OrderChanged();
        }
        public void OrderChanged()
        {
            tbId.Text = Convert.ToString(PriorityOrder.Id);
            tbCreated.Text = PriorityOrder.CreateDate.ToString("dd.MM.yyyy");
            cbDeliveryTime.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            labelAmount.Text = "0.0";
            lbOrderItems.Items.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lbOrderItems.Items.Add(Items[_random.Next(Items.Count)].Name);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbOrderItems.SelectedIndex >= 0)
            {
                lbOrderItems.Items.RemoveAt(lbOrderItems.SelectedIndex);
                lbOrderItems.SelectedIndex = lbOrderItems.Items.Count - 1;
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            PriorityOrder = new Model.Classes.PriorityOrder();
            OrderChanged();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PriorityOrder != null)
            {
                PriorityOrder.Status = (OrderStatus)cbStatus.SelectedIndex;
            }
        }

        private void cbDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PriorityOrder != null)
            {
                PriorityOrder.DesiredDeliveryTime = (PriorityOrderDeliveryTime)cbDeliveryTime.SelectedIndex;
            }
        }
    }
}
