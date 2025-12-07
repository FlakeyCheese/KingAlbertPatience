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
            label1 = new Label();
            groupBox1 = new GroupBox();
            RBSoundOff = new RadioButton();
            RBSoundOn = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 40);
            label1.TabIndex = 0;
            label1.Text = "King Albert Solitaire";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBSoundOff);
            groupBox1.Controls.Add(RBSoundOn);
            groupBox1.Location = new Point(1638, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sound";
            // 
            // RBSoundOff
            // 
            RBSoundOff.AutoSize = true;
            RBSoundOff.Location = new Point(22, 56);
            RBSoundOff.Name = "RBSoundOff";
            RBSoundOff.Size = new Size(51, 24);
            RBSoundOff.TabIndex = 0;
            RBSoundOff.Text = "Off";
            RBSoundOff.UseVisualStyleBackColor = true;
            // 
            // RBSoundOn
            // 
            RBSoundOn.AutoSize = true;
            RBSoundOn.Checked = true;
            RBSoundOn.Location = new Point(22, 26);
            RBSoundOn.Name = "RBSoundOn";
            RBSoundOn.Size = new Size(49, 24);
            RBSoundOn.TabIndex = 0;
            RBSoundOn.TabStop = true;
            RBSoundOn.Text = "On";
            RBSoundOn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 949);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new Padding(10);
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
    }
}
