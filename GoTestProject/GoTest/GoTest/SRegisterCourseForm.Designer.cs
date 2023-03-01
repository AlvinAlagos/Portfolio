namespace GoTest
{
    partial class SRegisterCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SRegisterCourseForm));
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sNavigation1 = new GoTest.SNavigation();
            this.yourCoursesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.courseDataGridView.Location = new System.Drawing.Point(254, 171);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.Size = new System.Drawing.Size(620, 407);
            this.courseDataGridView.TabIndex = 5;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(714, 584);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(160, 23);
            this.viewButton.TabIndex = 6;
            this.viewButton.Text = "Click To view Courses";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(894, 185);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(248, 20);
            this.courseTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter course you would like to register to";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(1044, 217);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(98, 23);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(251, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(940, 60);
            this.label2.TabIndex = 10;
            this.label2.Text = "Register Course";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sNavigation1
            // 
            this.sNavigation1.BackColor = System.Drawing.Color.DarkGreen;
            this.sNavigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sNavigation1.Location = new System.Drawing.Point(0, 0);
            this.sNavigation1.Name = "sNavigation1";
            this.sNavigation1.Size = new System.Drawing.Size(209, 643);
            this.sNavigation1.TabIndex = 26;
            // 
            // yourCoursesButton
            // 
            this.yourCoursesButton.Location = new System.Drawing.Point(254, 584);
            this.yourCoursesButton.Name = "yourCoursesButton";
            this.yourCoursesButton.Size = new System.Drawing.Size(160, 23);
            this.yourCoursesButton.TabIndex = 27;
            this.yourCoursesButton.Text = "Click To view your Courses";
            this.yourCoursesButton.UseVisualStyleBackColor = true;
            this.yourCoursesButton.Click += new System.EventHandler(this.yourCoursesButton_Click);
            // 
            // SRegisterCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 643);
            this.Controls.Add(this.yourCoursesButton);
            this.Controls.Add(this.sNavigation1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.courseDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SRegisterCourseForm";
            this.Text = "GoTest";
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
        private SNavigation sNavigation1;
        private System.Windows.Forms.Button yourCoursesButton;
    }
}