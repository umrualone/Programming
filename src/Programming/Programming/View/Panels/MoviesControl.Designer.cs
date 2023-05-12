using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ratingLabel = new System.Windows.Forms.Label();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.findMovieButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(156, 210);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(58, 20);
            this.ratingLabel.TabIndex = 28;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moviesListBox
            // 
            this.moviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(18, 26);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(112, 407);
            this.moviesListBox.TabIndex = 21;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(156, 164);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(58, 20);
            this.genreLabel.TabIndex = 27;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(155, 118);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 20);
            this.yearLabel.TabIndex = 26;
            this.yearLabel.Text = "Year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(156, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 20);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(156, 72);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 20);
            this.timeLabel.TabIndex = 25;
            this.timeLabel.Text = "Time:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Location = new System.Drawing.Point(155, 49);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(92, 20);
            this.titleTextBox.TabIndex = 19;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.Location = new System.Drawing.Point(155, 95);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(92, 20);
            this.timeTextBox.TabIndex = 20;
            this.timeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // findMovieButton
            // 
            this.findMovieButton.BackColor = System.Drawing.Color.Silver;
            this.findMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findMovieButton.Location = new System.Drawing.Point(155, 277);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(55, 19);
            this.findMovieButton.TabIndex = 18;
            this.findMovieButton.Text = "Find";
            this.findMovieButton.UseVisualStyleBackColor = false;
            this.findMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTextBox.Location = new System.Drawing.Point(155, 141);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(92, 20);
            this.yearTextBox.TabIndex = 22;
            this.yearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingTextBox.Location = new System.Drawing.Point(155, 233);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(92, 20);
            this.ratingTextBox.TabIndex = 24;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // genreTextBox
            // 
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreTextBox.Location = new System.Drawing.Point(155, 187);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(92, 20);
            this.genreTextBox.TabIndex = 23;
            this.genreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.moviesListBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.findMovieButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(331, 460);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button findMovieButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox genreTextBox;

        #endregion
    }
}