namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            lbItems = new ListBox();
            btnDelete = new Button();
            btnAddNew = new Button();
            gbItems = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbDescrption = new TextBox();
            tbName = new TextBox();
            tbCost = new TextBox();
            tbID = new TextBox();
            label5 = new Label();
            gbItems.SuspendLayout();
            SuspendLayout();
            // 
            // lbItems
            // 
            lbItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbItems.FormattingEnabled = true;
            lbItems.Location = new Point(12, 44);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(335, 384);
            lbItems.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(127, 457);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 46);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.Location = new Point(12, 457);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 46);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // gbItems
            // 
            gbItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbItems.Controls.Add(label4);
            gbItems.Controls.Add(label3);
            gbItems.Controls.Add(label2);
            gbItems.Controls.Add(label1);
            gbItems.Controls.Add(tbDescrption);
            gbItems.Controls.Add(tbName);
            gbItems.Controls.Add(tbCost);
            gbItems.Controls.Add(tbID);
            gbItems.Location = new Point(353, 36);
            gbItems.Name = "gbItems";
            gbItems.Size = new Size(418, 467);
            gbItems.TabIndex = 3;
            gbItems.TabStop = false;
            gbItems.Text = "Selected Item";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(24, 269);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "Descrption:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(24, 137);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Cost:";
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
            // tbDescrption
            // 
            tbDescrption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescrption.Location = new Point(24, 292);
            tbDescrption.Multiline = true;
            tbDescrption.Name = "tbDescrption";
            tbDescrption.ScrollBars = ScrollBars.Vertical;
            tbDescrption.Size = new Size(388, 149);
            tbDescrption.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(24, 160);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 106);
            tbName.TabIndex = 2;
            // 
            // tbCost
            // 
            tbCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCost.Location = new Point(74, 83);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(107, 27);
            tbCost.TabIndex = 1;
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(74, 40);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(107, 27);
            tbID.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 24);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "Items";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(gbItems);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(lbItems);
            Name = "ItemsTab";
            Size = new Size(800, 521);
            gbItems.ResumeLayout(false);
            gbItems.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbItems;
        private Button btnDelete;
        private Button btnAddNew;
        private GroupBox gbItems;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbDescrption;
        private TextBox tbName;
        private TextBox tbCost;
        private TextBox tbID;
        private Label label5;
    }
}
