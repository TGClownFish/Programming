namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Model.Address address3 = new Model.Address();
            label5 = new Label();
            gbCusomers = new GroupBox();
            addressControl = new Controls.AddressControl();
            label2 = new Label();
            label1 = new Label();
            tbName = new TextBox();
            tbID = new TextBox();
            btnAddNew = new Button();
            btnDelete = new Button();
            lbCustomers = new ListBox();
            gbCusomers.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 16);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Customers:";
            // 
            // gbCusomers
            // 
            gbCusomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbCusomers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbCusomers.Controls.Add(addressControl);
            gbCusomers.Controls.Add(label2);
            gbCusomers.Controls.Add(label1);
            gbCusomers.Controls.Add(tbName);
            gbCusomers.Controls.Add(tbID);
            gbCusomers.Location = new Point(205, 21);
            gbCusomers.Margin = new Padding(3, 2, 3, 2);
            gbCusomers.Name = "gbCusomers";
            gbCusomers.Padding = new Padding(3, 2, 3, 2);
            gbCusomers.Size = new Size(406, 380);
            gbCusomers.TabIndex = 12;
            gbCusomers.TabStop = false;
            gbCusomers.Text = "Selected Customer:";
            // 
            // addressControl
            // 
            address3.Apartment = "";
            address3.Building = "";
            address3.City = "";
            address3.Country = "";
            address3.Index = "000000";
            address3.Street = "";
            addressControl.Address = address3;
            addressControl.Location = new Point(6, 100);
            addressControl.Margin = new Padding(3, 2, 3, 2);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(390, 172);
            addressControl.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbName.Location = new Point(95, 62);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(281, 23);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Leave += tbName_Leave;
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(95, 30);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(109, 23);
            tbID.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.Location = new Point(18, 367);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(82, 34);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(117, 367);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCustomers.FormattingEnabled = true;
            lbCustomers.HorizontalScrollbar = true;
            lbCustomers.ItemHeight = 15;
            lbCustomers.Location = new Point(18, 33);
            lbCustomers.Margin = new Padding(3, 2, 3, 2);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(181, 319);
            lbCustomers.TabIndex = 9;
            lbCustomers.SelectedIndexChanged += lbCusomers_SelectedIndexChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(gbCusomers);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(lbCustomers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomersTab";
            Size = new Size(625, 424);
            gbCusomers.ResumeLayout(false);
            gbCusomers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox gbCusomers;
        private Label label2;
        private Label label1;
        private TextBox tbName;
        private TextBox tbID;
        private Button btnAddNew;
        private Button btnDelete;
        private ListBox lbCustomers;
        private Controls.AddressControl addressControl1;
        public Controls.AddressControl addressControl;
    }
}
