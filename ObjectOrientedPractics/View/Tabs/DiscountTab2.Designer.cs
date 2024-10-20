namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountTab2
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
            labelDiscountAmout = new Label();
            label4 = new Label();
            labelProductAmount = new Label();
            label2 = new Label();
            labelInfo = new Label();
            btnUpdate = new Button();
            btnApply = new Button();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // labelDiscountAmout
            // 
            labelDiscountAmout.AutoSize = true;
            labelDiscountAmout.Location = new Point(513, 276);
            labelDiscountAmout.Name = "labelDiscountAmout";
            labelDiscountAmout.Size = new Size(38, 15);
            labelDiscountAmout.TabIndex = 15;
            labelDiscountAmout.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 218);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 14;
            label4.Text = "Discount Amout:";
            // 
            // labelProductAmount
            // 
            labelProductAmount.AutoSize = true;
            labelProductAmount.Location = new Point(513, 153);
            labelProductAmount.Name = "labelProductAmount";
            labelProductAmount.Size = new Size(38, 15);
            labelProductAmount.TabIndex = 13;
            labelProductAmount.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 103);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 12;
            label2.Text = "Product Amount:";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(125, 137);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(38, 15);
            labelInfo.TabIndex = 11;
            labelInfo.Text = "label1";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(393, 198);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(239, 198);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 9;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(88, 198);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // DiscountTab2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDiscountAmout);
            Controls.Add(label4);
            Controls.Add(labelProductAmount);
            Controls.Add(label2);
            Controls.Add(labelInfo);
            Controls.Add(btnUpdate);
            Controls.Add(btnApply);
            Controls.Add(btnCalculate);
            Name = "DiscountTab2";
            Size = new Size(700, 394);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDiscountAmout;
        private Label label4;
        private Label labelProductAmount;
        private Label label2;
        private Label labelInfo;
        private Button btnUpdate;
        private Button btnApply;
        private Button btnCalculate;
    }
}
