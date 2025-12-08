namespace CardGame
{
    partial class LoseDialogue
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
            label1 = new Label();
            btnPlayAgain = new Button();
            btnExit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Heiti Std R", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(365, 30);
            label1.TabIndex = 0;
            label1.Text = "There are no more valid moves";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(279, 178);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(75, 23);
            btnPlayAgain.TabIndex = 1;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(51, 178);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Heiti Std R", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 0;
            label2.Text = "You have lost";
            // 
            // LoseDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoseDialogue";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "You Lose";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPlayAgain;
        private Button btnExit;
        private Label label2;
    }
}