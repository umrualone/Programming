namespace ObjectOrientedPractics.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ordersTabControl = new System.Windows.Forms.TabControl();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.cartsTabPage = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ordersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.ordersTabControl.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.customersTabPage.SuspendLayout();
            this.cartsTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersTabControl
            // 
            this.ordersTabControl.Controls.Add(this.itemsTabPage);
            this.ordersTabControl.Controls.Add(this.customersTabPage);
            this.ordersTabControl.Controls.Add(this.cartsTabPage);
            this.ordersTabControl.Controls.Add(this.tabPage1);
            this.ordersTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTabControl.Location = new System.Drawing.Point(0, 0);
            this.ordersTabControl.Name = "ordersTabControl";
            this.ordersTabControl.SelectedIndex = 0;
            this.ordersTabControl.Size = new System.Drawing.Size(958, 624);
            this.ordersTabControl.TabIndex = 0;
            this.ordersTabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab1);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(950, 598);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Items = null;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(944, 592);
            this.itemsTab1.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTab1);
            this.customersTabPage.Location = new System.Drawing.Point(4, 22);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersTabPage.Size = new System.Drawing.Size(950, 598);
            this.customersTabPage.TabIndex = 1;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Customers = null;
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(944, 592);
            this.customersTab1.TabIndex = 0;
            // 
            // cartsTabPage
            // 
            this.cartsTabPage.Controls.Add(this.cartsTab1);
            this.cartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartsTabPage.Name = "cartsTabPage";
            this.cartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartsTabPage.Size = new System.Drawing.Size(950, 598);
            this.cartsTabPage.TabIndex = 2;
            this.cartsTabPage.Text = "Carts";
            this.cartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Customers = null;
            this.cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab1.Items = null;
            this.cartsTab1.Location = new System.Drawing.Point(3, 3);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(944, 592);
            this.cartsTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ordersTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 598);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Customer = null;
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(3, 3);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(944, 592);
            this.ordersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 624);
            this.Controls.Add(this.ordersTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.ordersTabControl.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.customersTabPage.ResumeLayout(false);
            this.cartsTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ordersTabControl;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.TabPage customersTabPage;
        private Tabs.ItemsTab itemsTab1;
        public Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage cartsTabPage;
        private Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private Tabs.OrdersTab ordersTab;
    }
}