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
            tbDescription = new TextBox();
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
            lbItems.ItemHeight = 15;
            lbItems.Location = new Point(10, 33);
            lbItems.Margin = new Padding(3, 2, 3, 2);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(288, 319);
            lbItems.TabIndex = 0;
            lbItems.SelectedIndexChanged += lbItems_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(111, 362);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.Location = new Point(10, 362);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(82, 34);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // gbItems
            // 
            gbItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbItems.Controls.Add(label4);
            gbItems.Controls.Add(label3);
            gbItems.Controls.Add(label2);
            gbItems.Controls.Add(label1);
            gbItems.Controls.Add(tbDescription);
            gbItems.Controls.Add(tbName);
            gbItems.Controls.Add(tbCost);
            gbItems.Controls.Add(tbID);
            gbItems.Location = new Point(303, 27);
            gbItems.Margin = new Padding(3, 2, 3, 2);
            gbItems.Name = "gbItems";
            gbItems.Padding = new Padding(3, 2, 3, 2);
            gbItems.Size = new Size(366, 369);
            gbItems.TabIndex = 3;
            gbItems.TabStop = false;
            gbItems.Text = "Selected Item";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(21, 202);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(21, 103);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Cost:";
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
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(21, 219);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(340, 132);
            tbDescription.TabIndex = 3;
            tbDescription.TextChanged += tbDescrption_TextChanged;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(21, 120);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(340, 80);
            tbName.TabIndex = 2;
            tbName.TextChanged += tbName_TextChanged;
            tbName.Leave += tbName_Leave;
            // 
            // tbCost
            // 
            tbCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbCost.Location = new Point(65, 62);
            tbCost.Margin = new Padding(3, 2, 3, 2);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(94, 23);
            tbCost.TabIndex = 1;
            tbCost.TextChanged += tbCost_TextChanged;
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(65, 30);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(94, 23);
            tbID.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 18);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Items";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(gbItems);
            Controls.Add(btnAddNew);
            Controls.Add(btnDelete);
            Controls.Add(lbItems);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ItemsTab";
            Size = new Size(694, 410);
            //Load += ItemsTab_Load;
            //Disposed += ItemsTab_Disposed;
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
        private TextBox tbDescription;
        private TextBox tbName;
        private TextBox tbCost;
        private TextBox tbID;
        private Label label5;
    }
}
