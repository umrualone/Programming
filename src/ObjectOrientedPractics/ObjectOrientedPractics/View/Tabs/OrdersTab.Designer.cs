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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.amountCounterLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ordersLabel = new System.Windows.Forms.Label();
            selectedOrderLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            orderItemsLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.ordersDataGridView.Size = new System.Drawing.Size(522, 525);
            this.ordersDataGridView.TabIndex = 1;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridViewCellContentClick);
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
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(531, 325);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(599, 121);
            this.itemsListBox.TabIndex = 3;
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            selectedOrderLabel.Location = new System.Drawing.Point(528, 6);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new System.Drawing.Size(118, 17);
            selectedOrderLabel.TabIndex = 4;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(531, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "ID:";
            // 
            // createdLabel
            // 
            createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(531, 66);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 6;
            createdLabel.Text = "Created:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(531, 98);
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
            orderItemsLabel.Location = new System.Drawing.Point(532, 289);
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
            amountLabel.Location = new System.Drawing.Point(532, 458);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(67, 17);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "Amount:";
            // 
            // amountCounterLabel
            // 
            this.amountCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountCounterLabel.AutoSize = true;
            this.amountCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCounterLabel.Location = new System.Drawing.Point(533, 489);
            this.amountCounterLabel.Name = "amountCounterLabel";
            this.amountCounterLabel.Size = new System.Drawing.Size(19, 20);
            this.amountCounterLabel.TabIndex = 10;
            this.amountCounterLabel.Text = "0";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(589, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(117, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // createdTextBox
            // 
            this.createdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdTextBox.Location = new System.Drawing.Point(589, 63);
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
            this.statusComboBox.Location = new System.Drawing.Point(589, 95);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(117, 21);
            this.statusComboBox.TabIndex = 13;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBoxSelectedIndexChanged);
            // 
            // addressControl
            // 
            this.addressControl.Address = null;
            this.addressControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl.Location = new System.Drawing.Point(531, 114);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(599, 205);
            this.addressControl.TabIndex = 0;
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
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(1133, 557);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
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
    }
}
