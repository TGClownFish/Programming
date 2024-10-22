using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class FormAddDiscount : Form
    {
        public List<string> Categoties { get; set; } = new List<string>();
        public Category ChosenCategory { get; set; }
        public FormAddDiscount()
        {
            InitializeComponent();

        }

        private void FormAddDiscount_Load(object sender, EventArgs e)
        {
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            foreach (string category in Categoties)
            {
                cbCategory.Items.Add(category);
            }
        }

        private void cbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex >= 0)
            { 
                ChosenCategory = (Category)Enum.Parse(typeof(Category), Convert.ToString(cbCategory.SelectedItem), true); 
            }
        }
    }
}
