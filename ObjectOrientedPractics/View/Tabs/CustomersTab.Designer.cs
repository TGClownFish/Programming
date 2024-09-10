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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbAddress = new TextBox();
            tbName = new TextBox();
            tbID = new TextBox();
            btnAddNew = new Button();
            btnDelete = new Button();
            lbCusomers = new ListBox();
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
            gbCusomers.Controls.Add(label3);
            gbCusomers.Controls.Add(label2);
            gbCusomers.Controls.Add(label1);
            gbCusomers.Controls.Add(tbAddress);
            gbCusomers.Controls.Add(tbName);
            gbCusomers.Controls.Add(tbID);
            gbCusomers.Location = new Point(362, 32);
            gbCusomers.Name = "gbCusomers";
            gbCusomers.Size = new Size(421, 287);
            gbCusomers.TabIndex = 12;
            gbCusomers.TabStop = false;
            gbCusomers.Text = "Selected Customer";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(24, 137);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Address:";
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
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAddress.Location = new Point(24, 160);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.ScrollBars = ScrollBars.Vertical;
            tbAddress.Size = new Size(376, 106);
            tbAddress.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbName.Location = new Point(109, 83);
            tbName.Name = "tbName";
            tbName.Size = new Size(291, 27);
            tbName.TabIndex = 1;
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(109, 40);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(107, 27);
            tbID.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.Location = new Point(21, 454);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 46);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(136, 454);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 46);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbCusomers
            // 
            lbCusomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCusomers.FormattingEnabled = true;
            lbCusomers.Location = new Point(21, 41);
            lbCusomers.Name = "lbCusomers";
            lbCusomers.Size = new Size(335, 384);
            lbCusomers.TabIndex = 9;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(gbCusomers);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(lbCusomers);
            Name = "CustomersTab";
            Size = new Size(800, 521);
            gbCusomers.ResumeLayout(false);
            gbCusomers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox gbCusomers;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbAddress;
        private TextBox tbName;
        private TextBox tbID;
        private Button btnAddNew;
        private Button btnDelete;
        private ListBox lbCusomers;
    }
}
