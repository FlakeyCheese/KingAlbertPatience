using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Board
    {
        public Card[,] cards;
        PictureBox[,] pictureBoxes;
        int currentXIndex = 0;//track the X index of the next available position in the row
        int currentYIndex = 0;//track which row we are on
        Form1 form; //reference to the main form to add picture boxes

        public Board(Form1 form1, int yPosition)
        {
            cards = new Card[4,14];
            form = form1;
            pictureBoxes = new PictureBox[4,14];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 14; x++)
                {
                    pictureBoxes[y,x] = new PictureBox
                    {
                        Size = new Size(100, 140),
                        Location = new Point(x * 110 + 10, yPosition),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    form.Controls.Add(pictureBoxes[y,x]);
                }
                yPosition += 150;
            }
        }
        public void DealCards(Deck deck)
        {
            int count = 0;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 1; x < 14; x++)
                {
                    cards[y, x] = deck.cards[count];
                    pictureBoxes[y, x].Image = deck.cards[count].face;
                    count++;
                }
                
            }

        }

    }
}
