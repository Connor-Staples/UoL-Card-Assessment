using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        public static List<Card> pack = new List<Card>();


        public Pack()
        {
          
            //Initialises the pack
            for(int i = 1; i < 15; i++)
            {
                for(int j = 1; j < 5;j++)
                {
                    
                    pack.Add(new Card(i, j));
                }
            }
           
        }
        


        
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if(typeOfShuffle == 1) //Fisher-Yates 
            {
              
                Random random = new Random();

                //Variables initialised 
                int numRandom;
                Card c; 

                //loops for the pack size
                for(int unstruckCard = pack.Count - 1 ;unstruckCard > 0;unstruckCard--)
                {
                   //gets a random number between 0 and the amount of cards remaining
                    numRandom = random.Next(0, unstruckCard);

                    //swaps the card with the card at the random position
                    c = pack[unstruckCard];
                    pack[unstruckCard] = pack[numRandom];
                    pack[numRandom] = c;
                }
                
            }

            if(typeOfShuffle == 2) //Riffle Shuffle 
            {
                //splits the pack into 2
                List<Card> pack1 = pack.GetRange(0, (pack.Count - 1) / 2);
                List<Card> pack2 = pack.GetRange((pack.Count - 1) / 2, (pack.Count - 1) / 2);

                //empty list to add to
                List<Card> emptyPack = new List<Card>();

                for(int i = 0;i < (pack.Count-1)/2;i++)
                {
                    emptyPack.Add(pack1[i]);
                    emptyPack.Add(pack2[i]);
                
                }
                pack = emptyPack;
            }
            if(typeOfShuffle == 3) //No shuffle
            {
                //does not shuffle
            }
            
            
            
            return true;

        }
        public static Card deal()
        {

            //Deals one card

            
            return pack[0];
            

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> empty = new List<Card>();
            try
            {

            
                for(int i = 0; i < amount; i++)
                {
                    empty.Add(pack[i]);
                }
            } catch
            {
                Console.WriteLine("amount is too large");
            }

            return empty;

            
        }
        
        
    }
        
}
