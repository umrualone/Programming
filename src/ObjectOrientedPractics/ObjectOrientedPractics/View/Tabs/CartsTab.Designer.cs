namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.cartLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(6, 29);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(231, 355);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBoxSelectedIndexChanged);
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(246, 82);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(378, 160);
            this.cartListBox.TabIndex = 1;
            this.cartListBox.SelectedIndexChanged += new System.EventHandler(this.CartListBoxSelectedIndexChanged);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartButton.Enabled = false;
            this.addToCartButton.Location = new System.Drawing.Point(6, 390);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(86, 38);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClick);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Enabled = false;
            this.createOrderButton.Location = new System.Drawing.Point(246, 318);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(86, 38);
            this.createOrderButton.TabIndex = 3;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButtonClick);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Enabled = false;
            this.removeItemButton.Location = new System.Drawing.Point(465, 318);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(81, 38);
            this.removeItemButton.TabIndex = 4;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButtonClick);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartButton.Enabled = false;
            this.clearCartButton.Location = new System.Drawing.Point(552, 318);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(72, 38);
            this.clearCartButton.TabIndex = 5;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButtonClick);
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(325, 27);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(299, 21);
            this.customersComboBox.TabIndex = 6;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBoxSelectedIndexChanged);
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(3, 10);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(44, 16);
            this.itemsLabel.TabIndex = 7;
            this.itemsLabel.Text = "Items";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(243, 28);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 16);
            this.customerLabel.TabIndex = 8;
            this.customerLabel.Text = "Customer:";
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(243, 66);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cartLabel.Size = new System.Drawing.Size(29, 13);
            this.cartLabel.TabIndex = 9;
            this.cartLabel.Text = "Cart:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(243, 255);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(243, 278);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.itemsListBox);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(640, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        public System.Windows.Forms.ComboBox customersComboBox;
        public System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox cartListBox;
    }
}
