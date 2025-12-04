using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Row
    {
        public Card[] cardsInRow;
        int currentCardIndex = 1;//track the index of the next available position in the row

        public Row()
        {
            cardsInRow = new Card[14];
        }

        public void InitialSetCards(Card card)
        {
            cardsInRow[currentCardIndex] = card;
            currentCardIndex++;
        }
    }
}
