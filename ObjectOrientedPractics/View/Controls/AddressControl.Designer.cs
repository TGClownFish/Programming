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
            gbAddress.Location = new Point(3, 4);
            gbAddress.Margin = new Padding(3, 4, 3, 4);
            gbAddress.Name = "gbAddress";
            gbAddress.Padding = new Padding(3, 4, 3, 4);
            gbAddress.Size = new Size(421, 213);
            gbAddress.TabIndex = 20;
            gbAddress.TabStop = false;
            gbAddress.Text = "Address:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(208, 164);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 30;
            label10.Text = "Apartment:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(239, 80);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 29;
            label9.Text = "City:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 1, true);
            label8.Location = new Point(23, 164);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 28;
            label8.Text = "Building:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(23, 120);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 27;
            label7.Text = "Street:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(23, 80);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 26;
            label6.Text = "Country:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(23, 40);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 25;
            label4.Text = "Post Index:";
            // 
            // tbBuilding
            // 
            tbBuilding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbBuilding.Location = new Point(107, 156);
            tbBuilding.Name = "tbBuilding";
            tbBuilding.Size = new Size(91, 27);
            tbBuilding.TabIndex = 24;
            // 
            // tbApartment
            // 
            tbApartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbApartment.Location = new Point(291, 160);
            tbApartment.Name = "tbApartment";
            tbApartment.Size = new Size(107, 27);
            tbApartment.TabIndex = 23;
            // 
            // tbCity
            // 
            tbCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCity.Location = new Point(281, 76);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(117, 27);
            tbCity.TabIndex = 22;
            // 
            // tbStreet
            // 
            tbStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbStreet.Location = new Point(107, 116);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(291, 27);
            tbStreet.TabIndex = 21;
            // 
            // tbCountry
            // 
            tbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCountry.Location = new Point(107, 76);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(124, 27);
            tbCountry.TabIndex = 20;
            // 
            // tbPostIndex
            // 
            tbPostIndex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPostIndex.Location = new Point(107, 36);
            tbPostIndex.Name = "tbPostIndex";
            tbPostIndex.Size = new Size(124, 27);
            tbPostIndex.TabIndex = 19;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbAddress);
            Name = "AddressControl";
            Size = new Size(446, 229);
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
