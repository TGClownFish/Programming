using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public Store Store { get { return _store; } }
        public MainForm()
        {
            InitializeComponent();
            //Store.Items.Add(new Model.Item("f", "", 42, 0));
            //Store.Customers.Add(new Model.Classes.Customer("4",new Model.Classes.Address()));
            itemsTab.Items = Store.Items;
            customersTab.Customers = Store.Customers;
            cartsTab1.Items = Store.Items;
            cartsTab1.Customers = Store.Customers;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 2)
            //{
            cartsTab1.RefreshData();
            //}
        }
    }
}
