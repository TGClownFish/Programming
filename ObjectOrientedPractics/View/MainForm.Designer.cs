﻿namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Model.Classes.Orders.PriorityOrder priorityOrder1 = new Model.Classes.Orders.PriorityOrder();
            Model.Classes.Address address1 = new Model.Classes.Address();
            Model.Classes.Discounts.PointsDiscount pointsDiscount1 = new Model.Classes.Discounts.PointsDiscount();
            tabPage2 = new TabPage();
            customersTab = new View.Tabs.CustomersTab();
            tabPage1 = new TabPage();
            itemsTab = new View.Tabs.ItemsTab();
            tabControl1 = new TabControl();
            tabPageCarts = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            tabPageOrders = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            tabPage3 = new TabPage();
            priorityOrdersTab1 = new View.Tabs.PriorityOrdersTab();
            tabPage4 = new TabPage();
            discountTab21 = new View.Tabs.DiscountTab2();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCarts.SuspendLayout();
            tabPageOrders.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.AddedCategoryNames = (List<string>)resources.GetObject("customersTab.AddedCategoryNames");
            customersTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customersTab.Customers = null;
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 2);
            customersTab.Margin = new Padding(3, 2, 3, 2);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(186, 68);
            customersTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(700, 433);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Items = null;
            itemsTab.Location = new Point(3, 2);
            itemsTab.Margin = new Padding(3, 2, 3, 2);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(694, 429);
            itemsTab.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPageCarts);
            tabControl1.Controls.Add(tabPageOrders);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(708, 461);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_TabIndexChanged;
            tabControl1.TabIndexChanged += tabControl1_TabIndexChanged;
            // 
            // tabPageCarts
            // 
            tabPageCarts.Controls.Add(cartsTab1);
            tabPageCarts.Location = new Point(4, 24);
            tabPageCarts.Name = "tabPageCarts";
            tabPageCarts.Size = new Size(192, 72);
            tabPageCarts.TabIndex = 2;
            tabPageCarts.Text = "Carts";
            tabPageCarts.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(192, 72);
            cartsTab1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(ordersTab1);
            tabPageOrders.Location = new Point(4, 24);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.Size = new Size(192, 72);
            tabPageOrders.TabIndex = 3;
            tabPageOrders.Text = "Orders";
            tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(192, 72);
            ordersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(priorityOrdersTab1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(192, 72);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Items = null;
            priorityOrdersTab1.Location = new Point(3, 3);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = "000000";
            address1.Street = "";
            priorityOrder1.Address = address1;
            priorityOrder1.DesiredDeliveryDate = new DateTime(2024, 10, 20, 0, 0, 0, 0);
            priorityOrder1.DesiredDeliveryTime = Model.Enums.DeliveryTime.None;
            priorityOrder1.DiscountAmount = 0D;
            priorityOrder1.Status = Model.Enums.OrderStatus.New;
            priorityOrdersTab1.PriorityOrder = priorityOrder1;
            priorityOrdersTab1.Size = new Size(186, 66);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(discountTab21);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(192, 72);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // discountTab21
            // 
            discountTab21.Dock = DockStyle.Fill;
            discountTab21.Location = new Point(0, 0);
            discountTab21.Name = "discountTab21";
            pointsDiscount1.Points = 300;
            discountTab21.PointsDiscount = pointsDiscount1;
            discountTab21.Size = new Size(192, 72);
            discountTab21.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 461);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(724, 470);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageCarts.ResumeLayout(false);
            tabPageOrders.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private View.Tabs.CustomersTab customersTab;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab itemsTab;
        private TabControl tabControl1;
        private TabPage tabPageCarts;
        private TabPage tabPageOrders;
        private View.Tabs.OrdersTab ordersTab1;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage tabPage3;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
        private TabPage tabPage4;
        private View.Tabs.DiscountTab2 discountTab21;
    }
}
