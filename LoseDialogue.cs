using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class LoseDialogue : Form
    {
        Form1 form1;
        public LoseDialogue(Form1 form1, string msg, int score)
        {
            InitializeComponent();
            this.form1 = form1;
            lblGameOverMsg.Text = msg;
            lblScore.Text = "Score: " + score.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            form1.GameStart(deck);
            this.Close();
        }
    }
}
