using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BronzeCard bronzeCard = new BronzeCard("Mark", 0);
                bronzeCard.RequiredDataOutput(150);
                Console.WriteLine("");
                SilverCard silverCard = new SilverCard("Jack", 600);
                silverCard.RequiredDataOutput(850);
                Console.WriteLine("");
                GoldCard goldCard = new GoldCard("Jack", 1500);
                goldCard.RequiredDataOutput(1300);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
