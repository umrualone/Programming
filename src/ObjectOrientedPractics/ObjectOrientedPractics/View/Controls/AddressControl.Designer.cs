namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.components = new System.ComponentModel.Container();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.apartamentLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apartmentTextBox.Location = new System.Drawing.Point(259, 139);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.ReadOnly = true;
            this.apartmentTextBox.Size = new System.Drawing.Size(152, 20);
            this.apartmentTextBox.TabIndex = 31;
            this.toolTip1.SetToolTip(this.apartmentTextBox, "Номер квартиры/помещения, не более 10 символов.");
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBoxTextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.Location = new System.Drawing.Point(292, 70);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(117, 20);
            this.cityTextBox.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cityTextBox, "Город (населенный пункт), строка, не более 50 символов.");
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBoxTextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextBox.Location = new System.Drawing.Point(68, 104);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(343, 20);
            this.streetTextBox.TabIndex = 29;
            this.toolTip1.SetToolTip(this.streetTextBox, "Улица, строка, не более 100 символов.");
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBoxTextChanged);
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(68, 139);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.ReadOnly = true;
            this.buildingTextBox.Size = new System.Drawing.Size(121, 20);
            this.buildingTextBox.TabIndex = 28;
            this.toolTip1.SetToolTip(this.buildingTextBox, "Номер дома, строка, не более 10 символов.");
            this.buildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBoxTextChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(68, 70);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(185, 20);
            this.countryTextBox.TabIndex = 27;
            this.toolTip1.SetToolTip(this.countryTextBox, "Страна/регион, строка, не более 50 символов.");
            this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBoxTextChanged);
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryAddressLabel.Location = new System.Drawing.Point(3, 9);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(131, 17);
            this.deliveryAddressLabel.TabIndex = 26;
            this.deliveryAddressLabel.Text = "Delivery Address";
            this.deliveryAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apartamentLabel
            // 
            this.apartamentLabel.AutoSize = true;
            this.apartamentLabel.Location = new System.Drawing.Point(195, 143);
            this.apartamentLabel.Name = "apartamentLabel";
            this.apartamentLabel.Size = new System.Drawing.Size(58, 13);
            this.apartamentLabel.TabIndex = 25;
            this.apartamentLabel.Text = "Apartment:";
            this.apartamentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(3, 143);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(47, 13);
            this.buildingLabel.TabIndex = 24;
            this.buildingLabel.Text = "Building:";
            this.buildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(3, 107);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 23;
            this.streetLabel.Text = "Street:";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(259, 77);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 22;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(3, 77);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 21;
            this.countryLabel.Text = "Country:";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(3, 40);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(59, 13);
            this.indexLabel.TabIndex = 20;
            this.indexLabel.Text = "Post index:";
            this.indexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(68, 37);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.ReadOnly = true;
            this.indexTextBox.Size = new System.Drawing.Size(92, 20);
            this.indexTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.indexTextBox, "Почтовый индекс, целое шестизначное число.");
            this.indexTextBox.TextChanged += new System.EventHandler(this.IndexTextBoxTextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.deliveryAddressLabel);
            this.Controls.Add(this.apartamentLabel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.indexTextBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(420, 172);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label deliveryAddressLabel;
        private System.Windows.Forms.Label apartamentLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
