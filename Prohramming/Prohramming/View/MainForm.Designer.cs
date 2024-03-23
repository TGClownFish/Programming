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
            this.label6 = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ParsingButton = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.rectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rectanglesIdTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rectanglesButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.rectanglesXTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesYTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rectanglesColourTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesLengthTextBox1 = new System.Windows.Forms.TextBox();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.filmsGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filmsButton = new System.Windows.Forms.Button();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.filmsReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.filmsNameTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.rectanglesGroupBox.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            this.filmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEnums);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Controls.Add(this.tabPageFilms);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 343);
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
            this.tabPageEnums.Size = new System.Drawing.Size(505, 317);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.label6);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Location = new System.Drawing.Point(276, 221);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(301, 90);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season handle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose a season";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.SeasonComboBox.Location = new System.Drawing.Point(16, 42);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(143, 40);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 0;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.label5);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.label4);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(14, 221);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(255, 89);
            this.WeekdayParsingGroupBox.TabIndex = 7;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday parsing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = " ";
            // 
            // ParsingButton
            // 
            this.ParsingButton.Location = new System.Drawing.Point(160, 43);
            this.ParsingButton.Name = "ParsingButton";
            this.ParsingButton.Size = new System.Drawing.Size(71, 20);
            this.ParsingButton.TabIndex = 9;
            this.ParsingButton.Text = "Parse";
            this.ParsingButton.UseVisualStyleBackColor = true;
            this.ParsingButton.Click += new System.EventHandler(this.ParsingButton_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(9, 43);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(145, 20);
            this.ParsingTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type value for parsing";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.label1);
            this.EnumerationsGroupBox.Controls.Add(this.label2);
            this.EnumerationsGroupBox.Controls.Add(this.label3);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.NameTextBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(571, 208);
            this.EnumerationsGroupBox.TabIndex = 6;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colour",
            "EducationForm",
            "Genre",
            "Manufacturer",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(6, 42);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 160);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int value";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(141, 42);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 160);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(267, 42);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.rectanglesGroupBox);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Size = new System.Drawing.Size(505, 317);
            this.tabPageClasses.TabIndex = 1;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // rectanglesGroupBox
            // 
            this.rectanglesGroupBox.Controls.Add(this.label17);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesIdTextBox);
            this.rectanglesGroupBox.Controls.Add(this.label16);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesButton);
            this.rectanglesGroupBox.Controls.Add(this.label15);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesXTextBox);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesYTextBox);
            this.rectanglesGroupBox.Controls.Add(this.label9);
            this.rectanglesGroupBox.Controls.Add(this.label8);
            this.rectanglesGroupBox.Controls.Add(this.label7);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesColourTextBox);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesWidthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesLengthTextBox1);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesListBox);
            this.rectanglesGroupBox.Location = new System.Drawing.Point(48, 40);
            this.rectanglesGroupBox.Name = "rectanglesGroupBox";
            this.rectanglesGroupBox.Size = new System.Drawing.Size(404, 206);
            this.rectanglesGroupBox.TabIndex = 0;
            this.rectanglesGroupBox.TabStop = false;
            this.rectanglesGroupBox.Text = "Rectangles";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(148, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Id";
            // 
            // rectanglesIdTextBox
            // 
            this.rectanglesIdTextBox.Location = new System.Drawing.Point(151, 31);
            this.rectanglesIdTextBox.Name = "rectanglesIdTextBox";
            this.rectanglesIdTextBox.ReadOnly = true;
            this.rectanglesIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanglesIdTextBox.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Y";
            // 
            // rectanglesButton
            // 
            this.rectanglesButton.Location = new System.Drawing.Point(208, 155);
            this.rectanglesButton.Name = "rectanglesButton";
            this.rectanglesButton.Size = new System.Drawing.Size(100, 23);
            this.rectanglesButton.TabIndex = 4;
            this.rectanglesButton.Text = "Find";
            this.rectanglesButton.UseVisualStyleBackColor = true;
            this.rectanglesButton.Click += new System.EventHandler(this.rectanglesButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "X";
            // 
            // rectanglesXTextBox
            // 
            this.rectanglesXTextBox.Location = new System.Drawing.Point(265, 71);
            this.rectanglesXTextBox.Name = "rectanglesXTextBox";
            this.rectanglesXTextBox.ReadOnly = true;
            this.rectanglesXTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanglesXTextBox.TabIndex = 8;
            // 
            // rectanglesYTextBox
            // 
            this.rectanglesYTextBox.Location = new System.Drawing.Point(265, 110);
            this.rectanglesYTextBox.Name = "rectanglesYTextBox";
            this.rectanglesYTextBox.ReadOnly = true;
            this.rectanglesYTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanglesYTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lenght";
            // 
            // rectanglesColourTextBox
            // 
            this.rectanglesColourTextBox.Location = new System.Drawing.Point(268, 31);
            this.rectanglesColourTextBox.Name = "rectanglesColourTextBox";
            this.rectanglesColourTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanglesColourTextBox.TabIndex = 3;
            this.rectanglesColourTextBox.TextChanged += new System.EventHandler(this.rectanglesColourTextBox_TextChanged);
            // 
            // rectanglesWidthTextBox
            // 
            this.rectanglesWidthTextBox.Location = new System.Drawing.Point(151, 110);
            this.rectanglesWidthTextBox.Name = "rectanglesWidthTextBox";
            this.rectanglesWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanglesWidthTextBox.TabIndex = 2;
            this.rectanglesWidthTextBox.TextChanged += new System.EventHandler(this.rectanglesWidthTextBox_TextChanged);
            // 
            // rectanglesLengthTextBox1
            // 
            this.rectanglesLengthTextBox1.Location = new System.Drawing.Point(151, 71);
            this.rectanglesLengthTextBox1.Name = "rectanglesLengthTextBox1";
            this.rectanglesLengthTextBox1.Size = new System.Drawing.Size(100, 20);
            this.rectanglesLengthTextBox1.TabIndex = 1;
            this.rectanglesLengthTextBox1.TextChanged += new System.EventHandler(this.rectanglesLengthTextBox1_TextChanged);
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.rectanglesListBox.Location = new System.Drawing.Point(6, 31);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(120, 147);
            this.rectanglesListBox.TabIndex = 0;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.rectanglesListBox_SelectedIndexChanged);
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.Controls.Add(this.filmsGroupBox);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Size = new System.Drawing.Size(505, 317);
            this.tabPageFilms.TabIndex = 2;
            this.tabPageFilms.Text = "Films";
            this.tabPageFilms.UseVisualStyleBackColor = true;
            // 
            // filmsGroupBox
            // 
            this.filmsGroupBox.Controls.Add(this.label14);
            this.filmsGroupBox.Controls.Add(this.durationTextBox);
            this.filmsGroupBox.Controls.Add(this.label13);
            this.filmsGroupBox.Controls.Add(this.ratingTextBox);
            this.filmsGroupBox.Controls.Add(this.label10);
            this.filmsGroupBox.Controls.Add(this.label11);
            this.filmsGroupBox.Controls.Add(this.label12);
            this.filmsGroupBox.Controls.Add(this.filmsButton);
            this.filmsGroupBox.Controls.Add(this.genreTextBox);
            this.filmsGroupBox.Controls.Add(this.filmsReleaseYearTextBox);
            this.filmsGroupBox.Controls.Add(this.filmsNameTextBox);
            this.filmsGroupBox.Controls.Add(this.listBox1);
            this.filmsGroupBox.Location = new System.Drawing.Point(70, 38);
            this.filmsGroupBox.Name = "filmsGroupBox";
            this.filmsGroupBox.Size = new System.Drawing.Size(322, 261);
            this.filmsGroupBox.TabIndex = 1;
            this.filmsGroupBox.TabStop = false;
            this.filmsGroupBox.Text = "Films";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Rating";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(151, 74);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 10;
            this.durationTextBox.TextChanged += new System.EventHandler(this.durationTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Genre";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(151, 194);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 8;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.ratingTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Release year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Name";
            // 
            // filmsButton
            // 
            this.filmsButton.Location = new System.Drawing.Point(151, 232);
            this.filmsButton.Name = "filmsButton";
            this.filmsButton.Size = new System.Drawing.Size(100, 23);
            this.filmsButton.TabIndex = 4;
            this.filmsButton.Text = "Find";
            this.filmsButton.UseVisualStyleBackColor = true;
            this.filmsButton.Click += new System.EventHandler(this.filmsButton_Click);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(151, 153);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreTextBox.TabIndex = 3;
            this.genreTextBox.TextChanged += new System.EventHandler(this.genreTextBox_TextChanged);
            // 
            // filmsReleaseYearTextBox
            // 
            this.filmsReleaseYearTextBox.Location = new System.Drawing.Point(151, 113);
            this.filmsReleaseYearTextBox.Name = "filmsReleaseYearTextBox";
            this.filmsReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.filmsReleaseYearTextBox.TabIndex = 2;
            this.filmsReleaseYearTextBox.TextChanged += new System.EventHandler(this.filmsReleaseYearTextBox_TextChanged);
            // 
            // filmsNameTextBox
            // 
            this.filmsNameTextBox.Location = new System.Drawing.Point(151, 32);
            this.filmsNameTextBox.Name = "filmsNameTextBox";
            this.filmsNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.filmsNameTextBox.TabIndex = 1;
            this.filmsNameTextBox.TextChanged += new System.EventHandler(this.filmsNameTextBox_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Film 1",
            "Film 2",
            "Film 3",
            "Film 4",
            "Film 5"});
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(513, 343);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.tabPageClasses.ResumeLayout(false);
            this.rectanglesGroupBox.ResumeLayout(false);
            this.rectanglesGroupBox.PerformLayout();
            this.tabPageFilms.ResumeLayout(false);
            this.filmsGroupBox.ResumeLayout(false);
            this.filmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEnums;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ParsingButton;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label label6;
        private TabPage tabPageClasses;
        private GroupBox rectanglesGroupBox;
        private ListBox rectanglesListBox;
        private TextBox rectanglesColourTextBox;
        private TextBox rectanglesWidthTextBox;
        private TextBox rectanglesLengthTextBox1;
        private Button rectanglesButton;
        private Label label9;
        private Label label8;
        private Label label7;
        private TabPage tabPageFilms;
        private GroupBox filmsGroupBox;
        private Label label13;
        private TextBox ratingTextBox;
        private Label label11;
        private Label label12;
        private Button filmsButton;
        private TextBox genreTextBox;
        private TextBox filmsReleaseYearTextBox;
        private TextBox filmsNameTextBox;
        private ListBox listBox1;
        private Label label10;
        private Label label14;
        private TextBox durationTextBox;
        private Label label16;
        private Label label15;
        private TextBox rectanglesXTextBox;
        private TextBox rectanglesYTextBox;
        private Label label17;
        private TextBox rectanglesIdTextBox;
    }
}

