namespace GoTest
{
    partial class TViewQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TViewQuiz));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.quizIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tNavigation1 = new GoTest.TNavigation();
            this.resultsButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(280, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 63);
            this.panel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quizzes";
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchButton.Location = new System.Drawing.Point(280, 141);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsDataGridView.Location = new System.Drawing.Point(280, 170);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(620, 407);
            this.studentsDataGridView.TabIndex = 14;
            // 
            // quizIdTextBox
            // 
            this.quizIdTextBox.Location = new System.Drawing.Point(919, 190);
            this.quizIdTextBox.Name = "quizIdTextBox";
            this.quizIdTextBox.Size = new System.Drawing.Size(217, 20);
            this.quizIdTextBox.TabIndex = 19;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deleteButton.Location = new System.Drawing.Point(919, 223);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(916, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter QuizId of quiz to delete";
            // 
            // tNavigation1
            // 
            this.tNavigation1.BackColor = System.Drawing.Color.DarkGreen;
            this.tNavigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tNavigation1.Location = new System.Drawing.Point(0, 0);
            this.tNavigation1.Name = "tNavigation1";
            this.tNavigation1.Size = new System.Drawing.Size(220, 618);
            this.tNavigation1.TabIndex = 22;
            // 
            // resultsButton
            // 
            this.resultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resultsButton.Location = new System.Drawing.Point(734, 141);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(166, 23);
            this.resultsButton.TabIndex = 23;
            this.resultsButton.Text = "View Student Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // TViewQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 618);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.tNavigation1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.quizIdTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.studentsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TViewQuiz";
            this.Text = "GoTest";
            this.Load += new System.EventHandler(this.TViewQuiz_Load);
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
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.TextBox quizIdTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private TNavigation tNavigation1;
        private System.Windows.Forms.Button resultsButton;
    }
}