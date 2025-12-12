namespace CardGame
{
    partial class Help
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 34);
            label1.TabIndex = 1;
            label1.Text = "King Albert Solitaire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(114, 34);
            label2.TabIndex = 1;
            label2.Text = "Rules:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(327, 22);
            label3.TabIndex = 1;
            label3.Text = "1. Aces are moved to the left.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(321, 22);
            label4.TabIndex = 1;
            label4.Text = "2. cards are dragged to move";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(331, 22);
            label5.TabIndex = 1;
            label5.Text = "3. Cards can only go into a gap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 144);
            label7.Name = "label7";
            label7.Size = new Size(602, 22);
            label7.TabIndex = 1;
            label7.Text = "4. Cards must be the same suit as the card to the left";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 166);
            label8.Name = "label8";
            label8.Size = new Size(583, 22);
            label8.TabIndex = 1;
            label8.Text = "5. Cards must be one higher than the card to the left";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 188);
            label9.Name = "label9";
            label9.Size = new Size(654, 22);
            label9.TabIndex = 1;
            label9.Text = "6.The game is over when each space has a king preceeding it";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 210);
            label10.Name = "label10";
            label10.Size = new Size(495, 22);
            label10.TabIndex = 1;
            label10.Text = "7.The game is won when all cards are in order";
            // 
            // button1
            // 
            button1.Location = new Point(12, 260);
            button1.Name = "button1";
            button1.Size = new Size(64, 28);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(670, 22);
            label6.TabIndex = 1;
            label6.Text = "8.One point is given for each card moved to the correct place.";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(682, 300);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Help";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label6;
    }
}