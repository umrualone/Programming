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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultParsing = new System.Windows.Forms.Label();
            this.ParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumarationLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEnums);
            this.tabControl.Controls.Add(this.ClassesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 458);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.BackColor = System.Drawing.Color.Transparent;
            this.tabPageEnums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageEnums.Controls.Add(this.SeasonGroupBox);
            this.tabPageEnums.Controls.Add(this.WeekdayGroupBox);
            this.tabPageEnums.Controls.Add(this.EnumerationsGroupBox);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(788, 432);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Controls.Add(this.GoButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Location = new System.Drawing.Point(385, 263);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(396, 161);
            this.SeasonGroupBox.TabIndex = 4;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.Location = new System.Drawing.Point(44, 40);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(112, 15);
            this.SeasonLabel.TabIndex = 2;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Silver;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoButton.Location = new System.Drawing.Point(162, 57);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(79, 21);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(44, 57);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(112, 21);
            this.SeasonComboBox.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ResultParsing);
            this.WeekdayGroupBox.Controls.Add(this.ParsingLabel);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(7, 263);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(372, 161);
            this.WeekdayGroupBox.TabIndex = 3;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Pasring";
            // 
            // ResultParsing
            // 
            this.ResultParsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultParsing.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ResultParsing.Location = new System.Drawing.Point(10, 99);
            this.ResultParsing.Name = "ResultParsing";
            this.ResultParsing.Size = new System.Drawing.Size(331, 33);
            this.ResultParsing.TabIndex = 3;
            this.ResultParsing.Text = "Введите день недели";
            // 
            // ParsingLabel
            // 
            this.ParsingLabel.Location = new System.Drawing.Point(10, 40);
            this.ParsingLabel.Name = "ParsingLabel";
            this.ParsingLabel.Size = new System.Drawing.Size(204, 15);
            this.ParsingLabel.TabIndex = 2;
            this.ParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeekdayTextBox.Location = new System.Drawing.Point(10, 58);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(204, 20);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // ParseButton
            // 
            this.ParseButton.BackColor = System.Drawing.Color.Silver;
            this.ParseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ParseButton.Location = new System.Drawing.Point(220, 58);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(85, 20);
            this.ParseButton.TabIndex = 0;
            this.ParseButton.Text = "Parse";
            this.ParseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ParseButton.UseVisualStyleBackColor = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnumerationsGroupBox.Controls.Add(this.EnumarationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IndexLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(7, 3);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(774, 255);
            this.EnumerationsGroupBox.TabIndex = 2;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumeration";
            // 
            // EnumarationLabel
            // 
            this.EnumarationLabel.Location = new System.Drawing.Point(27, 25);
            this.EnumarationLabel.Name = "EnumarationLabel";
            this.EnumarationLabel.Size = new System.Drawing.Size(135, 17);
            this.EnumarationLabel.TabIndex = 5;
            this.EnumarationLabel.Text = "Choose enumeration:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.Location = new System.Drawing.Point(206, 25);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(135, 14);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // IndexLabel
            // 
            this.IndexLabel.Location = new System.Drawing.Point(377, 25);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(55, 14);
            this.IndexLabel.TabIndex = 3;
            this.IndexLabel.Text = "Int value:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueTextBox.Location = new System.Drawing.Point(377, 42);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(126, 20);
            this.ValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(206, 42);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(152, 186);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(27, 42);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(152, 186);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackColor = System.Drawing.Color.Transparent;
            this.ClassesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(788, 432);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.HeightLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.HeightTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(7, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(346, 194);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(133, 40);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(58, 20);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(134, 75);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(58, 20);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width:";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(134, 111);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(58, 20);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Color:";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorTextBox.Location = new System.Drawing.Point(197, 113);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(92, 20);
            this.ColorTextBox.TabIndex = 4;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthTextBox.Location = new System.Drawing.Point(197, 77);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(92, 20);
            this.WidthTextBox.TabIndex = 3;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.Location = new System.Drawing.Point(197, 42);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(92, 20);
            this.HeightTextBox.TabIndex = 2;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.Silver;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindButton.Location = new System.Drawing.Point(188, 146);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(108, 30);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = false;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(16, 29);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(112, 147);
            this.RectanglesListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;

        private System.Windows.Forms.Label ColorLabel;

        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;

        private System.Windows.Forms.Button FindButton;

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;

        private System.Windows.Forms.TabPage ClassesTabPage;

        private System.Windows.Forms.Label SeasonLabel;

        private System.Windows.Forms.Button GoButton;

        private System.Windows.Forms.ComboBox SeasonComboBox;

        private System.Windows.Forms.GroupBox SeasonGroupBox;

        private System.Windows.Forms.Label ParsingLabel;

        private System.Windows.Forms.Label ResultParsing;

        private System.Windows.Forms.TextBox WeekdayTextBox;

        private System.Windows.Forms.Button ParseButton;

        private System.Windows.Forms.GroupBox WeekdayGroupBox;

        private System.Windows.Forms.Label EnumarationLabel;

        private System.Windows.Forms.Label ValueLabel;

        private System.Windows.Forms.Label IndexLabel;

        private System.Windows.Forms.TextBox ValueTextBox;

        private System.Windows.Forms.GroupBox EnumerationsGroupBox;

        private System.Windows.Forms.ListBox ValuesListBox;

        private System.Windows.Forms.ListBox EnumsListBox;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEnums;

        #endregion
    }
}