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
            this.priorityOrdersTabPage = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.ordersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.cartsTabPage = new System.Windows.Forms.TabPage();
            this.cartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.priorityOrdersTabPage.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            this.cartsTabPage.SuspendLayout();
            this.customersTabPage.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // priorityOrdersTabPage
            // 
            this.priorityOrdersTabPage.Controls.Add(this.priorityOrdersTab1);
            this.priorityOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.priorityOrdersTabPage.Name = "priorityOrdersTabPage";
            this.priorityOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.priorityOrdersTabPage.Size = new System.Drawing.Size(950, 598);
            this.priorityOrdersTabPage.TabIndex = 4;
            this.priorityOrdersTabPage.Text = "Priority Orders";
            this.priorityOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Customers = null;
            this.priorityOrdersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOrdersTab1.Items = null;
            this.priorityOrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(944, 592);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.ordersTab);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTabPage.Size = new System.Drawing.Size(950, 598);
            this.ordersTabPage.TabIndex = 3;
            this.ordersTabPage.Text = "Orders";
            this.ordersTabPage.UseVisualStyleBackColor = true;
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
            // cartsTabPage
            // 
            this.cartsTabPage.Controls.Add(this.cartsTab);
            this.cartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartsTabPage.Name = "cartsTabPage";
            this.cartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartsTabPage.Size = new System.Drawing.Size(950, 598);
            this.cartsTabPage.TabIndex = 2;
            this.cartsTabPage.Text = "Carts";
            this.cartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            this.cartsTab.Customers = null;
            this.cartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab.Items = null;
            this.cartsTab.Location = new System.Drawing.Point(3, 3);
            this.cartsTab.Name = "cartsTab";
            this.cartsTab.Size = new System.Drawing.Size(944, 592);
            this.cartsTab.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTab);
            this.customersTabPage.Location = new System.Drawing.Point(4, 22);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersTabPage.Size = new System.Drawing.Size(950, 598);
            this.customersTabPage.TabIndex = 1;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            this.customersTab.Customers = null;
            this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab.Location = new System.Drawing.Point(3, 3);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(944, 592);
            this.customersTab.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(950, 598);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Items = null;
            this.itemsTab.Location = new System.Drawing.Point(3, 3);
            this.itemsTab.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(944, 592);
            this.itemsTab.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.itemsTabPage);
            this.TabControl.Controls.Add(this.customersTabPage);
            this.TabControl.Controls.Add(this.cartsTabPage);
            this.TabControl.Controls.Add(this.ordersTabPage);
            this.TabControl.Controls.Add(this.priorityOrdersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(958, 624);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 624);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.priorityOrdersTabPage.ResumeLayout(false);
            this.ordersTabPage.ResumeLayout(false);
            this.cartsTabPage.ResumeLayout(false);
            this.customersTabPage.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage priorityOrdersTabPage;
        private System.Windows.Forms.TabPage ordersTabPage;
        private Tabs.OrdersTab ordersTab;
        private System.Windows.Forms.TabPage cartsTabPage;
        private Tabs.CartsTab cartsTab;
        private System.Windows.Forms.TabPage customersTabPage;
        public Tabs.CustomersTab customersTab;
        private System.Windows.Forms.TabPage itemsTabPage;
        private Tabs.ItemsTab itemsTab;
        private System.Windows.Forms.TabControl TabControl;
        private Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}