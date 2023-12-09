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
            System.Windows.Forms.Label itemsLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label cartLabel;
            System.Windows.Forms.Label discountAmountLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label discountsLabel;
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.discountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.discountCounterLabel = new System.Windows.Forms.Label();
            this.totalCounterLabel = new System.Windows.Forms.Label();
            itemsLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            cartLabel = new System.Windows.Forms.Label();
            discountAmountLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            discountsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(6, 29);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(231, 472);
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
            this.cartListBox.Size = new System.Drawing.Size(523, 160);
            this.cartListBox.TabIndex = 1;
            this.cartListBox.SelectedIndexChanged += new System.EventHandler(this.CartListBoxSelectedIndexChanged);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartButton.Enabled = false;
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.Location = new System.Drawing.Point(6, 507);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(87, 39);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClick);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Enabled = false;
            this.createOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderButton.Location = new System.Drawing.Point(247, 300);
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
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Location = new System.Drawing.Point(610, 300);
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
            this.clearCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCartButton.Location = new System.Drawing.Point(697, 300);
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
            this.customersComboBox.Size = new System.Drawing.Size(444, 21);
            this.customersComboBox.TabIndex = 6;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBoxSelectedIndexChanged);
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            itemsLabel.Location = new System.Drawing.Point(3, 9);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new System.Drawing.Size(46, 17);
            itemsLabel.TabIndex = 7;
            itemsLabel.Text = "Items";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            customerLabel.Location = new System.Drawing.Point(244, 29);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(81, 17);
            customerLabel.TabIndex = 8;
            customerLabel.Text = "Customer:";
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cartLabel.Location = new System.Drawing.Point(244, 62);
            cartLabel.Name = "cartLabel";
            cartLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cartLabel.Size = new System.Drawing.Size(43, 17);
            cartLabel.TabIndex = 9;
            cartLabel.Text = "Cart:";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(674, 245);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountLabel.Size = new System.Drawing.Size(95, 30);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amountCounterLabel.Location = new System.Drawing.Point(610, 275);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amountCounterLabel.Size = new System.Drawing.Size(159, 19);
            this.amountCounterLabel.TabIndex = 11;
            this.amountCounterLabel.Text = "0";
            this.amountCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountsCheckedListBox
            // 
            this.discountsCheckedListBox.FormattingEnabled = true;
            this.discountsCheckedListBox.Location = new System.Drawing.Point(247, 370);
            this.discountsCheckedListBox.Name = "discountsCheckedListBox";
            this.discountsCheckedListBox.Size = new System.Drawing.Size(244, 79);
            this.discountsCheckedListBox.TabIndex = 12;
            this.discountsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DiscountsCheckedListBoxItemCheck);
            this.discountsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSelectedIndexChanged);
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            discountAmountLabel.Location = new System.Drawing.Point(617, 370);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            discountAmountLabel.Size = new System.Drawing.Size(152, 20);
            discountAmountLabel.TabIndex = 13;
            discountAmountLabel.Text = "Discount Amount:";
            discountAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // discountCounterLabel
            // 
            this.discountCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discountCounterLabel.Location = new System.Drawing.Point(621, 399);
            this.discountCounterLabel.Name = "discountCounterLabel";
            this.discountCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.discountCounterLabel.Size = new System.Drawing.Size(148, 20);
            this.discountCounterLabel.TabIndex = 14;
            this.discountCounterLabel.Text = "0";
            this.discountCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCounterLabel
            // 
            this.totalCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCounterLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalCounterLabel.Location = new System.Drawing.Point(661, 515);
            this.totalCounterLabel.Name = "totalCounterLabel";
            this.totalCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalCounterLabel.Size = new System.Drawing.Size(108, 20);
            this.totalCounterLabel.TabIndex = 16;
            this.totalCounterLabel.Text = "0";
            this.totalCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            totalLabel.Location = new System.Drawing.Point(715, 484);
            totalLabel.Name = "totalLabel";
            totalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            totalLabel.Size = new System.Drawing.Size(54, 20);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // discountsLabel
            // 
            discountsLabel.AutoSize = true;
            discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            discountsLabel.Location = new System.Drawing.Point(244, 350);
            discountsLabel.Name = "discountsLabel";
            discountsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            discountsLabel.Size = new System.Drawing.Size(84, 17);
            discountsLabel.TabIndex = 17;
            discountsLabel.Text = "Discounts:";
            discountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(discountsLabel);
            this.Controls.Add(this.totalCounterLabel);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.discountCounterLabel);
            this.Controls.Add(discountAmountLabel);
            this.Controls.Add(this.discountsCheckedListBox);
            this.Controls.Add(this.amountCounterLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(cartLabel);
            this.Controls.Add(customerLabel);
            this.Controls.Add(itemsLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.itemsListBox);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(785, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountCounterLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.CheckedListBox discountsCheckedListBox;
        private System.Windows.Forms.Label discountCounterLabel;
        private System.Windows.Forms.Label totalCounterLabel;
    }
}
