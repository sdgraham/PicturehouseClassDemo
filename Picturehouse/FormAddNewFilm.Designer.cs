namespace Picturehouse
{
    partial class FormAddNewFilm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAgeRating = new System.Windows.Forms.TextBox();
            this.txtRunningTime = new System.Windows.Forms.TextBox();
            this.dateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(65, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAgeRating
            // 
            this.txtAgeRating.Location = new System.Drawing.Point(65, 100);
            this.txtAgeRating.Name = "txtAgeRating";
            this.txtAgeRating.Size = new System.Drawing.Size(100, 20);
            this.txtAgeRating.TabIndex = 1;
            // 
            // txtRunningTime
            // 
            this.txtRunningTime.Location = new System.Drawing.Point(65, 156);
            this.txtRunningTime.Name = "txtRunningTime";
            this.txtRunningTime.Size = new System.Drawing.Size(100, 20);
            this.txtRunningTime.TabIndex = 2;
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.Location = new System.Drawing.Point(65, 211);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerRelease.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Running time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Release date";
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(65, 410);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(240, 61);
            this.btnAddFilm.TabIndex = 8;
            this.btnAddFilm.Text = "Add film";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // FormAddNewFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 494);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerRelease);
            this.Controls.Add(this.txtRunningTime);
            this.Controls.Add(this.txtAgeRating);
            this.Controls.Add(this.txtTitle);
            this.Name = "FormAddNewFilm";
            this.Text = "FormAddNewFilm";
            this.Load += new System.EventHandler(this.FormAddNewFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAgeRating;
        private System.Windows.Forms.TextBox txtRunningTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFilm;
    }
}