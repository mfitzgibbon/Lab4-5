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
            Card defaultCard = new Card();
            Card clubCard = new Card(1, 1);
            Card diamondCard = new Card(2, 12);
            Card heartcard = new Card(3, 13);
            Card spadeCard = new Card(4, 10);

            Deck newDeck = new Deck();

            Console.WriteLine("Testing default Card. Values: " + defaultCard.ToString());
            
        }
    }
}
