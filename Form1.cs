namespace CardGame
{
    public partial class Form1 : Form
    {
        string imageFolder = @"..\..\..\cards";
        public static Card[] deck = new Card[52];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Card[] deck = CardLoader.LoadCards(imageFolder);
            shuffleDeck();

        }

        private void shuffleDeck()
        {
            Random rnd = new Random();
            int currentIndex = 0;
            int length = deck.Length;
            while (currentIndex < length)
            {
                int randomIndex = rnd.Next(currentIndex, length);
                swap(currentIndex, randomIndex);
                currentIndex++;
            }
        }
        private void swap(int currentIndex,int randomIndex)
        {
            Card temp = deck[currentIndex];
            deck[currentIndex] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }
}
