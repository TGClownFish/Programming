using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Model.Address  _address = new Model.Address();
        public  Model.Address Address
        {
            get { return _address; } 
            set { _address = value; }
        }

        public void SetAddress(Model.Address address)
        {
            Address = address;
            UpdateData();

        }

        public void UpdateData()
        {
            tbPostIndex.Text = Address.Index;
            tbCountry.Text = Address.Country;
            tbCity.Text = Address.City;
            tbStreet.Text = Address.Street;
            tbBuilding.Text = Address.Building;
            tbApartment.Text = Address.Apartment;
        }

        public Address GetAddress()
        {
            return Address;
        }

        public AddressControl()
        {
            //Address = new Model.Address();
            InitializeComponent();
            
        }

        private void tbPostIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = tbPostIndex.Text;
                tbPostIndex.BackColor = Color.White;
            }
            catch 
            {
                tbPostIndex.BackColor = Color.LightPink;
            }
        }

        private void tbCountry_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = tbCountry.Text;
                tbCountry.BackColor = Color.White;
            }
            catch
            {
                tbCountry.BackColor = Color.LightPink;
            }
        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = tbCity.Text;
                tbCity.BackColor = Color.White;
            }
            catch
            {
                tbCity.BackColor = Color.LightPink;
            }
        }

        private void tbStreet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = tbStreet.Text;
                tbStreet.BackColor = Color.White;
            }
            catch
            {
                tbStreet.BackColor = Color.LightPink;
            }
        }

        private void tbBuilding_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = tbBuilding.Text;
                tbBuilding.BackColor = Color.White;
            }
            catch
            {
                tbBuilding.BackColor = Color.LightPink;
            }
        }

        private void tbApartment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = tbApartment.Text;
                tbApartment.BackColor = Color.White;
            }
            catch
            {
                tbApartment.BackColor = Color.LightPink;
            }
        }
    }
}
