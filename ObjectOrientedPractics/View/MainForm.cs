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
            itemsTab.Items = Store.Items;
            customersTab.Customers = Store.Customers;
        }
    }
}
