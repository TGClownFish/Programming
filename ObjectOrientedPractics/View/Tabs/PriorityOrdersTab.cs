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
        public Model.Classes.PriorityOrder PriorityOrder { get; set; } = new Model.Classes.PriorityOrder();

        public List<Model.Classes.Item> Items { get; set; }
        public PriorityOrdersTab()
        {
            InitializeComponent();
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
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.Status = (OrderStatus) cbStatus.SelectedIndex;
        }

        private void cbDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.DesiredDeliveryTime = (PriorityOrderDeliveryTime) cbDeliveryTime.SelectedIndex;
        }
    }
}
