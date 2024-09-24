using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        Model.Address _address = new Model.Address();
        //public Model.Address 
        public AddressControl()
        {
            InitializeComponent();
        }
    }
}
