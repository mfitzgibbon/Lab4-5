using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Card
    {
        private string suit;
        private int value;

        private static string[] values = { "-1", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "null", "club", "diamond", "heart", "spade" };

        public Card()
        {
            this.suit = "null";
            this.value = 0;
        }

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public Card(int suit, int value)
        {
            this.suit = suits[suit];
            this.value = value;
        }

        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string GetDisplayText(string sep)
        {
            return suit + sep + value;
        }

        #region methods

        public bool IsAce()
        {
            if (this.value == 1)
            {
                return true;
            }
            return false;
        }

        public bool IsBlack()
        {
            if (this.suit == "club" || this.suit == "spade")
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

        public override string ToString()
        {
            return values[value] + " of " + suit;
        }

        #endregion
    }
}
