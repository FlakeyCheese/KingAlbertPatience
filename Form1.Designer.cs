namespace CardGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            RBSoundOff = new RadioButton();
            RBSoundOn = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblScore = new Label();
            label3 = new Label();
            lblHighScore = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 7);
            label1.Name = "label1";
            label1.Size = new Size(355, 34);
            label1.TabIndex = 0;
            label1.Text = "King Albert Solitaire";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBSoundOff);
            groupBox1.Controls.Add(RBSoundOn);
            groupBox1.Location = new Point(1334, -1);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(115, 42);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sound";
            // 
            // RBSoundOff
            // 
            RBSoundOff.AutoSize = true;
            RBSoundOff.Location = new Point(66, 20);
            RBSoundOff.Margin = new Padding(3, 2, 3, 2);
            RBSoundOff.Name = "RBSoundOff";
            RBSoundOff.Size = new Size(42, 19);
            RBSoundOff.TabIndex = 0;
            RBSoundOff.Text = "Off";
            RBSoundOff.UseVisualStyleBackColor = true;
            // 
            // RBSoundOn
            // 
            RBSoundOn.AutoSize = true;
            RBSoundOn.Checked = true;
            RBSoundOn.Location = new Point(19, 20);
            RBSoundOn.Margin = new Padding(3, 2, 3, 2);
            RBSoundOn.Name = "RBSoundOn";
            RBSoundOn.Size = new Size(41, 19);
            RBSoundOn.TabIndex = 0;
            RBSoundOn.TabStop = true;
            RBSoundOn.Text = "On";
            RBSoundOn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 18F);
            label2.Location = new Point(446, 8);
            label2.Name = "label2";
            label2.Size = new Size(103, 34);
            label2.TabIndex = 3;
            label2.Text = "Score";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Ravie", 18F);
            lblScore.Location = new Point(582, 8);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 34);
            lblScore.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ravie", 18F);
            label3.Location = new Point(715, 8);
            label3.Name = "label3";
            label3.Size = new Size(184, 34);
            label3.TabIndex = 3;
            label3.Text = "High Score";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Ravie", 18F);
            lblHighScore.Location = new Point(930, 4);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(0, 34);
            lblHighScore.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Ravie", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1237, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "HELP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Ravie", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1143, 11);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "GIVE UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1779, 712);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Padding = new Padding(9, 8, 9, 8);
            Text = "King Albert Solitaire";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton RBSoundOff;
        private RadioButton RBSoundOn;
        public System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label lblScore;
        private Label label3;
        private Label lblHighScore;
        private Button button1;
        private Button button2;
    }
}
