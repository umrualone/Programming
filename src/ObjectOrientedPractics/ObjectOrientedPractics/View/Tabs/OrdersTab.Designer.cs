namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            System.Windows.Forms.Label ordersLabel;
            System.Windows.Forms.Label selectedOrderLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label orderItemsLabel;
            System.Windows.Forms.Label amountLabel;
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.priorityOptionsLabel = new System.Windows.Forms.Label();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            ordersLabel = new System.Windows.Forms.Label();
            selectedOrderLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            orderItemsLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ordersLabel.Location = new System.Drawing.Point(3, 6);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new System.Drawing.Size(58, 17);
            ordersLabel.TabIndex = 2;
            ordersLabel.Text = "Orders";
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            selectedOrderLabel.Location = new System.Drawing.Point(523, 6);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new System.Drawing.Size(118, 17);
            selectedOrderLabel.TabIndex = 4;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(526, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "ID:";
            // 
            // createdLabel
            // 
            createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(526, 66);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 6;
            createdLabel.Text = "Created:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(526, 98);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            orderItemsLabel.Location = new System.Drawing.Point(527, 289);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new System.Drawing.Size(93, 17);
            orderItemsLabel.TabIndex = 8;
            orderItemsLabel.Text = "Order Items";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountLabel.Location = new System.Drawing.Point(527, 458);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(67, 17);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "Amount:";
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(3, 37);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.deliveryTimeLabel.TabIndex = 33;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // priorityOptionsLabel
            // 
            this.priorityOptionsLabel.AutoSize = true;
            this.priorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityOptionsLabel.Location = new System.Drawing.Point(3, 9);
            this.priorityOptionsLabel.Name = "priorityOptionsLabel";
            this.priorityOptionsLabel.Size = new System.Drawing.Size(121, 17);
            this.priorityOptionsLabel.TabIndex = 32;
            this.priorityOptionsLabel.Text = "Priority Options";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Created,
            this.OrderStatus,
            this.FullName,
            this.Address,
            this.Amount});
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 26);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(517, 565);
            this.ordersDataGridView.TabIndex = 1;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridViewCellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 40;
            // 
            // Created
            // 
            this.Created.HeaderText = "Created";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            this.Created.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Created.Width = 150;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Customer Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 200;
            // 
            // Address
            // 
            this.Address.HeaderText = "Delivery Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 250;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(526, 325);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(599, 121);
            this.itemsListBox.TabIndex = 3;
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountCounterLabel.AutoSize = true;
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.Location = new System.Drawing.Point(528, 489);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.amountCounterLabel.TabIndex = 10;
            this.amountCounterLabel.Text = "0";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(584, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(117, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // createdTextBox
            // 
            this.createdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTextBox.Location = new System.Drawing.Point(584, 63);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(117, 20);
            this.createdTextBox.TabIndex = 12;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(584, 95);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(117, 21);
            this.statusComboBox.TabIndex = 13;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBoxSelectedIndexChanged);
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(83, 34);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(117, 21);
            this.deliveryTimeComboBox.TabIndex = 34;
            this.deliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.deliveryTimeComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.priorityOptionsLabel);
            this.panel1.Controls.Add(this.deliveryTimeComboBox);
            this.panel1.Controls.Add(this.deliveryTimeLabel);
            this.panel1.Location = new System.Drawing.Point(803, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 104);
            this.panel1.TabIndex = 35;
            // 
            // addressControl
            // 
            this.addressControl.Address = null;
            this.addressControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl.Location = new System.Drawing.Point(526, 114);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(599, 205);
            this.addressControl.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.amountCounterLabel);
            this.Controls.Add(amountLabel);
            this.Controls.Add(orderItemsLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(createdLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(selectedOrderLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(ordersLabel);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.addressControl);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1128, 597);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AddressControl addressControl;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label amountCounterLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.Label priorityOptionsLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
