using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkEnum
{
   public class Card
    {
       public enum Suits
        {
            Spades ,
            Diamonds, 
            Clubs,
            Hearts,
        }
        public enum Values 
        {
            Ace = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine= 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public string Name()
        {
            return $"{Value} of {Suit}";
        }

    }
}
