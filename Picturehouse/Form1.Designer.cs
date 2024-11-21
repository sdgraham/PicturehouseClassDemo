namespace Picturehouse
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTitles = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblRunningTime);
            this.groupBox1.Controls.Add(this.lblAgeRating);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.listBoxTitles);
            this.groupBox1.Location = new System.Drawing.Point(396, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current titles";
            // 
            // listBoxTitles
            // 
            this.listBoxTitles.FormattingEnabled = true;
            this.listBoxTitles.Location = new System.Drawing.Point(21, 32);
            this.listBoxTitles.Name = "listBoxTitles";
            this.listBoxTitles.Size = new System.Drawing.Size(256, 199);
            this.listBoxTitles.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 244);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(18, 267);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(35, 13);
            this.lblAgeRating.TabIndex = 2;
            this.lblAgeRating.Text = "label1";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(18, 290);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(35, 13);
            this.lblRunningTime.TabIndex = 3;
            this.lblRunningTime.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 313);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filmsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
           
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilmToolStripMenuItem});
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.filmsToolStripMenuItem.Text = "Films";
            // 
            // addFilmToolStripMenuItem
            // 
            this.addFilmToolStripMenuItem.Name = "addFilmToolStripMenuItem";
            this.addFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFilmToolStripMenuItem.Text = "Add film";
            this.addFilmToolStripMenuItem.Click += new System.EventHandler(this.addFilmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Picture House Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listBoxTitles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilmToolStripMenuItem;
    }
}

