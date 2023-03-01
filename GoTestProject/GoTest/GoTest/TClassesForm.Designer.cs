namespace GoTest
{
    partial class TClassesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TClassesForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.newCourseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.tNavigation1 = new GoTest.TNavigation();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(416, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 97);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class";
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchButton.Location = new System.Drawing.Point(1380, 375);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 32);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1376, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter course id to view list of students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(1380, 326);
            this.courseIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(324, 26);
            this.courseIdTextBox.TabIndex = 10;
            this.courseIdTextBox.TextChanged += new System.EventHandler(this.courseIdTextBox_TextChanged);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsDataGridView.Location = new System.Drawing.Point(416, 265);
            this.studentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RowHeadersWidth = 62;
            this.studentsDataGridView.Size = new System.Drawing.Size(930, 626);
            this.studentsDataGridView.TabIndex = 9;
            this.studentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellContentClick);
            // 
            // newCourseTextBox
            // 
            this.newCourseTextBox.Location = new System.Drawing.Point(1380, 486);
            this.newCourseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newCourseTextBox.Name = "newCourseTextBox";
            this.newCourseTextBox.Size = new System.Drawing.Size(324, 26);
            this.newCourseTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1376, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter a new course to register";
            // 
            // registerButton
            // 
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registerButton.Location = new System.Drawing.Point(1380, 526);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 32);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // tNavigation1
            // 
            this.tNavigation1.BackColor = System.Drawing.Color.DarkGreen;
            this.tNavigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tNavigation1.Location = new System.Drawing.Point(0, 0);
            this.tNavigation1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tNavigation1.Name = "tNavigation1";
            this.tNavigation1.Size = new System.Drawing.Size(330, 983);
            this.tNavigation1.TabIndex = 8;
            // 
            // TClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 983);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newCourseTextBox);
            this.Controls.Add(this.tNavigation1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.studentsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TClassesForm";
            this.Text = "GoTest";
            this.Load += new System.EventHandler(this.TClassesForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private TNavigation tNavigation1;
        private System.Windows.Forms.TextBox newCourseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
    }
}