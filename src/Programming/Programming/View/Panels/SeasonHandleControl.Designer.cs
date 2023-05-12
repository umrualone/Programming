using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            this.chooseSeasonLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooseSeasonLabel
            // 
            this.chooseSeasonLabel.Location = new System.Drawing.Point(13, 20);
            this.chooseSeasonLabel.Name = "chooseSeasonLabel";
            this.chooseSeasonLabel.Size = new System.Drawing.Size(152, 15);
            this.chooseSeasonLabel.TabIndex = 8;
            this.chooseSeasonLabel.Text = "Choose season:";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Silver;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Location = new System.Drawing.Point(195, 37);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(103, 21);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(13, 38);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(155, 21);
            this.seasonComboBox.TabIndex = 0;
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.chooseSeasonLabel);
            this.Controls.Add(this.seasonComboBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(327, 92);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label chooseSeasonLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox seasonComboBox;

        #endregion
    }
}