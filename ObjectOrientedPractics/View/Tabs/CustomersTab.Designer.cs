using ObjectOrientedPractics.Model.Classes;

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
            Address address1 = new Address();
            label5 = new Label();
            btnAddNew = new Button();
            btnDelete = new Button();
            lbCustomers = new ListBox();
            splitContainer1 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            chbPriority = new CheckBox();
            addressControl = new Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Customers:";
            // 
            // btnAddNew
            // 
            btnAddNew.Dock = DockStyle.Fill;
            btnAddNew.Location = new Point(0, 0);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(95, 29);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(0, 0);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 29);
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
            lbCustomers.Location = new Point(3, 27);
            lbCustomers.Margin = new Padding(3, 2, 3, 2);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(233, 379);
            lbCustomers.TabIndex = 9;
            lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(690, 457);
            splitContainer1.SplitterDistance = 244;
            splitContainer1.TabIndex = 7;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(lbCustomers);
            splitContainer4.Panel1.Controls.Add(label5);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer3);
            splitContainer4.Size = new Size(244, 457);
            splitContainer4.SplitterDistance = 424;
            splitContainer4.TabIndex = 15;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(btnAddNew);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btnDelete);
            splitContainer3.Size = new Size(244, 29);
            splitContainer3.SplitterDistance = 95;
            splitContainer3.SplitterIncrement = 5;
            splitContainer3.SplitterWidth = 50;
            splitContainer3.TabIndex = 14;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(chbPriority);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(tbID);
            splitContainer2.Panel1.Controls.Add(tbName);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(addressControl);
            splitContainer2.Size = new Size(442, 457);
            splitContainer2.SplitterDistance = 97;
            splitContainer2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Selected Customer:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Full Name:";
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(77, 25);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(109, 23);
            tbID.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(77, 57);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(336, 23);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Leave += tbName_Leave;
            // 
            // chbPriority
            // 
            chbPriority.AutoSize = true;
            chbPriority.Location = new Point(192, 27);
            chbPriority.Name = "chbPriority";
            chbPriority.Size = new Size(75, 19);
            chbPriority.TabIndex = 7;
            chbPriority.Text = "Is Priority";
            chbPriority.UseVisualStyleBackColor = false;
            chbPriority.CheckedChanged += chbPriority_CheckedChanged;
            // 
            // addressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = "000000";
            address1.Street = "";
            addressControl.Address = address1;
            addressControl.Dock = DockStyle.Fill;
            addressControl.IsReadOnly = false;
            addressControl.Location = new Point(0, 0);
            addressControl.Margin = new Padding(3, 2, 3, 2);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(442, 356);
            addressControl.TabIndex = 6;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomersTab";
            Size = new Size(690, 457);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Button btnAddNew;
        private Button btnDelete;
        private ListBox lbCustomers;
        private Controls.AddressControl addressControl1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox tbID;
        private TextBox tbName;
        public Controls.AddressControl addressControl;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private CheckBox chbPriority;
    }
}
