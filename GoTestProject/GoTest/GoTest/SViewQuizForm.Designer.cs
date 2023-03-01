namespace GoTest
{
    partial class SViewQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SViewQuizForm));
            this.quizDataGridView = new System.Windows.Forms.DataGridView();
            this.quizTextBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.playQuiz = new GoTest.PlayQuiz();
            this.sNavigation1 = new GoTest.SNavigation();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quizDataGridView
            // 
            this.quizDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.quizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizDataGridView.Location = new System.Drawing.Point(245, 195);
            this.quizDataGridView.Name = "quizDataGridView";
            this.quizDataGridView.Size = new System.Drawing.Size(359, 426);
            this.quizDataGridView.TabIndex = 5;
            // 
            // quizTextBox
            // 
            this.quizTextBox.Location = new System.Drawing.Point(674, 195);
            this.quizTextBox.Name = "quizTextBox";
            this.quizTextBox.Size = new System.Drawing.Size(232, 20);
            this.quizTextBox.TabIndex = 6;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(831, 238);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter QuizId you want to play";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quiz list";
            // 
            // viewLabel
            // 
            this.viewLabel.BackColor = System.Drawing.Color.Green;
            this.viewLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.viewLabel.Location = new System.Drawing.Point(273, 42);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(940, 60);
            this.viewLabel.TabIndex = 12;
            this.viewLabel.Text = "View Quiz";
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playQuiz
            // 
            this.playQuiz.Location = new System.Drawing.Point(232, 15);
            this.playQuiz.Name = "playQuiz";
            this.playQuiz.Size = new System.Drawing.Size(957, 637);
            this.playQuiz.TabIndex = 10;
            this.playQuiz.Visible = false;
            // 
            // sNavigation1
            // 
            this.sNavigation1.BackColor = System.Drawing.Color.DarkGreen;
            this.sNavigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sNavigation1.Location = new System.Drawing.Point(0, 0);
            this.sNavigation1.Name = "sNavigation1";
            this.sNavigation1.Size = new System.Drawing.Size(209, 664);
            this.sNavigation1.TabIndex = 26;
            // 
            // SViewQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 664);
            this.Controls.Add(this.sNavigation1);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.playQuiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.quizTextBox);
            this.Controls.Add(this.quizDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SViewQuizForm";
            this.Text = "GoTest";
            this.Load += new System.EventHandler(this.SViewQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView quizDataGridView;
        private System.Windows.Forms.TextBox quizTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PlayQuiz playQuiz;
        private System.Windows.Forms.Label viewLabel;
        private SNavigation sNavigation1;
    }
}