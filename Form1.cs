using CardGame.Properties;
using System.Media;

namespace CardGame
{
    public partial class Form1 : Form
    {

        //public static Card[] deck = new Card[52];
        public static Board? board;
        SoundPlayer soundPlayer = new SoundPlayer();



        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Board(this, 50);
            Deck deck = new Deck();
            deck.ShuffleDeck();
            board.DealCards(deck);
            this.Cursor = Cursors.WaitCursor;
            groupBox1.Location = new Point(1440, -1);
        }
        public void commonDragEnter(object sender, DragEventArgs e)
        {

            // Check if the data being dragged is a PictureBox
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                // Allow the copy effect
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Disallow the drop
                e.Effect = DragDropEffects.None;
            }

        }
        public void commonDragDrop(object sender, DragEventArgs e)
        {
            // The PictureBox that was dropped ON
            PictureBox targetPB = (PictureBox)sender;


            // The PictureBox that was dragged (the source)
            PictureBox draggedPB = (PictureBox)e.Data.GetData(typeof(PictureBox));

            //  Validation Checks ---
            if (targetPB == draggedPB)
            {
                // If the source and target are the same, do nothing
                return;
            }
            if (draggedPB.Image == null)
            {
                // If there's no image to move, do nothing
                PlayBadSound();
                return;
            }
            if (targetPB.Image != null)
            {
                // If the target already has an image, do nothing
                PlayBadSound();
                return;
            }
            if (!CheckValidMove(draggedPB, targetPB))
            {
                // If the move is not valid according to game rules, do nothing
                PlayBadSound();
                return;
            }

            //  Perform the Visual Cut and Paste

            // Transfer the image to the target PictureBox
            targetPB.Image = draggedPB.Image;
            PlayGoodSound();


            // Remove the image from the source PictureBox 
            draggedPB.Image = null;

            //  Update the Underlying Card Data 

            if (board != null)
            {
                // get the index of each card from the board
                (int sourceY, int sourceX) = board.GetCardIndices(draggedPB);
                (int targetY, int targetX) = board.GetCardIndices(targetPB);

                // Move the Card object from source to target in the game array
                Card movedCard = board.cards[sourceY, sourceX];
                board.cards[targetY, targetX] = movedCard;

                // Set the source spot in the game array to null 
                board.cards[sourceY, sourceX] = null;
            }
            CheckForLoss();
        }
        public void commonMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb, DragDropEffects.Copy);
            if (CheckForWin())
            {
                MessageBox.Show("You Win!");
            }


        }
        public Boolean CheckValidMove(PictureBox sourcePB, PictureBox targetPB)
        {
            //get the card objects from the board
            if (board != null)
            {
                (int sourceY, int sourceX) = board.GetCardIndices(sourcePB);
                (int targetY, int targetX) = board.GetCardIndices(targetPB);
                Card sourceCard = board.cards[sourceY, sourceX];
                Card previousToTarget = board.cards[targetY, targetX - 1];
                //check if thecard to the left of target is null
                if (previousToTarget == null) return false;
                //check if the move is valid 
                if (previousToTarget.suit == sourceCard.suit && previousToTarget.value + 1 == sourceCard.value)
                {
                    return true;
                }

            }
            return false;
        }
        public void PlayGoodSound()
        {
            if (RBSoundOn.Checked == false) return;
            String soundFile = @"C:\Windows\Media\chimes.wav";
            soundPlayer.SoundLocation = soundFile;
            soundPlayer.Load();
            soundPlayer.Play();
        }
        public void PlayBadSound()
        {
            if (RBSoundOn.Checked == false) return;
            String soundFile = @"C:\Windows\Media\Windows Critical Stop.wav";
            soundPlayer.SoundLocation = soundFile;
            soundPlayer.Load();
            soundPlayer.Play();
        }
        public Boolean CheckForWin()
        {
            if (board != null)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < 14; x++)
                    {
                        if (board.cards[y, x] != null)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public void CheckForLoss()
        {
            //scan every box to find kings. If all free spaces are after a king then lose;
            int count = 4;
            if (board != null)
            {

                for (int y = 0; y < 4; y++)
                {
                    for (int x = 1; x < 14; x++)
                    {
                        if (board.cards[y, x] == null && board.cards[y, x - 1] == null)
                        {
                            count--;
                        }
                        else if (board.cards[y, x] == null && board.cards[y, x - 1].value == 13)
                        {
                            count--;
                        }
                    }
                }
            }
            if (count == 0) MessageBox.Show("no more moves possible. You lose");
            else return;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            board?.moveAces();
            timer1.Stop();
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 14; x++)
                {
                    board.pictureBoxes[y, x].Enabled = true;
                }
            }
            PlayGoodSound();
            this.Cursor = Cursors.Default;
        }
    }
}
