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
        PictureBox[] pictureBoxes;
        int currentCardIndex = 0;//track the index of the next available position in the row
        Form1 form; //reference to the main form to add picture boxes
        public Row(Form1 form1, int yPosition)
        {
            cardsInRow = new Card[14];
            form = form1;
            pictureBoxes = new PictureBox[14];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i] = new PictureBox
                {
                    Size = new Size(100, 140),
                    Location = new Point(i*100 +10, yPosition),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                form.Controls.Add(pictureBoxes[i]);
            }
        }

        public void InitialSetCards(Card card)
        {
            currentCardIndex++;
            if (currentCardIndex < 14)
            {                
                cardsInRow[currentCardIndex] = card;
                this.pictureBoxes[currentCardIndex].Image = card.face;
            }
        }
       
    }
}
