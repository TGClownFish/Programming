using ObjectOrientedPractics.Model.Classes;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            Address address1 = new Address();
            tbId = new TextBox();
            cbStatus = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            tbCreated = new TextBox();
            lbOrderItems = new ListBox();
            labelAmount = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvOrders = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnCreationDate = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Dock = DockStyle.Fill;
            tbId.Location = new Point(3, 18);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(116, 23);
            tbId.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.Dock = DockStyle.Fill;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(247, 18);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(116, 23);
            cbStatus.TabIndex = 3;
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = "000000";
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Location = new Point(3, 49);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(366, 220);
            addressControl1.TabIndex = 4;
            // 
            // tbCreated
            // 
            tbCreated.Dock = DockStyle.Fill;
            tbCreated.Location = new Point(125, 18);
            tbCreated.Name = "tbCreated";
            tbCreated.ReadOnly = true;
            tbCreated.Size = new Size(116, 23);
            tbCreated.TabIndex = 2;
            // 
            // lbOrderItems
            // 
            lbOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbOrderItems.FormattingEnabled = true;
            lbOrderItems.ItemHeight = 15;
            lbOrderItems.Location = new Point(3, 289);
            lbOrderItems.Name = "lbOrderItems";
            lbOrderItems.Size = new Size(366, 154);
            lbOrderItems.TabIndex = 5;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAmount.ImageAlign = ContentAlignment.MiddleRight;
            labelAmount.Location = new Point(268, 426);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(39, 25);
            labelAmount.TabIndex = 25;
            labelAmount.Text = "0,0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(252, 411);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 24;
            label4.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 26;
            label1.Text = "Orders:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 27;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 28;
            label3.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 29;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 271);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 30;
            label6.Text = "Order Items:";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnCreationDate, ColumnName, ColumnAddress, ColumnAmount, ColumnStatus });
            dgvOrders.Location = new Point(3, 21);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(304, 387);
            dgvOrders.TabIndex = 31;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Resizable = DataGridViewTriState.True;
            ColumnId.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnId.Width = 23;
            // 
            // ColumnCreationDate
            // 
            ColumnCreationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnCreationDate.HeaderText = "Creation Date";
            ColumnCreationDate.Name = "ColumnCreationDate";
            ColumnCreationDate.ReadOnly = true;
            ColumnCreationDate.Resizable = DataGridViewTriState.True;
            ColumnCreationDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnCreationDate.Width = 85;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnName.Width = 45;
            // 
            // ColumnAddress
            // 
            ColumnAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnAddress.HeaderText = "Address";
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.ReadOnly = true;
            ColumnAddress.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnAddress.Width = 55;
            // 
            // ColumnAmount
            // 
            ColumnAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnAmount.HeaderText = "Amount";
            ColumnAmount.Name = "ColumnAmount";
            ColumnAmount.ReadOnly = true;
            ColumnAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnAmount.Width = 57;
            // 
            // ColumnStatus
            // 
            ColumnStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            ColumnStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnStatus.Width = 45;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
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
            splitContainer1.Panel1.Controls.Add(dgvOrders);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(labelAmount);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(lbOrderItems);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(addressControl1);
            splitContainer1.Size = new Size(690, 457);
            splitContainer1.SplitterDistance = 310;
            splitContainer1.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tbCreated, 1, 1);
            tableLayoutPanel1.Controls.Add(cbStatus, 2, 1);
            tableLayoutPanel1.Controls.Add(tbId, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.0909081F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.90909F));
            tableLayoutPanel1.Size = new Size(366, 44);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "OrdersTab";
            Size = new Size(690, 457);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbId;
        private ComboBox cbStatus;
        private Controls.AddressControl addressControl1;
        private TextBox tbCreated;
        private ListBox lbOrderItems;
        private Label labelAmount;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridView dgvOrders;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCreationDate;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}
