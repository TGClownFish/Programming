namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            labelAmount = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbCustomers = new ComboBox();
            btnAddToCart = new Button();
            lbCart = new ListBox();
            lbItems = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCreateOrder = new Button();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAmount.ImageAlign = ContentAlignment.MiddleRight;
            labelAmount.Location = new Point(3, 68);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(39, 25);
            labelAmount.TabIndex = 23;
            labelAmount.Text = "0,0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 53);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 22;
            label4.Text = "Amount:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 20);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 21;
            label3.Text = "Cart:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 20;
            label2.Text = "Customers:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 19;
            label1.Text = "Items:";
            // 
            // cbCustomers
            // 
            cbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(45, 17);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(344, 23);
            cbCustomers.TabIndex = 18;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // btnAddToCart
            // 
            btnAddToCart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddToCart.Dock = DockStyle.Fill;
            btnAddToCart.Location = new Point(3, 3);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(77, 34);
            btnAddToCart.TabIndex = 14;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbCart
            // 
            lbCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCart.FormattingEnabled = true;
            lbCart.ItemHeight = 15;
            lbCart.Location = new Point(3, 65);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(386, 304);
            lbCart.TabIndex = 13;
            // 
            // lbItems
            // 
            lbItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbItems.FormattingEnabled = true;
            lbItems.ItemHeight = 15;
            lbItems.Location = new Point(6, 30);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(282, 409);
            lbItems.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1228065F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.87719F));
            tableLayoutPanel2.Controls.Add(btnAddToCart, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 451);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(285, 40);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(lbItems);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(690, 512);
            splitContainer1.SplitterDistance = 291;
            splitContainer1.TabIndex = 25;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lbCart);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(cbCustomers);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Panel2.Controls.Add(labelAmount);
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(395, 512);
            splitContainer2.SplitterDistance = 373;
            splitContainer2.SplitterWidth = 10;
            splitContainer2.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.35294F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel1.Controls.Add(btnCreateOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRemoveItem, 2, 0);
            tableLayoutPanel1.Controls.Add(btnClearCart, 3, 0);
            tableLayoutPanel1.Location = new Point(0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(392, 47);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Dock = DockStyle.Fill;
            btnCreateOrder.Location = new Point(3, 3);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(82, 41);
            btnCreateOrder.TabIndex = 15;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Dock = DockStyle.Fill;
            btnRemoveItem.Location = new Point(217, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(82, 41);
            btnRemoveItem.TabIndex = 16;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Dock = DockStyle.Fill;
            btnClearCart.Location = new Point(305, 3);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(84, 41);
            btnClearCart.TabIndex = 17;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = true;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CartsTab";
            Size = new Size(690, 512);
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelAmount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbCustomers;
        private Button btnAddToCart;
        private ListBox lbCart;
        private ListBox lbItems;
        private TableLayoutPanel tableLayoutPanel2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCreateOrder;
        private Button btnRemoveItem;
        private Button btnClearCart;
    }
}
