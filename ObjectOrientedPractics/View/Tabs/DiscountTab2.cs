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
        public PointsDiscount PointsDiscount { get; set; } = new PointsDiscount(300);
        public List<Item> Items { get; set; } = new List<Item>();
        public List<PercentDiscount> PercentDiscounts { get; set; } = new List<PercentDiscount>();
        public double Amount
        {
            get
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
            Items.Add(new Model.Classes.Item("fff", "55", 1340, Category.Clothes));
            Items.Add(new Model.Classes.Item("faaa", "ada", 222, Category.Toys));
            Items.Add(new Model.Classes.Item("","", 2145, Category.PersonalCare));
            for (int i = 0; i < Enum.GetNames(typeof(Category)).Length; i++)
            {
                PercentDiscounts.Add(new PercentDiscount((Category)i));
            }
            PercentDiscounts.RemoveAt(0);

            InitializeComponent();
            labelInfo.Text = Convert.ToString(PointsDiscount.Info);
            label1.Text = Convert.ToString(PercentDiscounts[0].Info);
            label3.Text = Convert.ToString(PercentDiscounts[1].Info);
            label5.Text = Convert.ToString(PercentDiscounts[2].Info);
            label6.Text = Convert.ToString(PercentDiscounts[3].Info);
            label7.Text = Convert.ToString(PercentDiscounts[4].Info);
            label8.Text = Convert.ToString(PercentDiscounts[5].Info);
            label9.Text = Convert.ToString(PercentDiscounts[6].Info);
            labelProductAmount.Text = Convert.ToString(Amount);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            labelDiscountAmout.Text = $" {Convert.ToString(Math.Ceiling(PointsDiscount.Calculate(Items) * Amount))} — {PointsDiscount.Calculate(Items) * 100}%";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            labelDiscountAmout.Text = Convert.ToString(Math.Ceiling(PointsDiscount.Apply(Items) * Amount));
            labelInfo.Text = Convert.ToString(PointsDiscount.Info);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PointsDiscount.Update(Items);
            labelInfo.Text = Convert.ToString(PointsDiscount.Info);
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            label13.Text = $"{PercentDiscounts[0].Calculate(Items)}";
            label14.Text = $"{PercentDiscounts[1].Calculate(Items)}";
            label15.Text = $"{PercentDiscounts[2].Calculate(Items)}";
            label16.Text = $"{PercentDiscounts[3].Calculate(Items)}";
            label17.Text = $"{PercentDiscounts[4].Calculate(Items)}";
            label18.Text = $"{PercentDiscounts[5].Calculate(Items)}";
            label19.Text = $"{PercentDiscounts[6].Calculate(Items)}";
        }

        private void btnApply2_Click(object sender, EventArgs e)
        {
            label13.Text = $"{PercentDiscounts[0].Apply(Items)} - {PercentDiscounts[0].AmountSpent}";
            label14.Text = $"{PercentDiscounts[1].Apply(Items)} - {PercentDiscounts[1].AmountSpent}";
            label15.Text = $"{PercentDiscounts[2].Apply(Items)} - {PercentDiscounts[2].AmountSpent}";
            label16.Text = $"{PercentDiscounts[3].Apply(Items)} - {PercentDiscounts[3].AmountSpent}";
            label17.Text = $"{PercentDiscounts[4].Apply(Items)} - {PercentDiscounts[4].AmountSpent}";
            label18.Text = $"{PercentDiscounts[5].Apply(Items)} - {PercentDiscounts[5].AmountSpent}";
            label19.Text = $"{PercentDiscounts[6].Apply(Items)} - {PercentDiscounts[6].AmountSpent}";
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            PercentDiscounts[0].Update();
            PercentDiscounts[1].Update();
            PercentDiscounts[2].Update();
            PercentDiscounts[3].Update();
            PercentDiscounts[4].Update();
            PercentDiscounts[5].Update();
            PercentDiscounts[6].Update();

            label1.Text = Convert.ToString(PercentDiscounts[0].Info);
            label3.Text = Convert.ToString(PercentDiscounts[1].Info);
            label5.Text = Convert.ToString(PercentDiscounts[2].Info);
            label6.Text = Convert.ToString(PercentDiscounts[3].Info);
            label7.Text = Convert.ToString(PercentDiscounts[4].Info);
            label8.Text = Convert.ToString(PercentDiscounts[5].Info);
            label9.Text = Convert.ToString(PercentDiscounts[6].Info);
        }
    }
}
