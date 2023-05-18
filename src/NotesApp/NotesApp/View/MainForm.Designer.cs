namespace NotesApp.View
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
            System.Windows.Forms.GroupBox groupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label timeOfCreationLabel;
            System.Windows.Forms.Label titleLabel;
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.timeOfCreationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryСomboBox = new System.Windows.Forms.ComboBox();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            groupBox = new System.Windows.Forms.GroupBox();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            timeOfCreationLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            groupBox.Controls.Add(this.cancelButton);
            groupBox.Controls.Add(this.acceptButton);
            groupBox.Controls.Add(categoryLabel);
            groupBox.Controls.Add(descriptionLabel);
            groupBox.Controls.Add(timeOfCreationLabel);
            groupBox.Controls.Add(titleLabel);
            groupBox.Controls.Add(this.timeOfCreationTextBox);
            groupBox.Controls.Add(this.descriptionTextBox);
            groupBox.Controls.Add(this.titleTextBox);
            groupBox.Controls.Add(this.categoryСomboBox);
            groupBox.Location = new System.Drawing.Point(307, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new System.Drawing.Size(432, 293);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Selected Note";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(304, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(40, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acceptButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceptButton.BackgroundImage")));
            this.acceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Location = new System.Drawing.Point(373, 224);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(40, 40);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            categoryLabel.Location = new System.Drawing.Point(6, 243);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(89, 21);
            categoryLabel.TabIndex = 8;
            categoryLabel.Text = "Category:";
            categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new System.Drawing.Point(6, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(89, 31);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timeOfCreationLabel
            // 
            timeOfCreationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            timeOfCreationLabel.Location = new System.Drawing.Point(6, 194);
            timeOfCreationLabel.Name = "timeOfCreationLabel";
            timeOfCreationLabel.Size = new System.Drawing.Size(89, 20);
            timeOfCreationLabel.TabIndex = 6;
            timeOfCreationLabel.Text = "Time of creation:";
            timeOfCreationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            titleLabel.Location = new System.Drawing.Point(6, 27);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(89, 20);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Title note:";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeOfCreationTextBox
            // 
            this.timeOfCreationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeOfCreationTextBox.BackColor = System.Drawing.Color.White;
            this.timeOfCreationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeOfCreationTextBox.Location = new System.Drawing.Point(101, 196);
            this.timeOfCreationTextBox.Name = "timeOfCreationTextBox";
            this.timeOfCreationTextBox.ReadOnly = true;
            this.timeOfCreationTextBox.Size = new System.Drawing.Size(150, 20);
            this.timeOfCreationTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(101, 64);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(312, 115);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.White;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Location = new System.Drawing.Point(101, 27);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(312, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // categoryСomboBox
            // 
            this.categoryСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryСomboBox.Enabled = false;
            this.categoryСomboBox.FormattingEnabled = true;
            this.categoryСomboBox.Location = new System.Drawing.Point(101, 243);
            this.categoryСomboBox.Name = "categoryСomboBox";
            this.categoryСomboBox.Size = new System.Drawing.Size(150, 21);
            this.categoryСomboBox.TabIndex = 1;
            // 
            // notesListBox
            // 
            this.notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.Location = new System.Drawing.Point(12, 12);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(289, 368);
            this.notesListBox.TabIndex = 0;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(21, 393);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 2;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(148, 393);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(83, 393);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.TabIndex = 4;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 441);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(groupBox);
            this.Controls.Add(this.notesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "MainForm";
            this.Text = "NotesApp";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox timeOfCreationTextBox;

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;

        private System.Windows.Forms.ComboBox categoryСomboBox;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.ListBox notesListBox;

        #endregion
    }
}