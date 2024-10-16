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
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCreateOrder = new Button();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(labelAmount, 2);
            labelAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAmount.ImageAlign = ContentAlignment.MiddleLeft;
            labelAmount.Location = new Point(3, 482);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(69, 25);
            labelAmount.TabIndex = 23;
            labelAmount.Text = "0,0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(label4, 2);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 464);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 22;
            label4.Text = "Amount:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 21;
            label3.Text = "Cart:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(label2, 2);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 20;
            label2.Text = "Customers:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 19;
            label1.Text = "Items:";
            // 
            // cbCustomers
            // 
            tableLayoutPanel3.SetColumnSpan(cbCustomers, 2);
            cbCustomers.Dock = DockStyle.Fill;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(42, 3);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(350, 23);
            cbCustomers.TabIndex = 18;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // btnAddToCart
            // 
            btnAddToCart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddToCart.Dock = DockStyle.Fill;
            btnAddToCart.Location = new Point(3, 472);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(78, 37);
            btnAddToCart.TabIndex = 14;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbCart
            // 
            lbCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.SetColumnSpan(lbCart, 3);
            lbCart.FormattingEnabled = true;
            lbCart.ItemHeight = 15;
            lbCart.Location = new Point(3, 46);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(389, 349);
            lbCart.TabIndex = 13;
            // 
            // lbItems
            // 
            tableLayoutPanel2.SetColumnSpan(lbItems, 2);
            lbItems.Dock = DockStyle.Fill;
            lbItems.FormattingEnabled = true;
            lbItems.ItemHeight = 15;
            lbItems.Location = new Point(3, 23);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(285, 443);
            lbItems.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.12281F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.87719F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(lbItems, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAddToCart, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(291, 512);
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
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Size = new Size(690, 512);
            splitContainer1.SplitterDistance = 291;
            splitContainer1.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label4, 0, 4);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(labelAmount, 0, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutPanel3.Controls.Add(cbCustomers, 1, 0);
            tableLayoutPanel3.Controls.Add(lbCart, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(395, 512);
            tableLayoutPanel3.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.35294F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5490189F));
            tableLayoutPanel1.Controls.Add(btnCreateOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRemoveItem, 2, 0);
            tableLayoutPanel1.Controls.Add(btnClearCart, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 414);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(389, 46);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Dock = DockStyle.Fill;
            btnCreateOrder.Location = new Point(3, 3);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(81, 40);
            btnCreateOrder.TabIndex = 15;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Dock = DockStyle.Fill;
            btnRemoveItem.Location = new Point(215, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(81, 40);
            btnRemoveItem.TabIndex = 16;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Dock = DockStyle.Fill;
            btnClearCart.Location = new Point(302, 3);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(84, 40);
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
            tableLayoutPanel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCreateOrder;
        private Button btnRemoveItem;
        private Button btnClearCart;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
