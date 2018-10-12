using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClsWrkEnum;


namespace ClsWrkEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            for (int i = 0; i < 100; i++)
            {
                int suits = ran.Next(4);
                int values = ran.Next(1, 14);
                Card card = new Card((Card.Suits)suits, (Card.Values)values);
                Console.WriteLine(card.Name());
                Thread.Sleep(1000);
            }
            

            Console.WriteLine("Hello World!");
            Console.ReadKey();

         }
    }
}
