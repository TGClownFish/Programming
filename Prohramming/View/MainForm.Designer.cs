using System.Windows.Forms;

namespace Prohramming
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonHandleControl1 = new Prohramming.View.Tabs.SeasonHandleControl();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl1 = new Prohramming.View.Tabs.WeekdayParsingControl();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl1 = new Prohramming.View.Tabs.EnumerationsControl();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.classesTabPage1 = new Prohramming.View.Tabs.ClassesTabPage();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.filmsTabPage1 = new Prohramming.View.Tabs.FilmsTabPage();
            this.tabPageRectangles = new System.Windows.Forms.TabPage();
            this.rectanglesTabPage1 = new Prohramming.View.Tabs.RectanglesTabPage();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            this.tabPageRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEnums);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Controls.Add(this.tabPageFilms);
            this.tabControl1.Controls.Add(this.tabPageRectangles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.Controls.Add(this.SeasonGroupBox);
            this.tabPageEnums.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabPageEnums.Controls.Add(this.EnumerationsGroupBox);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(640, 399);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonGroupBox.Controls.Add(this.seasonHandleControl1);
            this.SeasonGroupBox.Location = new System.Drawing.Point(276, 221);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(226, 90);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season handle";
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(0, 25);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(212, 66);
            this.seasonHandleControl1.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsingGroupBox.Controls.Add(this.weekdayParsingControl1);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(14, 221);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(255, 89);
            this.WeekdayParsingGroupBox.TabIndex = 7;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday parsing";
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(0, 25);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(242, 65);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.Controls.Add(this.enumerationsControl1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(486, 208);
            this.EnumerationsGroupBox.TabIndex = 6;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(15, 15);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(373, 194);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.classesTabPage1);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Size = new System.Drawing.Size(640, 399);
            this.tabPageClasses.TabIndex = 1;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // classesTabPage1
            // 
            this.classesTabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classesTabPage1.Location = new System.Drawing.Point(104, 63);
            this.classesTabPage1.Name = "classesTabPage1";
            this.classesTabPage1.Size = new System.Drawing.Size(412, 227);
            this.classesTabPage1.TabIndex = 0;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.Controls.Add(this.filmsTabPage1);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Size = new System.Drawing.Size(640, 399);
            this.tabPageFilms.TabIndex = 2;
            this.tabPageFilms.Text = "Films";
            this.tabPageFilms.UseVisualStyleBackColor = true;
            // 
            // filmsTabPage1
            // 
            this.filmsTabPage1.Location = new System.Drawing.Point(109, 35);
            this.filmsTabPage1.Name = "filmsTabPage1";
            this.filmsTabPage1.Size = new System.Drawing.Size(304, 287);
            this.filmsTabPage1.TabIndex = 0;
            // 
            // tabPageRectangles
            // 
            this.tabPageRectangles.Controls.Add(this.rectanglesTabPage1);
            this.tabPageRectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPageRectangles.Name = "tabPageRectangles";
            this.tabPageRectangles.Size = new System.Drawing.Size(640, 399);
            this.tabPageRectangles.TabIndex = 3;
            this.tabPageRectangles.Text = "Rectangles";
            this.tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesTabPage1
            // 
            this.rectanglesTabPage1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesTabPage1.Name = "rectanglesTabPage1";
            this.rectanglesTabPage1.Size = new System.Drawing.Size(632, 396);
            this.rectanglesTabPage1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(648, 425);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(529, 402);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.tabPageClasses.ResumeLayout(false);
            this.tabPageFilms.ResumeLayout(false);
            this.tabPageRectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEnums;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private TabPage tabPageClasses;
        private TabPage tabPageFilms;
        private TabPage tabPageRectangles;
        private PageSetupDialog pageSetupDialog1;
        private View.Tabs.FilmsTabPage filmsTabPage1;
        private View.Tabs.ClassesTabPage classesTabPage1;
        private View.Tabs.RectanglesTabPage rectanglesTabPage1;
        private View.Tabs.SeasonHandleControl seasonHandleControl1;
        private View.Tabs.WeekdayParsingControl weekdayParsingControl1;
        private View.Tabs.EnumerationsControl enumerationsControl1;
    }
}

