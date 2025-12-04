namespace CardGame
{
    public partial class Form1 : Form
    {
        string imageFolder = @"..\..\..\cards";
        //public static Card[] deck = new Card[52];
        public static Row? row1;
        public static Row? row2;
        public static Row? row3;
        public static Row? row4;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            row1 = new Row(this,50);            
            row2 = new Row(this,200);            
            row3 = new Row(this,350);            
            row4 = new Row(this,500);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Card[] deck = CardLoader.LoadCards(imageFolder);            
            ShuffleDeck(deck);            
            DealCards(deck);
            
        }

        private void ShuffleDeck(Card[] deck)//a durstenfeld shuffle of the deck
        {
            
            int currentIndex = 0;
            int length = deck.Length;
            while (currentIndex < length)
            {
                int randomIndex = Random.Shared.Next(currentIndex, length);
                Swap(deck, currentIndex, randomIndex);
                currentIndex++;
            }
        }
        private void Swap(Card[] deck,int currentIndex,int randomIndex)//method to swap two cards
        {
            Card temp = deck[currentIndex];
            deck[currentIndex] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
        private void DealCards(Card[] deck)
        {
            
            for (int i = 0; i < 13; i++)
             {   
            row1.InitialSetCards(deck[i]);
            row2.InitialSetCards(deck[i + 13]);
             row3.InitialSetCards(deck[i + 26]);
            row4.InitialSetCards(deck[i + 39]);
            }
        }
    }
}
