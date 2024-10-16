namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            Model.Classes.Address address2 = new Model.Classes.Address();
            addressControl1 = new Controls.AddressControl();
            cbStatus = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbDeliveryTime = new ComboBox();
            tbCreated = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            tbId = new TextBox();
            label7 = new Label();
            labelAmount = new Label();
            lbOrderItems = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.IsReadOnly = false;
            addressControl1.Location = new Point(9, 97);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(663, 153);
            addressControl1.TabIndex = 32;
            // 
            // cbStatus
            // 
            cbStatus.Dock = DockStyle.Fill;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(3, 63);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(327, 23);
            cbStatus.TabIndex = 3;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cbDeliveryTime, 1, 3);
            tableLayoutPanel1.Controls.Add(tbCreated, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(cbStatus, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(tbId, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 1, 2);
            tableLayoutPanel1.Location = new Point(6, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(666, 89);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // cbDeliveryTime
            // 
            cbDeliveryTime.Dock = DockStyle.Fill;
            cbDeliveryTime.FormattingEnabled = true;
            cbDeliveryTime.Items.AddRange(new object[] { "None", "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            cbDeliveryTime.Location = new Point(336, 63);
            cbDeliveryTime.Name = "cbDeliveryTime";
            cbDeliveryTime.Size = new Size(327, 23);
            cbDeliveryTime.TabIndex = 31;
            cbDeliveryTime.SelectedIndexChanged += cbDeliveryTime_SelectedIndexChanged;
            // 
            // tbCreated
            // 
            tbCreated.Dock = DockStyle.Fill;
            tbCreated.Location = new Point(336, 18);
            tbCreated.Name = "tbCreated";
            tbCreated.ReadOnly = true;
            tbCreated.Size = new Size(327, 23);
            tbCreated.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 27;
            label2.Text = "Id:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 28;
            label3.Text = "Created:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 44);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 29;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbId
            // 
            tbId.Dock = DockStyle.Fill;
            tbId.Location = new Point(3, 18);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(327, 23);
            tbId.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 44);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 30;
            label7.Text = "Delivery Time:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAmount.ImageAlign = ContentAlignment.MiddleRight;
            labelAmount.Location = new Point(153, 22);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(209, 25);
            labelAmount.TabIndex = 35;
            labelAmount.Text = "0,0";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbOrderItems
            // 
            lbOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbOrderItems.FormattingEnabled = true;
            lbOrderItems.ItemHeight = 15;
            lbOrderItems.Location = new Point(9, 259);
            lbOrderItems.Name = "lbOrderItems";
            lbOrderItems.Size = new Size(660, 124);
            lbOrderItems.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.35294F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel2.Controls.Add(btnAddItem, 0, 0);
            tableLayoutPanel2.Controls.Add(btnRemoveItem, 2, 0);
            tableLayoutPanel2.Controls.Add(btnClearCart, 3, 0);
            tableLayoutPanel2.Controls.Add(labelAmount, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 396);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(666, 47);
            tableLayoutPanel2.TabIndex = 38;
            // 
            // btnAddItem
            // 
            btnAddItem.Dock = DockStyle.Fill;
            btnAddItem.Location = new Point(3, 3);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(144, 41);
            btnAddItem.TabIndex = 15;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Dock = DockStyle.Fill;
            btnRemoveItem.Location = new Point(368, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(144, 41);
            btnRemoveItem.TabIndex = 16;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Dock = DockStyle.Fill;
            btnClearCart.Location = new Point(518, 3);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(145, 41);
            btnClearCart.TabIndex = 17;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = true;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lbOrderItems);
            Controls.Add(addressControl1);
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Size = new Size(690, 457);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.AddressControl addressControl1;
        private ComboBox cbStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbDeliveryTime;
        private TextBox tbCreated;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox tbId;
        private Label label7;
        private Label labelAmount;
        private ListBox lbOrderItems;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Button btnClearCart;
    }
}
