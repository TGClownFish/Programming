using ObjectOrientedPractics.Model.Classes;
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
        private Address _address = new Address();
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                tbPostIndex.Text = _address.Index;
                tbCountry.Text = _address.Country;
                tbCity.Text = _address.City;
                tbStreet.Text = _address.Street;
                tbBuilding.Text = _address.Building;
                tbApartment.Text = _address.Apartment;
                if (IsReadOnly)
                {
                    tbPostIndex.ReadOnly = true;
                    tbCountry.ReadOnly = true;
                    tbCity.ReadOnly = true;
                    tbStreet.ReadOnly = true;
                    tbBuilding.ReadOnly = true;
                    tbApartment.ReadOnly = true;
                }
                else
                {
                    tbPostIndex.ReadOnly = false;
                    tbCountry.ReadOnly = false;
                    tbCity.ReadOnly = false;
                    tbStreet.ReadOnly = false;
                    tbBuilding.ReadOnly = false;
                    tbApartment.ReadOnly = false;
                }
            }
        }
        public bool IsReadOnly { get; set; } = false;

        public AddressControl()
        {
            InitializeComponent();

        }

        private void tbPostIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = tbPostIndex.Text;
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
                _address.Country = tbCountry.Text;
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
                _address.City = tbCity.Text;
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
                _address.Street = tbStreet.Text;
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
                _address.Building = tbBuilding.Text;
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
                _address.Apartment = tbApartment.Text;
                tbApartment.BackColor = Color.White;
            }
            catch
            {
                tbApartment.BackColor = Color.LightPink;
            }
        }
    }
}
