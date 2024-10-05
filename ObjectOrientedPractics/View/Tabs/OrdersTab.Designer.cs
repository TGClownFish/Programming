namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address2 = new Model.Address();
            tlpOrders = new TableLayoutPanel();
            tbId = new TextBox();
            cbStatus = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            tbCreated = new TextBox();
            lbOrderItems = new ListBox();
            labelAmount = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // tlpOrders
            // 
            tlpOrders.ColumnCount = 2;
            tlpOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOrders.Location = new Point(14, 18);
            tlpOrders.Name = "tlpOrders";
            tlpOrders.RowCount = 2;
            tlpOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpOrders.Size = new Size(288, 430);
            tlpOrders.TabIndex = 0;
            // 
            // tbId
            // 
            tbId.Location = new Point(322, 18);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(570, 18);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(107, 23);
            cbStatus.TabIndex = 3;
            // 
            // addressControl1
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = "000000";
            address2.Street = "";
            addressControl1.Address = address2;
            addressControl1.Location = new Point(322, 46);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(352, 222);
            addressControl1.TabIndex = 4;
            // 
            // tbCreated
            // 
            tbCreated.Location = new Point(446, 18);
            tbCreated.Name = "tbCreated";
            tbCreated.Size = new Size(100, 23);
            tbCreated.TabIndex = 2;
            // 
            // lbOrderItems
            // 
            lbOrderItems.FormattingEnabled = true;
            lbOrderItems.ItemHeight = 15;
            lbOrderItems.Location = new Point(322, 294);
            lbOrderItems.Name = "lbOrderItems";
            lbOrderItems.Size = new Size(355, 154);
            lbOrderItems.TabIndex = 5;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAmount.ImageAlign = ContentAlignment.MiddleRight;
            labelAmount.Location = new Point(638, 478);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(39, 25);
            labelAmount.TabIndex = 25;
            labelAmount.Text = "0,0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(622, 463);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 24;
            label4.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 26;
            label1.Text = "Orders:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 27;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 28;
            label3.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 29;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 276);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 30;
            label6.Text = "Order Items:";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAmount);
            Controls.Add(label4);
            Controls.Add(lbOrderItems);
            Controls.Add(addressControl1);
            Controls.Add(cbStatus);
            Controls.Add(tbCreated);
            Controls.Add(tbId);
            Controls.Add(tlpOrders);
            Name = "OrdersTab";
            Size = new Size(690, 512);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpOrders;
        private TextBox tbId;
        private ComboBox cbStatus;
        private Controls.AddressControl addressControl1;
        private TextBox tbCreated;
        private ListBox lbOrderItems;
        private Label labelAmount;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}
