﻿using ObjectOrientedPractics.Model.Classes;

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
            tableLayoutPanel1 = new TableLayoutPanel();
            addressControl = new Controls.AddressControl();
            chbPriority = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
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
            tableLayoutPanel1.SuspendLayout();
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
            lbCustomers.Location = new Point(3, 31);
            lbCustomers.Margin = new Padding(3, 2, 3, 2);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(239, 379);
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
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(addressControl, 0, 4);
            tableLayoutPanel1.Controls.Add(chbPriority, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tbID, 1, 1);
            tableLayoutPanel1.Controls.Add(tbName, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 342F));
            tableLayoutPanel1.Size = new Size(442, 457);
            tableLayoutPanel1.TabIndex = 27;
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
            tableLayoutPanel1.SetColumnSpan(addressControl, 2);
            addressControl.Dock = DockStyle.Fill;
            addressControl.IsReadOnly = false;
            addressControl.Location = new Point(3, 110);
            addressControl.Margin = new Padding(3, 2, 3, 2);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(436, 345);
            addressControl.TabIndex = 6;
            // 
            // chbPriority
            // 
            chbPriority.AutoSize = true;
            chbPriority.Location = new Point(3, 81);
            chbPriority.Name = "chbPriority";
            chbPriority.Size = new Size(75, 19);
            chbPriority.TabIndex = 7;
            chbPriority.Text = "Is Priority";
            chbPriority.UseVisualStyleBackColor = false;
            chbPriority.CheckedChanged += chbPriority_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 6;
            label3.Text = "Selected Customer:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(119, 23);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(109, 23);
            tbID.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(119, 54);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(320, 22);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Leave += tbName_Leave;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Button btnAddNew;
        private Button btnDelete;
        private ListBox lbCustomers;
        private Controls.AddressControl addressControl1;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox tbID;
        private TextBox tbName;
        public Controls.AddressControl addressControl;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private CheckBox chbPriority;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
