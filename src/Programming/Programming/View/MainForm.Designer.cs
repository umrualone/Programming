namespace Programming.View
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.seasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonHandleControl = new Programming.View.Panels.SeasonHandleControl();
            this.weekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl = new Programming.View.Panels.WeekdayParsingControl();
            this.enumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl = new Programming.View.Panels.EnumerationsControl();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl = new Programming.View.Panels.RectanglesControl();
            this.moviesGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl = new Programming.View.Panels.MoviesControl();
            this.ractanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.tabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.seasonHandleGroupBox.SuspendLayout();
            this.weekdayParsingGroupBox.SuspendLayout();
            this.enumerationsGroupBox.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.rectanglesGroupBox.SuspendLayout();
            this.moviesGroupBox.SuspendLayout();
            this.ractanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.enumsTabPage);
            this.tabControl.Controls.Add(this.classesTabPage);
            this.tabControl.Controls.Add(this.ractanglesTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(796, 458);
            this.tabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.enumsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enumsTabPage.Controls.Add(this.tableLayoutPanel1);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(788, 432);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enumerationsGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.seasonHandleGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekdayParsingGroupBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 212);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 212);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // seasonHandleGroupBox
            // 
            this.seasonHandleGroupBox.Controls.Add(this.seasonHandleControl);
            this.seasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleGroupBox.Location = new System.Drawing.Point(393, 3);
            this.seasonHandleGroupBox.Name = "seasonHandleGroupBox";
            this.seasonHandleGroupBox.Size = new System.Drawing.Size(384, 206);
            this.seasonHandleGroupBox.TabIndex = 0;
            this.seasonHandleGroupBox.TabStop = false;
            this.seasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonHandleControl
            // 
            this.seasonHandleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleControl.Location = new System.Drawing.Point(3, 16);
            this.seasonHandleControl.Name = "seasonHandleControl";
            this.seasonHandleControl.Size = new System.Drawing.Size(378, 187);
            this.seasonHandleControl.TabIndex = 0;
            // 
            // weekdayParsingGroupBox
            // 
            this.weekdayParsingGroupBox.Controls.Add(this.weekdayParsingControl);
            this.weekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.weekdayParsingGroupBox.Name = "weekdayParsingGroupBox";
            this.weekdayParsingGroupBox.Size = new System.Drawing.Size(384, 206);
            this.weekdayParsingGroupBox.TabIndex = 1;
            this.weekdayParsingGroupBox.TabStop = false;
            this.weekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl
            // 
            this.weekdayParsingControl.BackColor = System.Drawing.SystemColors.Control;
            this.weekdayParsingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl.Location = new System.Drawing.Point(3, 16);
            this.weekdayParsingControl.Name = "weekdayParsingControl";
            this.weekdayParsingControl.Size = new System.Drawing.Size(378, 187);
            this.weekdayParsingControl.TabIndex = 0;
            // 
            // enumerationsGroupBox
            // 
            this.enumerationsGroupBox.Controls.Add(this.enumerationsControl);
            this.enumerationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.enumerationsGroupBox.Name = "enumerationsGroupBox";
            this.enumerationsGroupBox.Size = new System.Drawing.Size(774, 206);
            this.enumerationsGroupBox.TabIndex = 1;
            this.enumerationsGroupBox.TabStop = false;
            this.enumerationsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl
            // 
            this.enumerationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl.Location = new System.Drawing.Point(3, 16);
            this.enumerationsControl.Name = "enumerationsControl";
            this.enumerationsControl.Size = new System.Drawing.Size(768, 187);
            this.enumerationsControl.TabIndex = 0;
            // 
            // classesTabPage
            // 
            this.classesTabPage.BackColor = System.Drawing.Color.Transparent;
            this.classesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.classesTabPage.Location = new System.Drawing.Point(4, 22);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(788, 432);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rectanglesGroupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.moviesGroupBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 424);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // rectanglesGroupBox
            // 
            this.rectanglesGroupBox.Controls.Add(this.rectanglesControl);
            this.rectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.rectanglesGroupBox.Name = "rectanglesGroupBox";
            this.rectanglesGroupBox.Size = new System.Drawing.Size(384, 418);
            this.rectanglesGroupBox.TabIndex = 2;
            this.rectanglesGroupBox.TabStop = false;
            this.rectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl
            // 
            this.rectanglesControl.BackColor = System.Drawing.SystemColors.Control;
            this.rectanglesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl.Location = new System.Drawing.Point(3, 16);
            this.rectanglesControl.Name = "rectanglesControl";
            this.rectanglesControl.Size = new System.Drawing.Size(378, 399);
            this.rectanglesControl.TabIndex = 0;
            // 
            // moviesGroupBox
            // 
            this.moviesGroupBox.Controls.Add(this.moviesControl);
            this.moviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesGroupBox.Location = new System.Drawing.Point(393, 3);
            this.moviesGroupBox.Name = "moviesGroupBox";
            this.moviesGroupBox.Size = new System.Drawing.Size(384, 418);
            this.moviesGroupBox.TabIndex = 3;
            this.moviesGroupBox.TabStop = false;
            this.moviesGroupBox.Text = "Movies";
            // 
            // moviesControl
            // 
            this.moviesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl.Location = new System.Drawing.Point(3, 16);
            this.moviesControl.Name = "moviesControl";
            this.moviesControl.Size = new System.Drawing.Size(378, 399);
            this.moviesControl.TabIndex = 0;
            // 
            // ractanglesTabPage
            // 
            this.ractanglesTabPage.Controls.Add(this.rectanglesCollisionControl);
            this.ractanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ractanglesTabPage.Name = "ractanglesTabPage";
            this.ractanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ractanglesTabPage.Size = new System.Drawing.Size(788, 432);
            this.ractanglesTabPage.TabIndex = 2;
            this.ractanglesTabPage.Text = "Rectangles";
            this.ractanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl
            // 
            this.rectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl.Name = "rectanglesCollisionControl";
            this.rectanglesCollisionControl.Size = new System.Drawing.Size(782, 426);
            this.rectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(812, 497);
            this.Name = "MainForm";
            this.Text = "Programming";
            this.tabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.seasonHandleGroupBox.ResumeLayout(false);
            this.weekdayParsingGroupBox.ResumeLayout(false);
            this.enumerationsGroupBox.ResumeLayout(false);
            this.classesTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.rectanglesGroupBox.ResumeLayout(false);
            this.moviesGroupBox.ResumeLayout(false);
            this.ractanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Programming.View.Panels.RectanglesCollisionControl rectanglesCollisionControl;

        private Programming.View.Panels.MoviesControl moviesControl;

        private System.Windows.Forms.GroupBox moviesGroupBox;

        private Programming.View.Panels.RectanglesControl rectanglesControl;

        private System.Windows.Forms.GroupBox rectanglesGroupBox;

        private Programming.View.Panels.SeasonHandleControl seasonHandleControl;

        private Programming.View.Panels.WeekdayParsingControl weekdayParsingControl;

        private Programming.View.Panels.EnumerationsControl enumerationsControl;

        private System.Windows.Forms.GroupBox weekdayParsingGroupBox;

        private System.Windows.Forms.GroupBox enumerationsGroupBox;

        private System.Windows.Forms.GroupBox seasonHandleGroupBox;

        private System.Windows.Forms.TabPage ractanglesTabPage;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.TabPage classesTabPage;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enumsTabPage;

        #endregion
    }
}