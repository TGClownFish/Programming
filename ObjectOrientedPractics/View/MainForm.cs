using ObjectOrientedPractics.Model;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public Store Store { get { return _store; } }
        public MainForm()
        {
            InitializeComponent();
            AddDefaultData();
            itemsTab.Items = Store.Items;
            customersTab.Customers = Store.Customers;
            cartsTab1.Items = Store.Items;
            cartsTab1.Customers = Store.Customers;
            ordersTab1.Customers = Store.Customers;
            priorityOrdersTab1.Items = Store.Items;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    itemsTab.RefreshData();
                    break;
                case 1:
                    customersTab.RefreshData();
                    break;
                case 2:
                    cartsTab1.RefreshData();
                    break;
                case 3: 
                    ordersTab1.RefreshData();
                    break;
            }
        }

        public void AddDefaultData()
        {
            Store.Items.Add(new Model.Classes.Item("fff", "55", 42, Category.None));
            Store.Items.Add(new Model.Classes.Item("faaa", "ada", 222, Category.Toys));
            Store.Items.Add(new Model.Classes.Item("f111", "faaf", 42222, Category.Furniture));
            Store.Items.Add(new Model.Classes.Item("fdffdf", "arafr", 42333, Category.Shoes));
            Store.Customers.Add(new Model.Classes.Customer("4", new Model.Classes.Address("000100", "4", "55", "11", "ff", "aa")));
            Store.Customers.Add(new Model.Classes.Customer("FFFFF", new Model.Classes.Address("100100", "4FF", "5AA5", "1SDSS1", "fFFf", "aSSa"),true));
        }
    }
}
