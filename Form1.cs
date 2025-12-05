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
            e.Effect = DragDropEffects.Move;
        }
        public void commonDragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PictureBox draggedPB = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Image temp = pb.Image;
            pb.Image = draggedPB.Image;
            draggedPB.Image = temp;
        }
        public void commonMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb, DragDropEffects.Move);
        }
       



    }
}
