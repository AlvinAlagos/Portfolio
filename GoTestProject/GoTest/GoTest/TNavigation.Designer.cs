namespace GoTest
{
    partial class TNavigation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.classButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoTest.Properties.Resources.GoTestLogo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.userLabel.Location = new System.Drawing.Point(18, 154);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 17);
            this.userLabel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.viewButton);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.classButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 727);
            this.panel1.TabIndex = 18;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.DarkGreen;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.logOutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logOutButton.Location = new System.Drawing.Point(0, 549);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(217, 78);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.DarkGreen;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.homeButton.Location = new System.Drawing.Point(3, 202);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(207, 81);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.DarkGreen;
            this.viewButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.viewButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewButton.Location = new System.Drawing.Point(0, 465);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(221, 78);
            this.viewButton.TabIndex = 5;
            this.viewButton.Text = "View quizzes";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click_1);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DarkGreen;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.createButton.Location = new System.Drawing.Point(3, 376);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(205, 83);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create new quiz";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click_1);
            // 
            // classButton
            // 
            this.classButton.BackColor = System.Drawing.Color.DarkGreen;
            this.classButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.classButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.classButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.classButton.Location = new System.Drawing.Point(3, 289);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(207, 81);
            this.classButton.TabIndex = 3;
            this.classButton.Text = "Courses";
            this.classButton.UseVisualStyleBackColor = false;
            this.classButton.Click += new System.EventHandler(this.classButton_Click_2);
            // 
            // TNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Controls.Add(this.panel1);
            this.Name = "TNavigation";
            this.Size = new System.Drawing.Size(220, 666);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button logOutButton;
    }
}
