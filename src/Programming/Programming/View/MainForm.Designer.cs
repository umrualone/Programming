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
            this.groupBoxWeekday = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelParsing = new System.Windows.Forms.Label();
            this.textBoxWeekday = new System.Windows.Forms.TextBox();
            this.buttonParse = new System.Windows.Forms.Button();
            this.groupBoxEnumerations = new System.Windows.Forms.GroupBox();
            this.labelEnumaration = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.groupBoxWeekday.SuspendLayout();
            this.groupBoxEnumerations.SuspendLayout();
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
            this.tabPageEnums.Controls.Add(this.groupBoxWeekday);
            this.tabPageEnums.Controls.Add(this.groupBoxEnumerations);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(791, 433);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // groupBoxWeekday
            // 
            this.groupBoxWeekday.Controls.Add(this.labelResult);
            this.groupBoxWeekday.Controls.Add(this.labelParsing);
            this.groupBoxWeekday.Controls.Add(this.textBoxWeekday);
            this.groupBoxWeekday.Controls.Add(this.buttonParse);
            this.groupBoxWeekday.Location = new System.Drawing.Point(7, 263);
            this.groupBoxWeekday.Name = "groupBoxWeekday";
            this.groupBoxWeekday.Size = new System.Drawing.Size(372, 161);
            this.groupBoxWeekday.TabIndex = 3;
            this.groupBoxWeekday.TabStop = false;
            this.groupBoxWeekday.Text = "Weekday Parsing";
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelResult.Location = new System.Drawing.Point(10, 99);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(331, 33);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Введите день недели";
            // 
            // labelParsing
            // 
            this.labelParsing.Location = new System.Drawing.Point(10, 40);
            this.labelParsing.Name = "labelParsing";
            this.labelParsing.Size = new System.Drawing.Size(204, 15);
            this.labelParsing.TabIndex = 2;
            this.labelParsing.Text = "Type value for pasring:";
            // 
            // textBoxWeekday
            // 
            this.textBoxWeekday.Location = new System.Drawing.Point(10, 58);
            this.textBoxWeekday.Name = "textBoxWeekday";
            this.textBoxWeekday.Size = new System.Drawing.Size(204, 20);
            this.textBoxWeekday.TabIndex = 1;
            // 
            // buttonParse
            // 
            this.buttonParse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonParse.Location = new System.Drawing.Point(220, 58);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(85, 20);
            this.buttonParse.TabIndex = 0;
            this.buttonParse.Text = "Parse";
            this.buttonParse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // groupBoxEnumerations
            // 
            this.groupBoxEnumerations.Controls.Add(this.labelEnumaration);
            this.groupBoxEnumerations.Controls.Add(this.labelValue);
            this.groupBoxEnumerations.Controls.Add(this.labelIndex);
            this.groupBoxEnumerations.Controls.Add(this.textBoxValue);
            this.groupBoxEnumerations.Controls.Add(this.ValuesListBox);
            this.groupBoxEnumerations.Controls.Add(this.EnumsListBox);
            this.groupBoxEnumerations.Location = new System.Drawing.Point(7, 3);
            this.groupBoxEnumerations.Name = "groupBoxEnumerations";
            this.groupBoxEnumerations.Size = new System.Drawing.Size(774, 255);
            this.groupBoxEnumerations.TabIndex = 2;
            this.groupBoxEnumerations.TabStop = false;
            this.groupBoxEnumerations.Text = "Enumerations";
            // 
            // labelEnumaration
            // 
            this.labelEnumaration.Location = new System.Drawing.Point(27, 25);
            this.labelEnumaration.Name = "labelEnumaration";
            this.labelEnumaration.Size = new System.Drawing.Size(135, 17);
            this.labelEnumaration.TabIndex = 5;
            this.labelEnumaration.Text = "Choose enumaration:";
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(206, 25);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(135, 14);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Choose value:";
            // 
            // labelIndex
            // 
            this.labelIndex.Location = new System.Drawing.Point(377, 25);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(55, 14);
            this.labelIndex.TabIndex = 3;
            this.labelIndex.Text = "Int value:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(377, 42);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(126, 20);
            this.textBoxValue.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(206, 42);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(152, 186);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(27, 42);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(152, 186);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.groupBoxWeekday.ResumeLayout(false);
            this.groupBoxWeekday.PerformLayout();
            this.groupBoxEnumerations.ResumeLayout(false);
            this.groupBoxEnumerations.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelParsing;

        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.TextBox textBoxWeekday;

        private System.Windows.Forms.Button buttonParse;

        private System.Windows.Forms.GroupBox groupBoxWeekday;

        private System.Windows.Forms.Label labelEnumaration;

        private System.Windows.Forms.Label labelValue;

        private System.Windows.Forms.Label labelIndex;

        private System.Windows.Forms.TextBox textBoxValue;

        private System.Windows.Forms.GroupBox groupBoxEnumerations;

        private System.Windows.Forms.ListBox ValuesListBox;

        private System.Windows.Forms.ListBox EnumsListBox;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEnums;

        #endregion
    }
}