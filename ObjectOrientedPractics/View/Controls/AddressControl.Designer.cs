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
            gbAddress.SuspendLayout();
            SuspendLayout();
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
            gbAddress.Location = new Point(3, 3);
            gbAddress.Name = "gbAddress";
            gbAddress.Size = new Size(368, 160);
            gbAddress.TabIndex = 20;
            gbAddress.TabStop = false;
            gbAddress.Text = "Address:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(182, 123);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 30;
            label10.Text = "Apartment:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(209, 60);
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
            label8.Location = new Point(20, 123);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 28;
            label8.Text = "Building:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(20, 90);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "Street:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(20, 60);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 26;
            label6.Text = "Country:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 25;
            label4.Text = "Post Index:";
            // 
            // tbBuilding
            // 
            tbBuilding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbBuilding.Location = new Point(94, 117);
            tbBuilding.Margin = new Padding(3, 2, 3, 2);
            tbBuilding.Name = "tbBuilding";
            tbBuilding.Size = new Size(80, 23);
            tbBuilding.TabIndex = 24;
            // 
            // tbApartment
            // 
            tbApartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbApartment.Location = new Point(255, 120);
            tbApartment.Margin = new Padding(3, 2, 3, 2);
            tbApartment.Name = "tbApartment";
            tbApartment.Size = new Size(94, 23);
            tbApartment.TabIndex = 23;
            // 
            // tbCity
            // 
            tbCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCity.Location = new Point(246, 57);
            tbCity.Margin = new Padding(3, 2, 3, 2);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(103, 23);
            tbCity.TabIndex = 22;
            // 
            // tbStreet
            // 
            tbStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbStreet.Location = new Point(94, 87);
            tbStreet.Margin = new Padding(3, 2, 3, 2);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(255, 23);
            tbStreet.TabIndex = 21;
            // 
            // tbCountry
            // 
            tbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCountry.Location = new Point(94, 57);
            tbCountry.Margin = new Padding(3, 2, 3, 2);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(109, 23);
            tbCountry.TabIndex = 20;
            // 
            // tbPostIndex
            // 
            tbPostIndex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPostIndex.Location = new Point(94, 27);
            tbPostIndex.Margin = new Padding(3, 2, 3, 2);
            tbPostIndex.Name = "tbPostIndex";
            tbPostIndex.Size = new Size(109, 23);
            tbPostIndex.TabIndex = 19;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbAddress);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddressControl";
            Size = new Size(376, 169);
            gbAddress.ResumeLayout(false);
            gbAddress.PerformLayout();
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
    }
}
