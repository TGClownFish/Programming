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
                //tbAddress.Text = Convert.ToString(_customers[lbCustomers.SelectedIndex].Address);
                Save();
            }
            else
            {
                tbID.Text = "";
                tbName.Text = "";
                //tbAddress.Text = "";
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
            Save();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _customers[lbCustomers.SelectedIndex].Name = tbName.Text;
                tbName.BackColor = Color.White;
                Save();

            }
            catch
            {
                tbName.BackColor = Color.LightPink;
            }
        }

        //private void tbAddress_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        _customers[lbCustomers.SelectedIndex].Address = tbAddress.Text;
        //        tbAddress.BackColor = Color.White;

        //    }
        //    catch
        //    {
        //        tbAddress.BackColor = Color.LightPink;
        //    }
        //}

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex >= 0)
            {
                lbCustomers.Items[lbCustomers.SelectedIndex] = tbName.Text;
                Save();
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
                "Lysenko\\ObjectOrientedPractics\\Items.json");
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
