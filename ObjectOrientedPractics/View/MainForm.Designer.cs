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
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(708, 422);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 422);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(724, 404);
            Name = "MainForm";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private View.Tabs.CustomersTab customersTab;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab itemsTab;
        private TabControl tabControl1;
    }
}
