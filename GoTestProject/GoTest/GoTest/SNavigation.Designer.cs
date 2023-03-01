namespace GoTest
{
    partial class SNavigation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.viewQuizButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.viewQuizButton);
            this.panel1.Controls.Add(this.checkButton);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 646);
            this.panel1.TabIndex = 4;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.userLabel.Location = new System.Drawing.Point(14, 151);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 17);
            this.userLabel.TabIndex = 11;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.DarkGreen;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.homeButton.Location = new System.Drawing.Point(1, 223);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(205, 56);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // viewQuizButton
            // 
            this.viewQuizButton.BackColor = System.Drawing.Color.DarkGreen;
            this.viewQuizButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.viewQuizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuizButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.viewQuizButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewQuizButton.Location = new System.Drawing.Point(1, 357);
            this.viewQuizButton.Name = "viewQuizButton";
            this.viewQuizButton.Size = new System.Drawing.Size(205, 56);
            this.viewQuizButton.TabIndex = 5;
            this.viewQuizButton.Text = "View quizzes";
            this.viewQuizButton.UseVisualStyleBackColor = false;
            this.viewQuizButton.Click += new System.EventHandler(this.viewQuizButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.DarkGreen;
            this.checkButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.checkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkButton.Location = new System.Drawing.Point(1, 419);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(205, 56);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check Results";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkGreen;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.registerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registerButton.Location = new System.Drawing.Point(-1, 285);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(207, 66);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register Course";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 120);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Image = global::GoTest.Properties.Resources.GoTestLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.DarkGreen;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.logOutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logOutButton.Location = new System.Drawing.Point(-1, 481);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(217, 78);
            this.logOutButton.TabIndex = 12;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // SNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Controls.Add(this.panel1);
            this.Name = "SNavigation";
            this.Size = new System.Drawing.Size(209, 646);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewQuizButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button logOutButton;
    }
}
