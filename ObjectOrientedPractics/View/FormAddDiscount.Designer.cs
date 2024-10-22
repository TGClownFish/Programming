namespace ObjectOrientedPractics.View
{
    partial class FormAddDiscount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbCategory = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 25);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose The Category:";
            // 
            // cbControl
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(59, 55);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.Name = "cbControl";
            cbCategory.Size = new Size(227, 23);
            cbCategory.TabIndex = 1;
            cbCategory.SelectedIndexChanged += cbControl_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(59, 104);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 22);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(204, 104);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 151);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cbCategory);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddDiscount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Discount";
            Load += FormAddDiscount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCategory;
        private Button btnOk;
        private Button btnCancel;
    }
}