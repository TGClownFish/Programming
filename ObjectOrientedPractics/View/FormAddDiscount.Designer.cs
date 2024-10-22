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
            cbControl = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose The Category:";
            // 
            // cbControl
            // 
            cbControl.FormattingEnabled = true;
            cbControl.Location = new Point(67, 73);
            cbControl.Name = "cbControl";
            cbControl.Size = new Size(259, 28);
            cbControl.TabIndex = 1;
            cbControl.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(67, 138);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(232, 144);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddDiscount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 201);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cbControl);
            Controls.Add(label1);
            Name = "FormAddDiscount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbControl;
        private Button btnOk;
        private Button btnCancel;
    }
}