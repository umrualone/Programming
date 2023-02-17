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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabControl1.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEnums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageEnums.Controls.Add(this.SeasonGroupBox);
            this.tabPageEnums.Controls.Add(this.WeekdayGroupBox);
            this.tabPageEnums.Controls.Add(this.EnumerationsGroupBox);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(791, 433);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
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
            this.EnumerationsGroupBox.Controls.Add(this.EnumarationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IndexLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 459);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEnums;

        #endregion
    }
}