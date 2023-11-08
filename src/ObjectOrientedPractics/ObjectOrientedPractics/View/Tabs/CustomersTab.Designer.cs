namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedItemPanel = new System.Windows.Forms.Panel();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.selectedItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedItemPanel
            // 
            this.selectedItemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemPanel.BackColor = System.Drawing.Color.White;
            this.selectedItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedItemPanel.Controls.Add(this.addressControl1);
            this.selectedItemPanel.Controls.Add(this.cancelButton);
            this.selectedItemPanel.Controls.Add(this.acceptButton);
            this.selectedItemPanel.Controls.Add(this.fullNameLabel);
            this.selectedItemPanel.Controls.Add(this.idLabel);
            this.selectedItemPanel.Controls.Add(this.fullNameTextBox);
            this.selectedItemPanel.Controls.Add(this.idTextBox);
            this.selectedItemPanel.Controls.Add(this.selectedCustomerLabel);
            this.selectedItemPanel.Location = new System.Drawing.Point(218, 19);
            this.selectedItemPanel.Margin = new System.Windows.Forms.Padding(2);
            this.selectedItemPanel.Name = "selectedItemPanel";
            this.selectedItemPanel.Size = new System.Drawing.Size(414, 400);
            this.selectedItemPanel.TabIndex = 11;
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl1.Location = new System.Drawing.Point(3, 117);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(401, 172);
            this.addressControl1.TabIndex = 16;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(264, 314);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(68, 28);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(336, 314);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(68, 28);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(9, 95);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 12;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(9, 53);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.BackColor = System.Drawing.Color.White;
            this.fullNameTextBox.Location = new System.Drawing.Point(70, 92);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(337, 20);
            this.fullNameTextBox.TabIndex = 8;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBoxTextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(70, 50);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(162, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(11, 7);
            this.selectedCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(138, 16);
            this.selectedCustomerLabel.TabIndex = 6;
            this.selectedCustomerLabel.Text = "Selected Customer";
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(2, 15);
            this.customersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(80, 16);
            this.customersLabel.TabIndex = 10;
            this.customersLabel.Text = "Customers";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(146, 389);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(68, 28);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(74, 389);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(68, 28);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(2, 389);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 28);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // customersListBox
            // 
            this.customersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(2, 33);
            this.customersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(212, 342);
            this.customersListBox.TabIndex = 6;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBoxSelectedIndexChanged);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedItemPanel);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customersListBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(640, 433);
            this.selectedItemPanel.ResumeLayout(false);
            this.selectedItemPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel selectedItemPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private Controls.AddressControl addressControl1;
        public System.Windows.Forms.ListBox customersListBox;
        public System.Windows.Forms.Button acceptButton;
    }
}
