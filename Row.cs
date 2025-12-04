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
        public PictureBox[]? pictureBoxes;
        int currentCardIndex = 1;//track the index of the next available position in the row
        Form1 form; //reference to the main form to add picture boxes
        public Row(Form1 form1, int yPosition)
        {
            cardsInRow = new Card[14];
            form = form1;
            PictureBox[] pictureBoxes = new PictureBox[14];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i] = new PictureBox
                {
                    Size = new Size(100, 140),
                    Location = new Point(i*100 +10, yPosition),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                form.Controls.Add(pictureBoxes[i]);
            }
        }

        public void InitialSetCards(Card card)
        {
            currentCardIndex++;
            cardsInRow[currentCardIndex] = card;
            
        }
       
    }
}
