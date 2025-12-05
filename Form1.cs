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
       



    }
}
