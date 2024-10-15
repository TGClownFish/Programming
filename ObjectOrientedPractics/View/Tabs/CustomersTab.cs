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

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void lbCusomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                _currentCustomer = Customers[lbCustomers.SelectedIndex];
                tbID.Text = Convert.ToString(_currentCustomer.Id);
                tbName.Text = Convert.ToString(_currentCustomer.Name);
                addressControl.Address = _currentCustomer.Address;
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
            Customers.Add(new());
            lbCustomers.Items.Add("Unnamed Customer");
            lbCustomers.SelectedIndex = Customers.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customers.RemoveAt(lbCustomers.SelectedIndex);
            lbCustomers.Items.RemoveAt(lbCustomers.SelectedIndex);
            Save();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
<<<<<<< HEAD
                _customers[lbCustomers.SelectedIndex].Name = tbName.Text;
                tbName.BackColor = Color.White;
                Save();

            }
            catch
            {
                tbName.BackColor = Color.LightPink;
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _customers[lbCustomers.SelectedIndex].Address = tbAddress.Text;
                tbAddress.BackColor = Color.White;
                Save();

            }
            catch
            {
                tbAddress.BackColor = Color.LightPink;
=======
                try
                {
                    _currentCustomer.Name = tbName.Text;
                    tbName.BackColor = Color.White;

                }
                catch
                {
                    tbName.BackColor = Color.LightPink;
                }
>>>>>>> Tasks/3_agregation
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                lbCustomers.Items[lbCustomers.SelectedIndex] = tbName.Text;
            }
        }
        private void CustomersTab_Load(object sender, EventArgs e)
        {
            string newLine;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
              "Lysenko\\ObjectOrientedPractics\\Customers.json");
            using (StreamReader reader = new StreamReader(filePath))
            {
                newLine = reader.ReadLine();
                while (newLine != "" && newLine != null)
                {
                    _customers.Add(JsonSerializer.Deserialize<Model.Customer>(newLine));
                    newLine = reader.ReadLine();
                }
                foreach (var i in _customers)
                {
                    lbCustomers.Items.Add(i.Name);
                }
            }
        }
        public void Save()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Lysenko\\ObjectOrientedPractics\\Customers.json");
            using (StreamWriter stream = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < lbCustomers.Items.Count; i++)
                {
                    stream.WriteLine(JsonSerializer.Serialize(_customers[i]));
                }
            }
        }
    }
}
