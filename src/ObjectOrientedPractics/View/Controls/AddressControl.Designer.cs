namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            gbAddress = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            label10 = new Label();
            tbBuilding = new TextBox();
            tbApartment = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            tbCountry = new TextBox();
            tbCity = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            tbStreet = new TextBox();
            tbPostIndex = new TextBox();
            gbAddress.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gbAddress
            // 
            gbAddress.Controls.Add(tableLayoutPanel2);
            gbAddress.Controls.Add(tableLayoutPanel1);
            gbAddress.Controls.Add(label7);
            gbAddress.Controls.Add(label4);
            gbAddress.Controls.Add(tbStreet);
            gbAddress.Controls.Add(tbPostIndex);
            gbAddress.Dock = DockStyle.Fill;
            gbAddress.Location = new Point(0, 0);
            gbAddress.Name = "gbAddress";
            gbAddress.Size = new Size(319, 150);
            gbAddress.TabIndex = 20;
            gbAddress.TabStop = false;
            gbAddress.Text = "Address:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.8571434F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.1428566F));
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(label10, 2, 0);
            tableLayoutPanel2.Controls.Add(tbBuilding, 1, 0);
            tableLayoutPanel2.Controls.Add(tbApartment, 3, 0);
            tableLayoutPanel2.Location = new Point(23, 117);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(271, 29);
            tableLayoutPanel2.TabIndex = 32;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 29);
            label8.TabIndex = 28;
            label8.Text = "Building:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(138, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 29);
            label10.TabIndex = 30;
            label10.Text = "Apartment:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbBuilding
            // 
            tbBuilding.Dock = DockStyle.Fill;
            tbBuilding.Location = new Point(66, 2);
            tbBuilding.Margin = new Padding(3, 2, 3, 2);
            tbBuilding.Name = "tbBuilding";
            tbBuilding.Size = new Size(66, 23);
            tbBuilding.TabIndex = 24;
            tbBuilding.TextChanged += tbBuilding_TextChanged;
            // 
            // tbApartment
            // 
            tbApartment.Dock = DockStyle.Fill;
            tbApartment.Location = new Point(213, 2);
            tbApartment.Margin = new Padding(3, 2, 3, 2);
            tbApartment.Name = "tbApartment";
            tbApartment.Size = new Size(55, 23);
            tbApartment.TabIndex = 23;
            tbApartment.TextChanged += tbApartment_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.8571434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.1428566F));
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(tbCountry, 1, 0);
            tableLayoutPanel1.Controls.Add(tbCity, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Location = new Point(20, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(271, 29);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(159, 0);
            label9.Name = "label9";
            label9.Size = new Size(34, 29);
            label9.TabIndex = 29;
            label9.Text = "City:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbCountry
            // 
            tbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCountry.Location = new Point(70, 2);
            tbCountry.Margin = new Padding(3, 2, 3, 2);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(83, 23);
            tbCountry.TabIndex = 20;
            tbCountry.TextChanged += tbCountry_TextChanged;
            // 
            // tbCity
            // 
            tbCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCity.Location = new Point(199, 2);
            tbCity.Margin = new Padding(3, 2, 3, 2);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(69, 23);
            tbCity.TabIndex = 22;
            tbCity.TextChanged += tbCity_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 29);
            label6.TabIndex = 26;
            label6.Text = "Country:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(23, 92);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "Street:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(15, 30);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 25;
            label4.Text = "Post Index:";
            // 
            // tbStreet
            // 
            tbStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbStreet.Location = new Point(89, 89);
            tbStreet.Margin = new Padding(3, 2, 3, 2);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(202, 23);
            tbStreet.TabIndex = 21;
            tbStreet.TextChanged += tbStreet_TextChanged;
            // 
            // tbPostIndex
            // 
            tbPostIndex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPostIndex.Location = new Point(89, 27);
            tbPostIndex.Margin = new Padding(3, 2, 3, 2);
            tbPostIndex.Name = "tbPostIndex";
            tbPostIndex.Size = new Size(199, 23);
            tbPostIndex.TabIndex = 19;
            tbPostIndex.TextChanged += tbPostIndex_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbAddress);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddressControl";
            Size = new Size(319, 150);
            gbAddress.ResumeLayout(false);
            gbAddress.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
