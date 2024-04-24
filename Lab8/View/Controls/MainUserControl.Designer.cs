namespace Lab8.View.Controls
{
    partial class MainUserControl
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
            this.mainUserControlListBox = new System.Windows.Forms.ListBox();
            this.mainUserControlAddNewElementButton = new System.Windows.Forms.Button();
            this.mainUserControlDeleteElementButton = new System.Windows.Forms.Button();
            this.mainUserControlGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainUserControlLinkTextBox = new System.Windows.Forms.TextBox();
            this.mainUserControlPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.mainUserControllDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mainUserControlNameTextBox = new System.Windows.Forms.TextBox();
            this.mainUserControlEditElementButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.mainUserControlSaveElementButton = new System.Windows.Forms.Button();
            this.mainUserControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainUserControlListBox
            // 
            this.mainUserControlListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainUserControlListBox.FormattingEnabled = true;
            this.mainUserControlListBox.Location = new System.Drawing.Point(12, 29);
            this.mainUserControlListBox.Name = "mainUserControlListBox";
            this.mainUserControlListBox.Size = new System.Drawing.Size(132, 212);
            this.mainUserControlListBox.TabIndex = 0;
            this.mainUserControlListBox.SelectedIndexChanged += new System.EventHandler(this.mainUserControlListBox_SelectedIndexChanged);
            // 
            // mainUserControlAddNewElementButton
            // 
            this.mainUserControlAddNewElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainUserControlAddNewElementButton.Location = new System.Drawing.Point(12, 258);
            this.mainUserControlAddNewElementButton.Name = "mainUserControlAddNewElementButton";
            this.mainUserControlAddNewElementButton.Size = new System.Drawing.Size(40, 32);
            this.mainUserControlAddNewElementButton.TabIndex = 1;
            this.mainUserControlAddNewElementButton.Text = "Add";
            this.mainUserControlAddNewElementButton.UseVisualStyleBackColor = true;
            this.mainUserControlAddNewElementButton.Click += new System.EventHandler(this.mainUserControlAddNewElementButton_Click);
            // 
            // mainUserControlDeleteElementButton
            // 
            this.mainUserControlDeleteElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainUserControlDeleteElementButton.Location = new System.Drawing.Point(104, 258);
            this.mainUserControlDeleteElementButton.Name = "mainUserControlDeleteElementButton";
            this.mainUserControlDeleteElementButton.Size = new System.Drawing.Size(40, 32);
            this.mainUserControlDeleteElementButton.TabIndex = 3;
            this.mainUserControlDeleteElementButton.Text = "Del";
            this.mainUserControlDeleteElementButton.UseVisualStyleBackColor = true;
            this.mainUserControlDeleteElementButton.Click += new System.EventHandler(this.mainUserControlDeleteElementButton_Click);
            // 
            // mainUserControlGroupBox
            // 
            this.mainUserControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControlGroupBox.Controls.Add(this.label4);
            this.mainUserControlGroupBox.Controls.Add(this.label3);
            this.mainUserControlGroupBox.Controls.Add(this.label2);
            this.mainUserControlGroupBox.Controls.Add(this.label1);
            this.mainUserControlGroupBox.Controls.Add(this.mainUserControlLinkTextBox);
            this.mainUserControlGroupBox.Controls.Add(this.mainUserControlPhoneNumberTextBox);
            this.mainUserControlGroupBox.Controls.Add(this.mainUserControllDateTimePicker);
            this.mainUserControlGroupBox.Controls.Add(this.mainUserControlNameTextBox);
            this.mainUserControlGroupBox.Location = new System.Drawing.Point(150, 16);
            this.mainUserControlGroupBox.Name = "mainUserControlGroupBox";
            this.mainUserControlGroupBox.Size = new System.Drawing.Size(337, 172);
            this.mainUserControlGroupBox.TabIndex = 4;
            this.mainUserControlGroupBox.TabStop = false;
            this.mainUserControlGroupBox.Text = "Selected Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "vk.com:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name:";
            // 
            // mainUserControlLinkTextBox
            // 
            this.mainUserControlLinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControlLinkTextBox.Location = new System.Drawing.Point(95, 121);
            this.mainUserControlLinkTextBox.Name = "mainUserControlLinkTextBox";
            this.mainUserControlLinkTextBox.ReadOnly = true;
            this.mainUserControlLinkTextBox.Size = new System.Drawing.Size(238, 20);
            this.mainUserControlLinkTextBox.TabIndex = 3;
            this.mainUserControlLinkTextBox.TextChanged += new System.EventHandler(this.mainUserControlLinkTextBox_TextChanged);
            // 
            // mainUserControlPhoneNumberTextBox
            // 
            this.mainUserControlPhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControlPhoneNumberTextBox.Location = new System.Drawing.Point(95, 95);
            this.mainUserControlPhoneNumberTextBox.Name = "mainUserControlPhoneNumberTextBox";
            this.mainUserControlPhoneNumberTextBox.ReadOnly = true;
            this.mainUserControlPhoneNumberTextBox.Size = new System.Drawing.Size(238, 20);
            this.mainUserControlPhoneNumberTextBox.TabIndex = 2;
            this.mainUserControlPhoneNumberTextBox.TextChanged += new System.EventHandler(this.mainUserControlPhoneNumberTextBox_TextChanged);
            // 
            // mainUserControllDateTimePicker
            // 
            this.mainUserControllDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControllDateTimePicker.Enabled = false;
            this.mainUserControllDateTimePicker.Location = new System.Drawing.Point(95, 69);
            this.mainUserControllDateTimePicker.Name = "mainUserControllDateTimePicker";
            this.mainUserControllDateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.mainUserControllDateTimePicker.TabIndex = 1;
            this.mainUserControllDateTimePicker.Value = new System.DateTime(2024, 4, 23, 17, 50, 40, 0);
            this.mainUserControllDateTimePicker.ValueChanged += new System.EventHandler(this.mainUserControllDateTimePicker_ValueChanged);
            // 
            // mainUserControlNameTextBox
            // 
            this.mainUserControlNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControlNameTextBox.Location = new System.Drawing.Point(95, 43);
            this.mainUserControlNameTextBox.Name = "mainUserControlNameTextBox";
            this.mainUserControlNameTextBox.ReadOnly = true;
            this.mainUserControlNameTextBox.Size = new System.Drawing.Size(238, 20);
            this.mainUserControlNameTextBox.TabIndex = 0;
            this.mainUserControlNameTextBox.TextChanged += new System.EventHandler(this.mainUserControlNameTextBox_TextChanged);
            // 
            // mainUserControlEditElementButton
            // 
            this.mainUserControlEditElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControlEditElementButton.Location = new System.Drawing.Point(397, 248);
            this.mainUserControlEditElementButton.Name = "mainUserControlEditElementButton";
            this.mainUserControlEditElementButton.Size = new System.Drawing.Size(40, 32);
            this.mainUserControlEditElementButton.TabIndex = 2;
            this.mainUserControlEditElementButton.Text = "Edit";
            this.mainUserControlEditElementButton.UseVisualStyleBackColor = true;
            this.mainUserControlEditElementButton.Click += new System.EventHandler(this.mainUserControlEditElementButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contacts:";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(417, 228);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(10, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = " ";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainUserControlSaveElementButton
            // 
            this.mainUserControlSaveElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainUserControlSaveElementButton.Enabled = false;
            this.mainUserControlSaveElementButton.Location = new System.Drawing.Point(443, 248);
            this.mainUserControlSaveElementButton.Name = "mainUserControlSaveElementButton";
            this.mainUserControlSaveElementButton.Size = new System.Drawing.Size(40, 32);
            this.mainUserControlSaveElementButton.TabIndex = 9;
            this.mainUserControlSaveElementButton.Text = "Save";
            this.mainUserControlSaveElementButton.UseVisualStyleBackColor = true;
            this.mainUserControlSaveElementButton.Click += new System.EventHandler(this.mainUserControlSaveElementButton_Click);
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.mainUserControlSaveElementButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mainUserControlGroupBox);
            this.Controls.Add(this.mainUserControlDeleteElementButton);
            this.Controls.Add(this.mainUserControlEditElementButton);
            this.Controls.Add(this.mainUserControlAddNewElementButton);
            this.Controls.Add(this.mainUserControlListBox);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(504, 307);
            this.Load += new System.EventHandler(this.MainUserControl_Load);
            this.HandleDestroyed += new System.EventHandler(this.MainUserControl_HandleDestroyed);
            this.mainUserControlGroupBox.ResumeLayout(false);
            this.mainUserControlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainUserControlListBox;
        private System.Windows.Forms.Button mainUserControlAddNewElementButton;
        private System.Windows.Forms.Button mainUserControlDeleteElementButton;
        private System.Windows.Forms.GroupBox mainUserControlGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mainUserControlLinkTextBox;
        private System.Windows.Forms.TextBox mainUserControlPhoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker mainUserControllDateTimePicker;
        private System.Windows.Forms.TextBox mainUserControlNameTextBox;
        private System.Windows.Forms.Button mainUserControlEditElementButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button mainUserControlSaveElementButton;
    }
}
