namespace Lab8
{
    partial class MainForm
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
            this.mainUserControl1 = new Lab8.View.Controls.MainUserControl();
            this.SuspendLayout();
            // 
            // mainUserControl1
            // 
            this.mainUserControl1.AutoSize = true;
            this.mainUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUserControl1.Location = new System.Drawing.Point(0, 0);
            this.mainUserControl1.MinimumSize = new System.Drawing.Size(415, 312);
            this.mainUserControl1.Name = "mainUserControl1";
            this.mainUserControl1.Size = new System.Drawing.Size(488, 312);
            this.mainUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 311);
            this.Controls.Add(this.mainUserControl1);
            this.MinimumSize = new System.Drawing.Size(504, 350);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.Controls.MainUserControl mainUserControl1;
    }
}

