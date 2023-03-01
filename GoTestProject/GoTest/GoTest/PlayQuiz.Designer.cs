namespace GoTest
{
    partial class PlayQuiz
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
            this.numLabel = new System.Windows.Forms.Label();
            this.questionNumLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.currentQuestionLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.numLabel);
            this.panel1.Location = new System.Drawing.Point(41, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 81);
            this.panel1.TabIndex = 0;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.numLabel.Location = new System.Drawing.Point(3, 25);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(133, 33);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "Question";
            // 
            // questionNumLabel
            // 
            this.questionNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionNumLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumLabel.Location = new System.Drawing.Point(41, 114);
            this.questionNumLabel.Name = "questionNumLabel";
            this.questionNumLabel.Size = new System.Drawing.Size(881, 153);
            this.questionNumLabel.TabIndex = 1;
            this.questionNumLabel.Text = "\r\n";
            // 
            // aLabel
            // 
            this.aLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.aLabel.Location = new System.Drawing.Point(37, 281);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(885, 23);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "a)";
            // 
            // bLabel
            // 
            this.bLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bLabel.Location = new System.Drawing.Point(37, 311);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(885, 21);
            this.bLabel.TabIndex = 3;
            this.bLabel.Text = "b)";
            // 
            // cLabel
            // 
            this.cLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cLabel.Location = new System.Drawing.Point(37, 342);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(885, 21);
            this.cLabel.TabIndex = 4;
            this.cLabel.Text = "c)";
            // 
            // dLabel
            // 
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dLabel.Location = new System.Drawing.Point(37, 376);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(885, 21);
            this.dLabel.TabIndex = 5;
            this.dLabel.Text = "d)";
            // 
            // currentQuestionLabel
            // 
            this.currentQuestionLabel.AutoSize = true;
            this.currentQuestionLabel.Location = new System.Drawing.Point(892, 101);
            this.currentQuestionLabel.Name = "currentQuestionLabel";
            this.currentQuestionLabel.Size = new System.Drawing.Size(30, 13);
            this.currentQuestionLabel.TabIndex = 10;
            this.currentQuestionLabel.Text = "0/32";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(690, 458);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(164, 20);
            this.answerTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(616, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Answer:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(779, 484);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 13;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(41, 551);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 59);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(41, 454);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(153, 53);
            this.nextButton.TabIndex = 15;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.questionNumLabel);
            this.Controls.Add(this.panel1);
            this.Name = "PlayQuiz";
            this.Size = new System.Drawing.Size(961, 636);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label questionNumLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label currentQuestionLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextButton;
    }
}
