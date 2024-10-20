using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Classes;
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
    public partial class DiscountTab2 : UserControl
    {
        public PointsDiscount Discount { get; set; } = new PointsDiscount(300);
        public List<Item> Items { get; set; } = new List<Item>();
        public double Amount
        { get
            {
                double counter = 0.0;
                for (int i = 0; i < Items.Count; i++)
                {
                    counter += Items[i].Cost;
                }
                return counter;
            } 
        }
        public DiscountTab2()
        {
            Items.Add(new Model.Classes.Item("fff", "55", 1340, Category.None));
            Items.Add(new Model.Classes.Item("faaa", "ada", 222, Category.Toys));
            InitializeComponent();
            labelInfo.Text = Convert.ToString(Discount.Info);
            labelProductAmount.Text = Convert.ToString(Amount);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            labelDiscountAmout.Text = $" {Convert.ToString( Math.Ceiling( Discount.Calculate(Items) * Amount))} — {Discount.Calculate(Items) * 100}%";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            labelDiscountAmout.Text = Convert.ToString(Math.Ceiling(Discount.Apply(Items) * Amount));
            labelInfo.Text = Convert.ToString(Discount.Info);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Discount.Update(Items);
            labelInfo.Text = Convert.ToString(Discount.Info);
        }
    }
}
