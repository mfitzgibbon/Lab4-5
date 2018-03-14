using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Deck
    {
        private List<Card> cards;

        public Card this[int i]
        {
            get
            {
                return cards[i];
            }
            set
            {
                cards[i] = value;
            }
        }



        public Deck()
        {
            cards = new List<Card>();
        }

        public int Count
        {
            get { return cards.Count; }
        }

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

        public override string ToString()
        {
            return base.ToString();
        }

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
    }
}
