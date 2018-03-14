using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Deck
    {
        #region variables, indexers, propreties, and constructors
        private List<Card> cards;

        public Card this[int i]
        {
            get
            {
                if (i < 0 || i >= cards.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return cards[i];
            }
            set
            {
                cards[i] = value;
            }
        }

        public Card this[string suit, int value]
        {
            get
            {
                if(value > 13)
                {
                    throw new ArgumentException("Maximum card value is 13 (King).");
                }
                foreach (Card c in cards)
                {
                    if (c.Suit == suit && c.Value == value)
                    {
                        return c;
                    }
                }
                return null;
            }
        }

        public Deck()
        {
            cards = new List<Card>();
        }

        public Deck(List<Card> constructDeck)
        {
            cards = constructDeck;
        }

        public int Count
        {
            get { return cards.Count; }
        }
        #endregion
        #region methods
        public int NumCard()
        {
            return this.Count;
        }

        public bool isEmpty()
        {
            if(this.NumCard() == 0)
            {
                return true;
            }

            return false;
        }

        public Card Deal()
        {
            Random newRand = new Random();

            return cards[newRand.Next(0, cards.Count + 1)];
        }

        public Deck fillDeck()
        {
            Deck fullDeck = new Deck();
            for(int suit = 1; suit < 5; suit++)
            {
                for(int value = 1; value < 14; value++)
                {
                    fullDeck.Add(new Card(suit, value));
                }
            }
            return fullDeck;
        }

        public override string ToString()
        {
            string deckString = "";
            for(int i = 0; i < this.Count; i++)
            {
                deckString += this[i].ToString() + "\n";
            }
            return deckString;
        }

        #region addmethods
        public void Add(Card card)
        {
            cards.Add(card);
        }

        public void Add(string suit, int value)
        {
            Card c = new Card(suit, value);
            cards.Add(c);
        }

        public void Add(int suit, int value)
        {
            Card c = new Card(suit, value);
            cards.Add(c);
        }
        #endregion
#endregion
    }
}
