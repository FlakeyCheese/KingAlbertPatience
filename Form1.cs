namespace CardGame
{
    public partial class Form1 : Form
    {

        //public static Card[] deck = new Card[52];
        public static Board? board;

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
        }
        public void commonDragEnter(object sender, DragEventArgs e)
        {

            // Check if the data being dragged is a PictureBox
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                // Allow the Move effect, which will show the correct cursor
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // Otherwise, block the drop (shows the 'no entry' cursor)
                e.Effect = DragDropEffects.None;
            }

        }
        public void commonDragDrop(object sender, DragEventArgs e)
        {
            // The PictureBox that was dropped ON
            PictureBox targetPB = (PictureBox)sender;

            // The PictureBox that was dragged (the source)
            PictureBox draggedPB = (PictureBox)e.Data.GetData(typeof(PictureBox));

            // --- 1. Perform the Visual Cut and Paste (Move) ---

            // Transfer the image to the target PictureBox
            targetPB.Image = draggedPB.Image;

            // Remove the image from the source PictureBox (the "cut" part)
            draggedPB.Image = null;

            // --- 2. Update the Underlying Card Data (Crucial for Game State) ---

            if (board != null)
            {
                // You still need the GetCardIndices method in Board.cs (as discussed before)
                (int sourceY, int sourceX) = board.GetCardIndices(draggedPB);
                (int targetY, int targetX) = board.GetCardIndices(targetPB);

                // Move the Card object from source to target in the game array
                Card movedCard = board.cards[sourceY, sourceX];
                board.cards[targetY, targetX] = movedCard;

                // Set the source spot in the game array to null (the "cut" part)
                board.cards[sourceY, sourceX] = null;
            }
        }
        public void commonMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb, DragDropEffects.Move);
        }

     
    }
}
