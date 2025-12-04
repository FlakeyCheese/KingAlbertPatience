using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        public Image face;
       public int value;
       public string suit;
        public Card(int value, string suit, Image face)
        {
            this.value = value;
            this.suit = suit;
            this.face = face;
        }

    }
}
