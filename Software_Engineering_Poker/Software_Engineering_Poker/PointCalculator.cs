using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    class PointCalculator
    {
        int numCards;
        int[] cardNumbers;
        int[] cardTypes;
        string[] cards;
        int cardsChecked;
        int[] number;
        int[] type;

        public PointCalculator()
        {
            numCards = 7;
            cardsChecked = 0;
            cardNumbers = new int[numCards];
            cardTypes = new int[numCards];   //0=hart 1=klaver 2=ruit 3=schop 
            cards = new string[numCards];
            number = new int[numCards];
            type = new int[numCards];
        }

        public int calculatePoints(string card1, string card2, string card3, string card4, string card5, string card6, string card7)
        {
            cards[0] = card1;
            cards[1] = card2;
            cards[2] = card3;
            cards[3] = card4;
            cards[4] = card5;
            cards[5] = card6;
            cards[6] = card7;
            cardTypes = getCardTypes(cards);
            cardsChecked = 0;
            cardNumbers = getCardNumber(cards);

            Console.WriteLine(fourOfAKind());
            //if (royalFlush()) {  return 110; }
            if (fourOfAKind()) { return 100; }
            else if (fullHouse()) { return 90; }
            else if (straight()) { return 80; }
            else if (threeOfAKind()) { return 70; }
            else if (twoPair()) { return 60; }
            else if (pair()) { return 50; }
            else //high card
            {
                int points;

                points = cardNumbers.Max();
                cardsChecked = 0;
                Console.WriteLine(points);
                return points;
            }
        }

        private int[] getCardNumber(string[] cards)
        {
            
            
            if(int.TryParse(cards[cardsChecked], out number[cardsChecked]))
            {
                if(number[cardsChecked] == 1) { number[cardsChecked] = 14; }
                //Console.WriteLine("cards checked" + cardsChecked);
                cardsChecked++;
            }
            else
            {

                cards[cardsChecked] = cards[cardsChecked].Substring(1);
                getCardNumber(cards);
            }
            
            while(cardsChecked < numCards)
            {
                getCardNumber(cards);
            }

            
            return number;
        }

        private int[] getCardTypes(string[] cards)
        {
            string cardType;
            cardType = cards[cardsChecked].Remove(1);
            
            switch (cardType)
            {
                case "h":
                    type[cardsChecked] = 0; //hart
                    cardsChecked++;
                    break;
                case "k":
                    type[cardsChecked] = 1; //klaver
                    cardsChecked++;
                    break;
                case "r":
                    type[cardsChecked] = 2; //ruit
                    cardsChecked++;
                    break;
                case "s":
                    type[cardsChecked] = 3; //schop
                    cardsChecked++;
                    break;
            }

            while (cardsChecked < numCards)
            {
                getCardTypes(cards);
            }


            
            return type;
        }

        //bool IsSequential(int[] array)
        //{
        //    return array.Zip(array.Skip(1), (a, b) => (a + 1) == b).All(x => x);
        //}

        //private bool royalFlush()
        //{
        //    var result = cardTypes.GroupBy(i => i)
        //        .Select(g => new { Value = g.Key, Count = g.Count() })
        //        .Where(x => x.Count > 1)
        //        .ToList();

        //    foreach (var pair in result)
        //    {
        //        if( pair.Count >= 5)
        //        {

        //            if (IsSequential(cardNumbers))
        //            {
        //                return true;
        //            }

        //            else
        //            {
        //                return false;
        //            }




        //        }
        //        else
        //        {
        //            return false;
                    
        //        }
        //    }
        //    return false;

        //}

        private bool fourOfAKind()
        {
            var result = cardNumbers.GroupBy(i => i)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1)
                .ToList();

            foreach (var pair in result)
            {
                if(pair.Count == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
                return true;
        }

        private bool fullHouse()
        {
            return false;
        }

        private bool straight()
        {
            return false;
        }

        private bool threeOfAKind()
        {
            return false;
        }

        private bool twoPair()
        {
            return false;
        }

        private bool pair()
        {
            return false;
        }

    }
}
