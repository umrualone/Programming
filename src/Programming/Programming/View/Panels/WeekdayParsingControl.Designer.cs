using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.weekdayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultParsingLabel = new System.Windows.Forms.Label();
            this.parseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weekdayTextBox
            // 
            this.weekdayTextBox.Location = new System.Drawing.Point(13, 42);
            this.weekdayTextBox.Name = "weekdayTextBox";
            this.weekdayTextBox.Size = new System.Drawing.Size(225, 20);
            this.weekdayTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type value for parsing:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // resultParsingLabel
            // 
            this.resultParsingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultParsingLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultParsingLabel.Location = new System.Drawing.Point(13, 78);
            this.resultParsingLabel.Name = "resultParsingLabel";
            this.resultParsingLabel.Size = new System.Drawing.Size(353, 58);
            this.resultParsingLabel.TabIndex = 8;
            this.resultParsingLabel.Text = "Введите день недели";
            // 
            // parseButton
            // 
            this.parseButton.BackColor = System.Drawing.Color.Silver;
            this.parseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.parseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.parseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseButton.Location = new System.Drawing.Point(262, 42);
            this.parseButton.Name = "parseButton";
            this.parseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parseButton.Size = new System.Drawing.Size(104, 21);
            this.parseButton.TabIndex = 5;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = false;
            this.parseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.resultParsingLabel);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.weekdayTextBox);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(431, 205);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button parseButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultParsingLabel;

        private System.Windows.Forms.TextBox weekdayTextBox;

        #endregion
    }
}