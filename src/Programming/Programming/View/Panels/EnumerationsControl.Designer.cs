using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.intValueLabel = new System.Windows.Forms.Label();
            this.chooseValueLabel = new System.Windows.Forms.Label();
            this.intValueTextBox = new System.Windows.Forms.TextBox();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.chooseEnumerationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valuesListBox
            // 
            this.valuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.valuesListBox.Location = new System.Drawing.Point(200, 24);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.ScrollAlwaysVisible = true;
            this.valuesListBox.Size = new System.Drawing.Size(125, 186);
            this.valuesListBox.TabIndex = 6;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // intValueLabel
            // 
            this.intValueLabel.Location = new System.Drawing.Point(363, -3);
            this.intValueLabel.Name = "intValueLabel";
            this.intValueLabel.Size = new System.Drawing.Size(85, 24);
            this.intValueLabel.TabIndex = 5;
            this.intValueLabel.Text = "Int value:";
            this.intValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chooseValueLabel
            // 
            this.chooseValueLabel.Location = new System.Drawing.Point(200, 5);
            this.chooseValueLabel.Name = "chooseValueLabel";
            this.chooseValueLabel.Size = new System.Drawing.Size(112, 16);
            this.chooseValueLabel.TabIndex = 7;
            this.chooseValueLabel.Text = "Choose value:";
            this.chooseValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // intValueTextBox
            // 
            this.intValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.intValueTextBox.Location = new System.Drawing.Point(363, 24);
            this.intValueTextBox.Name = "intValueTextBox";
            this.intValueTextBox.Size = new System.Drawing.Size(104, 20);
            this.intValueTextBox.TabIndex = 2;
            // 
            // enumsListBox
            // 
            this.enumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(11, 24);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.ScrollAlwaysVisible = true;
            this.enumsListBox.Size = new System.Drawing.Size(125, 186);
            this.enumsListBox.TabIndex = 0;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // chooseEnumerationLabel
            // 
            this.chooseEnumerationLabel.Location = new System.Drawing.Point(11, 5);
            this.chooseEnumerationLabel.Name = "chooseEnumerationLabel";
            this.chooseEnumerationLabel.Size = new System.Drawing.Size(112, 16);
            this.chooseEnumerationLabel.TabIndex = 3;
            this.chooseEnumerationLabel.Text = "Choose enumeration:";
            this.chooseEnumerationLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intValueLabel);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.intValueTextBox);
            this.Controls.Add(this.chooseValueLabel);
            this.Controls.Add(this.enumsListBox);
            this.Controls.Add(this.chooseEnumerationLabel);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(470, 231);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label chooseValueLabel;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label intValueLabel;
        private System.Windows.Forms.Label chooseEnumerationLabel;
        private System.Windows.Forms.TextBox intValueTextBox;
        private System.Windows.Forms.ListBox enumsListBox;

        #endregion
    }
}