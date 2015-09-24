namespace TestsInteractiveGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstTestScoreTextBox = new System.Windows.Forms.TextBox();
            this.secondTestScoreTextBox = new System.Windows.Forms.TextBox();
            this.thirdTestScoreTextBox = new System.Windows.Forms.TextBox();
            this.fourthTestScoreTextBox = new System.Windows.Forms.TextBox();
            this.fifthTestScoreTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter test scores for 5 tests";
            // 
            // firstTestScoreTextBox
            // 
            this.firstTestScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstTestScoreTextBox.Location = new System.Drawing.Point(55, 58);
            this.firstTestScoreTextBox.Name = "firstTestScoreTextBox";
            this.firstTestScoreTextBox.Size = new System.Drawing.Size(36, 26);
            this.firstTestScoreTextBox.TabIndex = 1;
            // 
            // secondTestScoreTextBox
            // 
            this.secondTestScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondTestScoreTextBox.Location = new System.Drawing.Point(97, 58);
            this.secondTestScoreTextBox.Name = "secondTestScoreTextBox";
            this.secondTestScoreTextBox.Size = new System.Drawing.Size(36, 26);
            this.secondTestScoreTextBox.TabIndex = 2;
            // 
            // thirdTestScoreTextBox
            // 
            this.thirdTestScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdTestScoreTextBox.Location = new System.Drawing.Point(139, 58);
            this.thirdTestScoreTextBox.Name = "thirdTestScoreTextBox";
            this.thirdTestScoreTextBox.Size = new System.Drawing.Size(36, 26);
            this.thirdTestScoreTextBox.TabIndex = 3;
            // 
            // fourthTestScoreTextBox
            // 
            this.fourthTestScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthTestScoreTextBox.Location = new System.Drawing.Point(181, 58);
            this.fourthTestScoreTextBox.Name = "fourthTestScoreTextBox";
            this.fourthTestScoreTextBox.Size = new System.Drawing.Size(36, 26);
            this.fourthTestScoreTextBox.TabIndex = 4;
            // 
            // fifthTestScoreTextBox
            // 
            this.fifthTestScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifthTestScoreTextBox.Location = new System.Drawing.Point(223, 58);
            this.fifthTestScoreTextBox.Name = "fifthTestScoreTextBox";
            this.fifthTestScoreTextBox.Size = new System.Drawing.Size(36, 26);
            this.fifthTestScoreTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(55, 116);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(207, 49);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.Location = new System.Drawing.Point(38, 196);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(255, 50);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 255);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.fifthTestScoreTextBox);
            this.Controls.Add(this.fourthTestScoreTextBox);
            this.Controls.Add(this.thirdTestScoreTextBox);
            this.Controls.Add(this.secondTestScoreTextBox);
            this.Controls.Add(this.firstTestScoreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Test Score Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstTestScoreTextBox;
        private System.Windows.Forms.TextBox secondTestScoreTextBox;
        private System.Windows.Forms.TextBox thirdTestScoreTextBox;
        private System.Windows.Forms.TextBox fourthTestScoreTextBox;
        private System.Windows.Forms.TextBox fifthTestScoreTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

