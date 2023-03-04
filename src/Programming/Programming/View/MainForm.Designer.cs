namespace Programming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.seasonGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseSeasonLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.weekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.resultParsingLabel = new System.Windows.Forms.Label();
            this.typeValueForParsingLabel = new System.Windows.Forms.Label();
            this.weekdayTextBox = new System.Windows.Forms.TextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.enumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseEnumerationLabel = new System.Windows.Forms.Label();
            this.chooseValueLabel = new System.Windows.Forms.Label();
            this.intValueLabel = new System.Windows.Forms.Label();
            this.intValueTextBox = new System.Windows.Forms.TextBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.moviesGroupBox = new System.Windows.Forms.GroupBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.findMovieButton = new System.Windows.Forms.Button();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.findRectangleButton = new System.Windows.Forms.Button();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.seasonGroupBox.SuspendLayout();
            this.weekdayGroupBox.SuspendLayout();
            this.enumerationGroupBox.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.moviesGroupBox.SuspendLayout();
            this.rectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.enumsTabPage);
            this.tabControl.Controls.Add(this.classesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 458);
            this.tabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.enumsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enumsTabPage.Controls.Add(this.seasonGroupBox);
            this.enumsTabPage.Controls.Add(this.weekdayGroupBox);
            this.enumsTabPage.Controls.Add(this.enumerationGroupBox);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(788, 432);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            // 
            // seasonGroupBox
            // 
            this.seasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.seasonGroupBox.Controls.Add(this.chooseSeasonLabel);
            this.seasonGroupBox.Controls.Add(this.goButton);
            this.seasonGroupBox.Controls.Add(this.seasonComboBox);
            this.seasonGroupBox.Location = new System.Drawing.Point(385, 263);
            this.seasonGroupBox.Name = "seasonGroupBox";
            this.seasonGroupBox.Size = new System.Drawing.Size(396, 161);
            this.seasonGroupBox.TabIndex = 4;
            this.seasonGroupBox.TabStop = false;
            this.seasonGroupBox.Text = "Season Handle";
            // 
            // chooseSeasonLabel
            // 
            this.chooseSeasonLabel.Location = new System.Drawing.Point(44, 40);
            this.chooseSeasonLabel.Name = "chooseSeasonLabel";
            this.chooseSeasonLabel.Size = new System.Drawing.Size(112, 15);
            this.chooseSeasonLabel.TabIndex = 2;
            this.chooseSeasonLabel.Text = "Choose season:";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Silver;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goButton.Location = new System.Drawing.Point(162, 57);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(79, 21);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(44, 57);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(112, 21);
            this.seasonComboBox.TabIndex = 0;
            // 
            // weekdayGroupBox
            // 
            this.weekdayGroupBox.Controls.Add(this.resultParsingLabel);
            this.weekdayGroupBox.Controls.Add(this.typeValueForParsingLabel);
            this.weekdayGroupBox.Controls.Add(this.weekdayTextBox);
            this.weekdayGroupBox.Controls.Add(this.parseButton);
            this.weekdayGroupBox.Location = new System.Drawing.Point(7, 263);
            this.weekdayGroupBox.Name = "weekdayGroupBox";
            this.weekdayGroupBox.Size = new System.Drawing.Size(372, 161);
            this.weekdayGroupBox.TabIndex = 3;
            this.weekdayGroupBox.TabStop = false;
            this.weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // resultParsingLabel
            // 
            this.resultParsingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultParsingLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.resultParsingLabel.Location = new System.Drawing.Point(10, 99);
            this.resultParsingLabel.Name = "resultParsingLabel";
            this.resultParsingLabel.Size = new System.Drawing.Size(331, 33);
            this.resultParsingLabel.TabIndex = 3;
            this.resultParsingLabel.Text = "Введите день недели";
            // 
            // typeValueForParsingLabel
            // 
            this.typeValueForParsingLabel.Location = new System.Drawing.Point(10, 40);
            this.typeValueForParsingLabel.Name = "typeValueForParsingLabel";
            this.typeValueForParsingLabel.Size = new System.Drawing.Size(204, 15);
            this.typeValueForParsingLabel.TabIndex = 2;
            this.typeValueForParsingLabel.Text = "Type value for parsing:";
            // 
            // weekdayTextBox
            // 
            this.weekdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekdayTextBox.Location = new System.Drawing.Point(10, 58);
            this.weekdayTextBox.Name = "weekdayTextBox";
            this.weekdayTextBox.Size = new System.Drawing.Size(204, 20);
            this.weekdayTextBox.TabIndex = 1;
            // 
            // parseButton
            // 
            this.parseButton.BackColor = System.Drawing.Color.Silver;
            this.parseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parseButton.Location = new System.Drawing.Point(220, 58);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(85, 20);
            this.parseButton.TabIndex = 0;
            this.parseButton.Text = "Parse";
            this.parseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parseButton.UseVisualStyleBackColor = false;
            this.parseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // enumerationGroupBox
            // 
            this.enumerationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enumerationGroupBox.Controls.Add(this.chooseEnumerationLabel);
            this.enumerationGroupBox.Controls.Add(this.chooseValueLabel);
            this.enumerationGroupBox.Controls.Add(this.intValueLabel);
            this.enumerationGroupBox.Controls.Add(this.intValueTextBox);
            this.enumerationGroupBox.Controls.Add(this.valuesListBox);
            this.enumerationGroupBox.Controls.Add(this.enumsListBox);
            this.enumerationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enumerationGroupBox.Location = new System.Drawing.Point(7, 3);
            this.enumerationGroupBox.Name = "enumerationGroupBox";
            this.enumerationGroupBox.Size = new System.Drawing.Size(774, 255);
            this.enumerationGroupBox.TabIndex = 2;
            this.enumerationGroupBox.TabStop = false;
            this.enumerationGroupBox.Text = "Enumerations";
            // 
            // chooseEnumerationLabel
            // 
            this.chooseEnumerationLabel.Location = new System.Drawing.Point(27, 25);
            this.chooseEnumerationLabel.Name = "chooseEnumerationLabel";
            this.chooseEnumerationLabel.Size = new System.Drawing.Size(135, 17);
            this.chooseEnumerationLabel.TabIndex = 5;
            this.chooseEnumerationLabel.Text = "Choose enumerations:";
            // 
            // chooseValueLabel
            // 
            this.chooseValueLabel.Location = new System.Drawing.Point(206, 25);
            this.chooseValueLabel.Name = "chooseValueLabel";
            this.chooseValueLabel.Size = new System.Drawing.Size(135, 14);
            this.chooseValueLabel.TabIndex = 4;
            this.chooseValueLabel.Text = "Choose value:";
            // 
            // intValueLabel
            // 
            this.intValueLabel.Location = new System.Drawing.Point(377, 25);
            this.intValueLabel.Name = "intValueLabel";
            this.intValueLabel.Size = new System.Drawing.Size(55, 14);
            this.intValueLabel.TabIndex = 3;
            this.intValueLabel.Text = "Int value:";
            // 
            // intValueTextBox
            // 
            this.intValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intValueTextBox.Location = new System.Drawing.Point(377, 42);
            this.intValueTextBox.Name = "intValueTextBox";
            this.intValueTextBox.Size = new System.Drawing.Size(126, 20);
            this.intValueTextBox.TabIndex = 2;
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(206, 42);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.ScrollAlwaysVisible = true;
            this.valuesListBox.Size = new System.Drawing.Size(152, 186);
            this.valuesListBox.TabIndex = 1;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // enumsListBox
            // 
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(27, 42);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.ScrollAlwaysVisible = true;
            this.enumsListBox.Size = new System.Drawing.Size(152, 186);
            this.enumsListBox.TabIndex = 0;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // classesTabPage
            // 
            this.classesTabPage.BackColor = System.Drawing.Color.Transparent;
            this.classesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classesTabPage.Controls.Add(this.moviesGroupBox);
            this.classesTabPage.Controls.Add(this.rectanglesGroupBox);
            this.classesTabPage.Location = new System.Drawing.Point(4, 22);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(788, 432);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            // 
            // moviesGroupBox
            // 
            this.moviesGroupBox.Controls.Add(this.ratingLabel);
            this.moviesGroupBox.Controls.Add(this.genreLabel);
            this.moviesGroupBox.Controls.Add(this.yearLabel);
            this.moviesGroupBox.Controls.Add(this.timeLabel);
            this.moviesGroupBox.Controls.Add(this.titleLabel);
            this.moviesGroupBox.Controls.Add(this.moviesListBox);
            this.moviesGroupBox.Controls.Add(this.findMovieButton);
            this.moviesGroupBox.Controls.Add(this.ratingTextBox);
            this.moviesGroupBox.Controls.Add(this.genreTextBox);
            this.moviesGroupBox.Controls.Add(this.yearTextBox);
            this.moviesGroupBox.Controls.Add(this.timeTextBox);
            this.moviesGroupBox.Controls.Add(this.titleTextBox);
            this.moviesGroupBox.Location = new System.Drawing.Point(7, 216);
            this.moviesGroupBox.Name = "moviesGroupBox";
            this.moviesGroupBox.Size = new System.Drawing.Size(346, 204);
            this.moviesGroupBox.TabIndex = 1;
            this.moviesGroupBox.TabStop = false;
            this.moviesGroupBox.Text = "Movies";
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(133, 123);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(58, 20);
            this.ratingLabel.TabIndex = 16;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(134, 97);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(58, 20);
            this.genreLabel.TabIndex = 15;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(133, 71);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 20);
            this.yearLabel.TabIndex = 14;
            this.yearLabel.Text = "Year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(134, 45);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 20);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Time:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(133, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 20);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            this.moviesListBox.Location = new System.Drawing.Point(16, 19);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(112, 147);
            this.moviesListBox.TabIndex = 8;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // findMovieButton
            // 
            this.findMovieButton.BackColor = System.Drawing.Color.Silver;
            this.findMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findMovieButton.Location = new System.Drawing.Point(188, 158);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(108, 30);
            this.findMovieButton.TabIndex = 8;
            this.findMovieButton.Text = "Find";
            this.findMovieButton.UseVisualStyleBackColor = false;
            this.findMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingTextBox.Location = new System.Drawing.Point(197, 123);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(92, 20);
            this.ratingTextBox.TabIndex = 12;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // genreTextBox
            // 
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreTextBox.Location = new System.Drawing.Point(197, 97);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(92, 20);
            this.genreTextBox.TabIndex = 11;
            this.genreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTextBox.Location = new System.Drawing.Point(197, 71);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(92, 20);
            this.yearTextBox.TabIndex = 10;
            this.yearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.Location = new System.Drawing.Point(197, 45);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(92, 20);
            this.timeTextBox.TabIndex = 9;
            this.timeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Location = new System.Drawing.Point(197, 19);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(92, 20);
            this.titleTextBox.TabIndex = 8;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // rectanglesGroupBox
            // 
            this.rectanglesGroupBox.Controls.Add(this.lengthLabel);
            this.rectanglesGroupBox.Controls.Add(this.widthLabel);
            this.rectanglesGroupBox.Controls.Add(this.colorLabel);
            this.rectanglesGroupBox.Controls.Add(this.colorTextBox);
            this.rectanglesGroupBox.Controls.Add(this.widthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.lengthTextBox);
            this.rectanglesGroupBox.Controls.Add(this.findRectangleButton);
            this.rectanglesGroupBox.Controls.Add(this.rectanglesListBox);
            this.rectanglesGroupBox.Location = new System.Drawing.Point(7, 6);
            this.rectanglesGroupBox.Name = "rectanglesGroupBox";
            this.rectanglesGroupBox.Size = new System.Drawing.Size(346, 204);
            this.rectanglesGroupBox.TabIndex = 0;
            this.rectanglesGroupBox.TabStop = false;
            this.rectanglesGroupBox.Text = "Rectangles";
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(134, 29);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(58, 20);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(133, 55);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(58, 20);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(133, 81);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(58, 20);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox.Location = new System.Drawing.Point(197, 81);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(92, 20);
            this.colorTextBox.TabIndex = 4;
            this.colorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthTextBox.Location = new System.Drawing.Point(197, 55);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(92, 20);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthTextBox.Location = new System.Drawing.Point(198, 29);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(92, 20);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // findRectangleButton
            // 
            this.findRectangleButton.BackColor = System.Drawing.Color.Silver;
            this.findRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findRectangleButton.Location = new System.Drawing.Point(188, 126);
            this.findRectangleButton.Name = "findRectangleButton";
            this.findRectangleButton.Size = new System.Drawing.Size(108, 30);
            this.findRectangleButton.TabIndex = 1;
            this.findRectangleButton.Text = "Find";
            this.findRectangleButton.UseVisualStyleBackColor = false;
            this.findRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            this.rectanglesListBox.Location = new System.Drawing.Point(16, 29);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(112, 147);
            this.rectanglesListBox.TabIndex = 0;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.seasonGroupBox.ResumeLayout(false);
            this.weekdayGroupBox.ResumeLayout(false);
            this.weekdayGroupBox.PerformLayout();
            this.enumerationGroupBox.ResumeLayout(false);
            this.enumerationGroupBox.PerformLayout();
            this.classesTabPage.ResumeLayout(false);
            this.moviesGroupBox.ResumeLayout(false);
            this.moviesGroupBox.PerformLayout();
            this.rectanglesGroupBox.ResumeLayout(false);
            this.rectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label ratingLabel;

        private System.Windows.Forms.Button findMovieButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.ListBox moviesListBox;

        private System.Windows.Forms.GroupBox moviesGroupBox;

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;

        private System.Windows.Forms.Label colorLabel;

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox colorTextBox;

        private System.Windows.Forms.Button findRectangleButton;

        private System.Windows.Forms.GroupBox rectanglesGroupBox;
        private System.Windows.Forms.ListBox rectanglesListBox;

        private System.Windows.Forms.TabPage classesTabPage;

        private System.Windows.Forms.Label chooseSeasonLabel;

        private System.Windows.Forms.Button goButton;

        private System.Windows.Forms.ComboBox seasonComboBox;

        private System.Windows.Forms.GroupBox seasonGroupBox;

        private System.Windows.Forms.Label typeValueForParsingLabel;

        private System.Windows.Forms.Label resultParsingLabel;

        private System.Windows.Forms.TextBox weekdayTextBox;

        private System.Windows.Forms.Button parseButton;

        private System.Windows.Forms.GroupBox weekdayGroupBox;

        private System.Windows.Forms.Label chooseEnumerationLabel;

        private System.Windows.Forms.Label chooseValueLabel;

        private System.Windows.Forms.Label intValueLabel;

        private System.Windows.Forms.TextBox intValueTextBox;

        private System.Windows.Forms.GroupBox enumerationGroupBox;

        private System.Windows.Forms.ListBox valuesListBox;

        private System.Windows.Forms.ListBox enumsListBox;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enumsTabPage;

        #endregion
    }
}