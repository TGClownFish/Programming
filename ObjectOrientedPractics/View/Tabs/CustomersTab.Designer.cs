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
            label2 = new Label();
            label1 = new Label();
            tbName = new TextBox();
            tbID = new TextBox();
            btnAddNew = new Button();
            btnDelete = new Button();
            lbCustomers = new ListBox();
            addressControl1 = new Controls.AddressControl();
            gbCusomers.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 21);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 13;
            label5.Text = "Cusomers";
            // 
            // gbCusomers
            // 
            gbCusomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbCusomers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbCusomers.Controls.Add(addressControl1);
            gbCusomers.Controls.Add(label2);
            gbCusomers.Controls.Add(label1);
            gbCusomers.Controls.Add(tbName);
            gbCusomers.Controls.Add(tbID);
            gbCusomers.Location = new Point(355, 28);
            gbCusomers.Name = "gbCusomers";
            gbCusomers.Size = new Size(421, 492);
            gbCusomers.TabIndex = 12;
            gbCusomers.TabStop = false;
            gbCusomers.Text = "Selected Customer:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbName.Location = new Point(109, 83);
            tbName.Name = "tbName";
            tbName.Size = new Size(291, 27);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Leave += tbName_Leave;
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(109, 40);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(124, 27);
            tbID.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.Location = new Point(21, 479);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 45);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(136, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 45);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCustomers.FormattingEnabled = true;
            lbCustomers.Location = new Point(21, 41);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(329, 424);
            lbCustomers.TabIndex = 9;
            lbCustomers.SelectedIndexChanged += lbCusomers_SelectedIndexChanged;
            // 
            // addressControl1
            // 
            addressControl1.Location = new Point(6, 116);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(558, 286);
            addressControl1.TabIndex = 6;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(gbCusomers);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(lbCustomers);
            Name = "CustomersTab";
            Size = new Size(793, 547);
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
    }
}
