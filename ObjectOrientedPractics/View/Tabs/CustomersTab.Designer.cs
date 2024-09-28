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
            label5 = new Label();
            gbCusomers = new GroupBox();
            gbAddress = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            tbBuilding = new TextBox();
            tbApartment = new TextBox();
            tbCity = new TextBox();
            tbStreet = new TextBox();
            tbCountry = new TextBox();
            tbPostIndex = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbName = new TextBox();
            tbID = new TextBox();
            btnAddNew = new Button();
            btnDelete = new Button();
            lbCustomers = new ListBox();
            gbCusomers.SuspendLayout();
            gbAddress.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 16);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Cusomers";
            // 
            // gbCusomers
            // 
            gbCusomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbCusomers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbCusomers.Controls.Add(gbAddress);
            gbCusomers.Controls.Add(label2);
            gbCusomers.Controls.Add(label1);
            gbCusomers.Controls.Add(tbName);
            gbCusomers.Controls.Add(tbID);
            gbCusomers.Location = new Point(311, 21);
            gbCusomers.Margin = new Padding(3, 2, 3, 2);
            gbCusomers.Name = "gbCusomers";
            gbCusomers.Padding = new Padding(3, 2, 3, 2);
            gbCusomers.Size = new Size(368, 369);
            gbCusomers.TabIndex = 12;
            gbCusomers.TabStop = false;
            gbCusomers.Text = "Selected Customer:";
            // 
            // gbAddress
            // 
            gbAddress.Controls.Add(label10);
            gbAddress.Controls.Add(label9);
            gbAddress.Controls.Add(label8);
            gbAddress.Controls.Add(label7);
            gbAddress.Controls.Add(label6);
            gbAddress.Controls.Add(label4);
            gbAddress.Controls.Add(tbBuilding);
            gbAddress.Controls.Add(tbApartment);
            gbAddress.Controls.Add(tbCity);
            gbAddress.Controls.Add(tbStreet);
            gbAddress.Controls.Add(tbCountry);
            gbAddress.Controls.Add(tbPostIndex);
            gbAddress.Location = new Point(1, 90);
            gbAddress.Name = "gbAddress";
            gbAddress.Size = new Size(368, 279);
            gbAddress.TabIndex = 19;
            gbAddress.TabStop = false;
            gbAddress.Text = "Address:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(182, 122);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 30;
            label10.Text = "Apartment:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(209, 59);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 29;
            label9.Text = "City:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            label8.Location = new Point(20, 122);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 28;
            label8.Text = "Building:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(20, 89);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "Street:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(20, 59);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 26;
            label6.Text = "Country:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(20, 29);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 25;
            label4.Text = "Post Index:";
            // 
            // tbBuilding
            // 
            tbBuilding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbBuilding.Location = new Point(94, 116);
            tbBuilding.Margin = new Padding(3, 2, 3, 2);
            tbBuilding.Name = "tbBuilding";
            tbBuilding.Size = new Size(80, 23);
            tbBuilding.TabIndex = 24;
            // 
            // tbApartment
            // 
            tbApartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbApartment.Location = new Point(255, 119);
            tbApartment.Margin = new Padding(3, 2, 3, 2);
            tbApartment.Name = "tbApartment";
            tbApartment.Size = new Size(94, 23);
            tbApartment.TabIndex = 23;
            // 
            // tbCity
            // 
            tbCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCity.Location = new Point(246, 56);
            tbCity.Margin = new Padding(3, 2, 3, 2);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(103, 23);
            tbCity.TabIndex = 22;
            // 
            // tbStreet
            // 
            tbStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbStreet.Location = new Point(94, 86);
            tbStreet.Margin = new Padding(3, 2, 3, 2);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(255, 23);
            tbStreet.TabIndex = 21;
            // 
            // tbCountry
            // 
            tbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCountry.Location = new Point(94, 56);
            tbCountry.Margin = new Padding(3, 2, 3, 2);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(109, 23);
            tbCountry.TabIndex = 20;
            // 
            // tbPostIndex
            // 
            tbPostIndex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPostIndex.Location = new Point(94, 26);
            tbPostIndex.Margin = new Padding(3, 2, 3, 2);
            tbPostIndex.Name = "tbPostIndex";
            tbPostIndex.Size = new Size(109, 23);
            tbPostIndex.TabIndex = 19;
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
            tbName.Size = new Size(255, 23);
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
            btnAddNew.Location = new Point(18, 359);
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
            btnDelete.Location = new Point(119, 359);
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
            lbCustomers.ItemHeight = 15;
            lbCustomers.Location = new Point(18, 31);
            lbCustomers.Margin = new Padding(3, 2, 3, 2);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(288, 319);
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
            Size = new Size(694, 410);
            Load += CustomersTab_Load;
            gbCusomers.ResumeLayout(false);
            gbCusomers.PerformLayout();
            gbAddress.ResumeLayout(false);
            gbAddress.PerformLayout();
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
        private GroupBox gbAddress;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox tbBuilding;
        private TextBox tbApartment;
        private TextBox tbCity;
        private TextBox tbStreet;
        private TextBox tbCountry;
        private TextBox tbPostIndex;
    }
}
