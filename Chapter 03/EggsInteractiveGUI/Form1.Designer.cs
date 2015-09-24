namespace EggsInteractiveGUI
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
            this.firstChickenTextBox = new System.Windows.Forms.TextBox();
            this.secondChickenTextBox = new System.Windows.Forms.TextBox();
            this.thirdChickenTextBox = new System.Windows.Forms.TextBox();
            this.fourthChickenTextBox = new System.Windows.Forms.TextBox();
            this.fifthChickenTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter eggs produced by each of 5 chickens";
            // 
            // firstChickenTextBox
            // 
            this.firstChickenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstChickenTextBox.Location = new System.Drawing.Point(48, 69);
            this.firstChickenTextBox.Name = "firstChickenTextBox";
            this.firstChickenTextBox.Size = new System.Drawing.Size(42, 26);
            this.firstChickenTextBox.TabIndex = 1;
            // 
            // secondChickenTextBox
            // 
            this.secondChickenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondChickenTextBox.Location = new System.Drawing.Point(96, 69);
            this.secondChickenTextBox.Name = "secondChickenTextBox";
            this.secondChickenTextBox.Size = new System.Drawing.Size(42, 26);
            this.secondChickenTextBox.TabIndex = 2;
            // 
            // thirdChickenTextBox
            // 
            this.thirdChickenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdChickenTextBox.Location = new System.Drawing.Point(144, 69);
            this.thirdChickenTextBox.Name = "thirdChickenTextBox";
            this.thirdChickenTextBox.Size = new System.Drawing.Size(42, 26);
            this.thirdChickenTextBox.TabIndex = 3;
            // 
            // fourthChickenTextBox
            // 
            this.fourthChickenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthChickenTextBox.Location = new System.Drawing.Point(192, 69);
            this.fourthChickenTextBox.Name = "fourthChickenTextBox";
            this.fourthChickenTextBox.Size = new System.Drawing.Size(42, 26);
            this.fourthChickenTextBox.TabIndex = 4;
            // 
            // fifthChickenTextBox
            // 
            this.fifthChickenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifthChickenTextBox.Location = new System.Drawing.Point(240, 69);
            this.fifthChickenTextBox.Name = "fifthChickenTextBox";
            this.fifthChickenTextBox.Size = new System.Drawing.Size(42, 26);
            this.fifthChickenTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(65, 127);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(203, 40);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Click to calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.Location = new System.Drawing.Point(28, 194);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(279, 52);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 255);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.fifthChickenTextBox);
            this.Controls.Add(this.fourthChickenTextBox);
            this.Controls.Add(this.thirdChickenTextBox);
            this.Controls.Add(this.secondChickenTextBox);
            this.Controls.Add(this.firstChickenTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstChickenTextBox;
        private System.Windows.Forms.TextBox secondChickenTextBox;
        private System.Windows.Forms.TextBox thirdChickenTextBox;
        private System.Windows.Forms.TextBox fourthChickenTextBox;
        private System.Windows.Forms.TextBox fifthChickenTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

