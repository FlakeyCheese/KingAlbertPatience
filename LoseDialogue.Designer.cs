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
            btnPlayAgain = new Button();
            btnExit = new Button();
            lblGameOverMsg = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(169, 93);
            btnPlayAgain.Margin = new Padding(3, 4, 3, 4);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(102, 31);
            btnPlayAgain.TabIndex = 1;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(169, 159);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 31);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblGameOverMsg
            // 
            lblGameOverMsg.AutoSize = true;
            lblGameOverMsg.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOverMsg.Location = new Point(14, 56);
            lblGameOverMsg.Name = "lblGameOverMsg";
            lblGameOverMsg.Size = new Size(106, 24);
            lblGameOverMsg.TabIndex = 2;
            lblGameOverMsg.Text = "message";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(14, 12);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(106, 24);
            lblScore.TabIndex = 2;
            lblScore.Text = "message";
            // 
            // LoseDialogue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(439, 215);
            ControlBox = false;
            Controls.Add(lblScore);
            Controls.Add(lblGameOverMsg);
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoseDialogue";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "GAME OVER";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlayAgain;
        private Button btnExit;
        public Label lblGameOverMsg;
        public Label lblScore;
    }
}