namespace GoTest
{
    partial class SResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SResultsForm));
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sNavigation1 = new GoTest.SNavigation();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.resultDataGridView.Location = new System.Drawing.Point(254, 190);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(698, 434);
            this.resultDataGridView.TabIndex = 2;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(986, 208);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(120, 26);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "View Results";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(248, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(940, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sNavigation1
            // 
            this.sNavigation1.BackColor = System.Drawing.Color.DarkGreen;
            this.sNavigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sNavigation1.Location = new System.Drawing.Point(0, 0);
            this.sNavigation1.Name = "sNavigation1";
            this.sNavigation1.Size = new System.Drawing.Size(209, 659);
            this.sNavigation1.TabIndex = 26;
            // 
            // SResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 659);
            this.Controls.Add(this.sNavigation1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.resultDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SResultsForm";
            this.Text = "GoTest";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label2;
        private SNavigation sNavigation1;
    }
}