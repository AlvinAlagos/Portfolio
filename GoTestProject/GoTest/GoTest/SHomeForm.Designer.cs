namespace GoTest
{
    partial class SHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SHomeForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sNavigation1 = new GoTest.SNavigation();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(814, 44);
            this.label4.TabIndex = 24;
            this.label4.Text = "Check Results: Click the Results button will redirect you to the Check Results pa" +
    "ge where\r\nyou can view your Results for all the quizzes you have finished. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(848, 44);
            this.label3.TabIndex = 23;
            this.label3.Text = "View Quizzes: Click the View quizzes button will redirect you to the View quizzes" +
    " page where\r\nyou can view all of the quizzes and choose which one to do.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(855, 44);
            this.label2.TabIndex = 22;
            this.label2.Text = "Register Course: Click the register button will redirect you to the Register Cour" +
    "se page where \r\nyou will be able to register for a course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Welcome to GoTest!\r\n";
            // 
            // sNavigation1
            // 
            this.sNavigation1.BackColor = System.Drawing.Color.DarkGreen;
            this.sNavigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sNavigation1.Location = new System.Drawing.Point(0, 0);
            this.sNavigation1.Name = "sNavigation1";
            this.sNavigation1.Size = new System.Drawing.Size(209, 634);
            this.sNavigation1.TabIndex = 25;
            // 
            // SHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 634);
            this.Controls.Add(this.sNavigation1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SHomeForm";
            this.Text = "GoTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SNavigation sNavigation1;
    }
}