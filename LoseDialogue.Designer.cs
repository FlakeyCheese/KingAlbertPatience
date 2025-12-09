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
            SuspendLayout();
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(145, 93);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(75, 23);
            btnPlayAgain.TabIndex = 1;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(25, 93);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblGameOverMsg
            // 
            lblGameOverMsg.AutoSize = true;
            lblGameOverMsg.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOverMsg.Location = new Point(12, 42);
            lblGameOverMsg.Name = "lblGameOverMsg";
            lblGameOverMsg.Size = new Size(85, 20);
            lblGameOverMsg.TabIndex = 2;
            lblGameOverMsg.Text = "message";
            // 
            // LoseDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            ControlBox = false;
            Controls.Add(lblGameOverMsg);
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoseDialogue";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "GAME OVER";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlayAgain;
        private Button btnExit;
        public Label lblGameOverMsg;
    }
}