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
            btnClearCart = new Button();
            btnRemoveItem = new Button();
            btnCreateOrder = new Button();
            btnAddToCart = new Button();
            lbCart = new ListBox();
            lbItems = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAmount.ImageAlign = ContentAlignment.MiddleRight;
            labelAmount.Location = new Point(410, 297);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(39, 25);
            labelAmount.TabIndex = 23;
            labelAmount.Text = "0,0";
            labelAmount.Click += labelAmount_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(394, 282);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 22;
            label4.Text = "Amount:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 21;
            label3.Text = "Cart:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 20;
            label2.Text = "Customers:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 19;
            label1.Text = "Items:";
            // 
            // cbCustomers
            // 
            cbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(76, 16);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(373, 23);
            cbCustomers.TabIndex = 18;
            // 
            // btnClearCart
            // 
            btnClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearCart.Location = new Point(374, 328);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(75, 40);
            btnClearCart.TabIndex = 17;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveItem.Location = new Point(278, 328);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(90, 40);
            btnRemoveItem.TabIndex = 16;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateOrder.Location = new Point(5, 328);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(87, 40);
            btnCreateOrder.TabIndex = 15;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddToCart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddToCart.Location = new Point(3, 469);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(79, 40);
            btnAddToCart.TabIndex = 14;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // lbCart
            // 
            lbCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCart.FormattingEnabled = true;
            lbCart.ItemHeight = 15;
            lbCart.Location = new Point(5, 65);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(444, 214);
            lbCart.TabIndex = 13;
            // 
            // lbItems
            // 
            lbItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbItems.FormattingEnabled = true;
            lbItems.ItemHeight = 15;
            lbItems.Location = new Point(3, 34);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(223, 409);
            lbItems.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(lbItems);
            panel1.Controls.Add(btnAddToCart);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 512);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(btnCreateOrder);
            panel2.Controls.Add(btnRemoveItem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(labelAmount);
            panel2.Controls.Add(cbCustomers);
            panel2.Controls.Add(btnClearCart);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lbCart);
            panel2.Location = new Point(238, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 512);
            panel2.TabIndex = 25;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(690, 512);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelAmount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbCustomers;
        private Button btnClearCart;
        private Button btnRemoveItem;
        private Button btnCreateOrder;
        private Button btnAddToCart;
        private ListBox lbCart;
        private ListBox lbItems;
        private Panel panel1;
        private Panel panel2;
    }
}
