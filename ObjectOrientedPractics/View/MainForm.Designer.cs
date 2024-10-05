namespace ObjectOrientedPractics
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
            tabPage2 = new TabPage();
            customersTab = new View.Tabs.CustomersTab();
            tabPage1 = new TabPage();
            itemsTab = new View.Tabs.ItemsTab();
            tabControl1 = new TabControl();
            tabPageCarts = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            tabPageOrders = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCarts.SuspendLayout();
            tabPageOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(700, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customersTab.Customers = null;
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 2);
            customersTab.Margin = new Padding(3, 2, 3, 2);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(694, 390);
            customersTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(700, 394);
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
            itemsTab.Size = new Size(694, 390);
            itemsTab.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPageCarts);
            tabControl1.Controls.Add(tabPageOrders);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(708, 422);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_TabIndexChanged;
            tabControl1.TabIndexChanged += tabControl1_TabIndexChanged;
            // 
            // tabPageCarts
            // 
            tabPageCarts.Controls.Add(cartsTab1);
            tabPageCarts.Location = new Point(4, 24);
            tabPageCarts.Name = "tabPageCarts";
            tabPageCarts.Size = new Size(700, 394);
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
            cartsTab1.Size = new Size(700, 394);
            cartsTab1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(ordersTab1);
            tabPageOrders.Location = new Point(4, 24);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.Size = new Size(700, 394);
            tabPageOrders.TabIndex = 3;
            tabPageOrders.Text = "Orders";
            tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(700, 394);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 422);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(724, 461);
            Name = "MainForm";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageCarts.ResumeLayout(false);
            tabPageOrders.ResumeLayout(false);
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
    }
}
