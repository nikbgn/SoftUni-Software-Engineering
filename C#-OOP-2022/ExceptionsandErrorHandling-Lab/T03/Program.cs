using System;
using System.Collections.Generic;

namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string pair in input)
            {
                var info = pair.Split();
                string face = info[0].ToString();
                string suit = info[1].ToString();

                try
                {
                    Card currCard = new Card(face, suit);
                    cards.Add(currCard);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(String.Join(" ",cards));


        }

    }
    class Card
    {
        private string face;
        private string suit;
        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string Face
        {
            get => this.face;
            private set
            {
                //Valid card faces are: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
                List<string> validFaces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                if (!validFaces.Contains(value)) throw new Exception("Invalid card!");
                this.face = value;
            }
        }
        public string Suit
        {
            get => this.suit;
            private set
            {
                //Valid card suits are: S (♠), H (♥), D (♦), C (♣)
                List<string> validSuits = new List<string>() { "S", "H", "D", "C" };
                if (!validSuits.Contains(value)) throw new Exception("Invalid card!");
                this.suit = value;
            }
        }


        public override string ToString()
        {
            string symbol = String.Empty;
            switch (Suit)
            {
                case "S":
                    symbol = '\u2660'.ToString();
                    break;
                case "H":
                    symbol = '\u2665'.ToString();
                    break;
                case "D":
                    symbol = '\u2666'.ToString();
                    break;
                case "C":
                    symbol = '\u2663'.ToString();
                    break;
                default:
                    break;
            }

            return $"[{Face}{symbol}]";
        }



    }
}



