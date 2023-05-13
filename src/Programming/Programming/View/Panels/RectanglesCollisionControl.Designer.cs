using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rectanglesLabel = new System.Windows.Forms.Label();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.deleteRectangleButton = new System.Windows.Forms.Button();
            this.addRectangleButton = new System.Windows.Forms.Button();
            this.rectanglesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(10, 388);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(49, 20);
            this.lengthLabel.TabIndex = 31;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(10, 353);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(49, 20);
            this.widthLabel.TabIndex = 30;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(10, 315);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(49, 20);
            this.yLabel.TabIndex = 29;
            this.yLabel.Text = "Y:";
            this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(10, 280);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(49, 20);
            this.xLabel.TabIndex = 28;
            this.xLabel.Text = "X:";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(10, 245);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(49, 20);
            this.idLabel.TabIndex = 27;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthTextBox.Location = new System.Drawing.Point(65, 390);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(99, 20);
            this.lengthTextBox.TabIndex = 26;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthTextBox.Location = new System.Drawing.Point(65, 353);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(99, 20);
            this.widthTextBox.TabIndex = 25;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // yTextBox
            // 
            this.yTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yTextBox.Location = new System.Drawing.Point(65, 317);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(99, 20);
            this.yTextBox.TabIndex = 24;
            this.yTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xTextBox.Location = new System.Drawing.Point(65, 282);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(99, 20);
            this.xTextBox.TabIndex = 23;
            this.xTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Location = new System.Drawing.Point(65, 247);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(99, 20);
            this.idTextBox.TabIndex = 22;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selected Rectangle:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rectanglesLabel
            // 
            this.rectanglesLabel.Location = new System.Drawing.Point(1, 13);
            this.rectanglesLabel.Name = "rectanglesLabel";
            this.rectanglesLabel.Size = new System.Drawing.Size(66, 14);
            this.rectanglesLabel.TabIndex = 20;
            this.rectanglesLabel.Text = "Rectangles:";
            this.rectanglesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(3, 30);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(329, 134);
            this.rectanglesListBox.TabIndex = 19;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // deleteRectangleButton
            // 
            this.deleteRectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRectangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteRectangleButton.BackgroundImage")));
            this.deleteRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteRectangleButton.FlatAppearance.BorderSize = 0;
            this.deleteRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRectangleButton.Location = new System.Drawing.Point(218, 170);
            this.deleteRectangleButton.Name = "deleteRectangleButton";
            this.deleteRectangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteRectangleButton.Size = new System.Drawing.Size(32, 32);
            this.deleteRectangleButton.TabIndex = 18;
            this.deleteRectangleButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deleteRectangleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteRectangleButton.UseVisualStyleBackColor = false;
            this.deleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // addRectangleButton
            // 
            this.addRectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.addRectangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRectangleButton.BackgroundImage")));
            this.addRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRectangleButton.FlatAppearance.BorderSize = 0;
            this.addRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRectangleButton.Location = new System.Drawing.Point(77, 170);
            this.addRectangleButton.Name = "addRectangleButton";
            this.addRectangleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addRectangleButton.Size = new System.Drawing.Size(32, 32);
            this.addRectangleButton.TabIndex = 17;
            this.addRectangleButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addRectangleButton.UseVisualStyleBackColor = false;
            this.addRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // rectanglesPanel
            // 
            this.rectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.rectanglesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectanglesPanel.Location = new System.Drawing.Point(338, 13);
            this.rectanglesPanel.Name = "rectanglesPanel";
            this.rectanglesPanel.Size = new System.Drawing.Size(377, 398);
            this.rectanglesPanel.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rectanglesLabel);
            this.Controls.Add(this.rectanglesListBox);
            this.Controls.Add(this.deleteRectangleButton);
            this.Controls.Add(this.addRectangleButton);
            this.Controls.Add(this.rectanglesPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(727, 429);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rectanglesLabel;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Button deleteRectangleButton;
        private System.Windows.Forms.Button addRectangleButton;
        private System.Windows.Forms.Panel rectanglesPanel;

        #endregion
    }
}