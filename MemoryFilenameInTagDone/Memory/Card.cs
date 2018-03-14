using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassConsole
{
    public class Card
    {
        private string suits[] = 
        private int values[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 , 12}
        private string suit;
        private int value;

        public Card() { }

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        #region properties
        public string Suit { get; set; }

        public int Value { get; set; }
        #endregion
        #region methods

        public bool IsAce()
        {
            if(this.value == 1)
            {
                return true;
            }
            return false;
        }

        public bool IsBlack()
        {
            if(this.suit == "club" || this.suit == "spade")
            {
                return true;
            }

            return false;
        }

        public bool IsClub()
        {
            if (this.suit == "club")
                return true;

            return false;
        }

        public bool IsDiamond()
        {
            if (this.suit == "diamond")
                return true;

            return false;
        }

        public bool IsFaceCard()
        {
            if (this.value > 10)
                return true;

            return false;
        }

        public bool IsHeart()
        {
            if (this.suit == "heart")
            {
                return true;
            }

            return false;
        }

        public bool IsRed()
        {
            if (this.suit == "heart" || this.suit == "diamond")
                return true;

            return false;
        }
        public bool IsSpade()
        {
            if (this.suit == "spade")
                return true;
            return false;
        }
        override public string ToString()
        {
            return this.suit + "|" + this.value.ToString();
        }
#endregion


    }
}
