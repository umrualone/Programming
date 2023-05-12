using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label widthLabel;
            System.Windows.Forms.Label lengthLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            System.Windows.Forms.Label idLabel;
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.classWidthTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.findRectangleButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            colorLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            lengthLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            colorLabel.Location = new System.Drawing.Point(161, 118);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(58, 20);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Color:";
            colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthLabel
            // 
            widthLabel.Location = new System.Drawing.Point(161, 72);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(58, 20);
            widthLabel.TabIndex = 6;
            widthLabel.Text = "Width:";
            widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox.Location = new System.Drawing.Point(161, 141);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(92, 20);
            this.colorTextBox.TabIndex = 4;
            this.colorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // classWidthTextBox
            // 
            this.classWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classWidthTextBox.Location = new System.Drawing.Point(161, 95);
            this.classWidthTextBox.Name = "classWidthTextBox";
            this.classWidthTextBox.Size = new System.Drawing.Size(92, 20);
            this.classWidthTextBox.TabIndex = 3;
            this.classWidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xTextBox.Location = new System.Drawing.Point(161, 186);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(92, 20);
            this.xTextBox.TabIndex = 9;
            this.xTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanToChangeTextBox_KeyPress);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthTextBox.Location = new System.Drawing.Point(161, 49);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(92, 20);
            this.lengthTextBox.TabIndex = 2;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // yTextBox
            // 
            this.yTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yTextBox.Location = new System.Drawing.Point(161, 232);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(92, 20);
            this.yTextBox.TabIndex = 10;
            this.yTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanToChangeTextBox_KeyPress);
            // 
            // findRectangleButton
            // 
            this.findRectangleButton.BackColor = System.Drawing.Color.Silver;
            this.findRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findRectangleButton.Location = new System.Drawing.Point(161, 323);
            this.findRectangleButton.Name = "findRectangleButton";
            this.findRectangleButton.Size = new System.Drawing.Size(55, 19);
            this.findRectangleButton.TabIndex = 1;
            this.findRectangleButton.Text = "Find";
            this.findRectangleButton.UseVisualStyleBackColor = false;
            this.findRectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(161, 277);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(92, 20);
            this.idTextBox.TabIndex = 11;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanToChangeTextBox_KeyPress);
            // 
            // lengthLabel
            // 
            lengthLabel.Location = new System.Drawing.Point(161, 26);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new System.Drawing.Size(58, 20);
            lengthLabel.TabIndex = 7;
            lengthLabel.Text = "Length:";
            lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xLabel
            // 
            xLabel.Location = new System.Drawing.Point(161, 168);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(92, 16);
            xLabel.TabIndex = 12;
            xLabel.Text = "Coordinate x:";
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(18, 26);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(112, 407);
            this.rectanglesListBox.TabIndex = 8;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // yLabel
            // 
            yLabel.Location = new System.Drawing.Point(161, 214);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(92, 16);
            yLabel.TabIndex = 13;
            yLabel.Text = "Coordinate y:";
            // 
            // idLabel
            // 
            idLabel.Location = new System.Drawing.Point(161, 258);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(92, 16);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(idLabel);
            this.Controls.Add(yLabel);
            this.Controls.Add(this.rectanglesListBox);
            this.Controls.Add(xLabel);
            this.Controls.Add(lengthLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.findRectangleButton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.classWidthTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(widthLabel);
            this.Controls.Add(colorLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(331, 460);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button findRectangleButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox classWidthTextBox;
        private System.Windows.Forms.TextBox colorTextBox;

        #endregion
    }
}