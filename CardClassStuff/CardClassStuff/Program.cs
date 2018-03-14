using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;

namespace CardClassStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();
            TestCardMethods();
            TestDeckMethods();
            Console.ReadLine();
        }

        static void TestCardConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card("heart", 13);

            Console.WriteLine("Testing default constructor. " + c1.ToString());
            Console.WriteLine("Testing overloaded constructor. " + c2.ToString() + "s");
        }

        static void TestCardMethods()
        {
            //creating the testing cards
            Card defaultCard = new Card();
            Card clubCard = new Card(1, 1);
            Card diamondCard = new Card(2, 12);
            Card heartcard = new Card(3, 13);
            Card spadeCard = new Card(4, 10);

            //creating the deck and storing the cards in the deck
            Deck testDeck = new Deck();
            testDeck.Add(defaultCard);
            testDeck.Add(clubCard);
            testDeck.Add(diamondCard);
            testDeck.Add(heartcard);
            testDeck.Add(spadeCard);

            for(int i = 0; i < testDeck.Count; i++)
            {
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " ToString():");
                Console.WriteLine(testDeck[i].ToString());
                Console.WriteLine("Testing card " + i.ToString() + " IsAce():");
                if (testDeck[i].IsAce())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsBlack():");
                if (testDeck[i].IsBlack())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsClub():");
                if (testDeck[i].IsClub())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsDiamond():");
                if (testDeck[i].IsDiamond())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsFaceCard():");
                if (testDeck[i].IsFaceCard())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsHeart():");
                if (testDeck[i].IsHeart())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsRed():");
                if (testDeck[i].IsRed())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
                Console.WriteLine("Testing card " + testDeck[i].ToString() + " IsSpade():");
                if (testDeck[i].IsSpade())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");

            }
            
        }

        static void TestDeckMethods()
        {
            Deck testDeck = new Deck();
            Deck fullTestDeck = testDeck.fillDeck();

            Console.WriteLine("Testing empty deck method: ");
            if (testDeck.isEmpty())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine("Testing fillDeck method: ");
            Console.WriteLine("Number of cards in a full deck is: " + fullTestDeck.Count);
            Console.WriteLine("Testing deck ToString method: ");
            Console.WriteLine(fullTestDeck.ToString());
        }
    }
}
