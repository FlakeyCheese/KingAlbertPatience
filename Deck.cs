using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
       public Card[] cards = new Card[52];
       string imageFolder = @"..\..\..\cards";
        public Deck ()
        {
            Card[] cards = CardLoader.LoadCards(imageFolder);
            this.cards = cards;
        }
        public void ShuffleDeck()//a durstenfeld shuffle of the deck
        {

            int currentIndex = 0;
            int length = cards.Length;
            while (currentIndex < length)
            {
                int randomIndex = Random.Shared.Next(currentIndex, length);
                Swap( currentIndex, randomIndex);
                currentIndex++;
            }
        }
        private void Swap( int currentIndex, int randomIndex)//method to swap two cards
        {
            Card temp = cards[currentIndex];
            cards[currentIndex] = cards[randomIndex];
            cards[randomIndex] = temp;
        }
       
    }
}
