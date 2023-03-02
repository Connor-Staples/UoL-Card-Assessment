using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public Testing()
        {
            //create pack class
            Pack pack = new Pack();
            //Fisher Yates shuffle
            Pack.shuffleCardPack(1);
            //Riffle shuffle
            Pack.shuffleCardPack(2);
            //No shuffle
            Pack.shuffleCardPack(3);

            //deals and prints the card
            Pack.dealCard(100);
            Card c = Pack.deal();
            Console.WriteLine("Value " + c.Value + " - " + "Suit " + c.Suit);

        }
    }
}
