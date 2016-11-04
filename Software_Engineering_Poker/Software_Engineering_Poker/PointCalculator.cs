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
            cards[0] = card1; // zou vervangen worden door array die gevuld werd in ComputerAIModel met gedeelde kaarten
            cards[1] = card2;
            cards[2] = card3;
            cards[3] = card4;
            cards[4] = card5;
            cards[5] = card6;
            cards[6] = card7; //
            cardTypes = getCardTypes(cards);
            cardsChecked = 0;
            cardNumbers = getCardNumber(cards);
            cardsChecked = 0;
            Console.WriteLine(royalFlush());
            if (royalFlush()) {  return 110; }
            else if (fourOfAKind()) { return 110; }
            else if (flush()) { return 90; }
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

        bool checkFor5SequentialCards()
        {
            int[] straight = cardNumbers;
            Array.Sort(straight);
            int[] sequentialCards = new int[5];

            if(straight[0] + 1 == straight[1] && straight[1] + 1 == straight[2] && straight[2] + 1 == straight[3] && straight[3] + 1 == straight[4]||
               straight[1] + 1 == straight[2] && straight[2] + 1 == straight[3] && straight[3] + 1 == straight[4] && straight[4] + 1 == straight[5]||
               straight[2] + 1 == straight[3] && straight[3] + 1 == straight[4] && straight[4] + 1 == straight[5] && straight[5] + 1 == straight[6])
            {
                return true;
            }
            return false;
        }

        private bool royalFlush()
        {
            var result = cardTypes.GroupBy(i => i)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1)
                .ToList();

            foreach (var pair in result)
            {
                if (pair.Count >= 5)
                {

                    if (checkFor5SequentialCards())
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;

                }
            }
            return false;

        }

        private bool fourOfAKind()
        {
            var result = cardNumbers.GroupBy(i => i)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(x => x.Count > 1)
                .ToList();

            foreach (var pair in result)
            {
                if (pair.Count == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
                return false;
        }

        private bool flush()
        {
            var result = cardTypes.GroupBy(i => i)
.Select(g => new { Value = g.Key, Count = g.Count() })
.Where(x => x.Count > 1)
.ToList();

            foreach (var pair in result)
            {
                if (pair.Count == 4)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            return false;
        }
        private bool fullHouse()
        {
            
            var result = cardNumbers.GroupBy(i => i)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .Where(x => x.Count > 1)
            .ToList();

            bool isDouble = false;
            bool isTriple = false;
            foreach (var pair in result)
            {
                if(pair.Count == 3)
                {
                    isTriple = true;
                }
                else if (pair.Count == 2)
                {
                    isDouble = true;
                }

                else
                {
                    return false;
                }

                if (isDouble && isTriple)
                {
                    return true;
                }
            }

            
            return false;

        }

        private bool straight()
        {
            return checkFor5SequentialCards();
            

        }

        private bool threeOfAKind()
        {
            var result = cardNumbers.GroupBy(i => i)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .Where(x => x.Count > 1)
            .ToList();

            foreach (var pair in result)
            {
                if (pair.Count == 3)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            return false;
        }

        private bool twoPair()
        {
            var result = cardNumbers.GroupBy(i => i)
.Select(g => new { Value = g.Key, Count = g.Count() })
.Where(x => x.Count > 1)
.ToList();

            bool[] doubles = new bool[2];
            int j = 0;
            foreach (var pair in result)
            {
                if (pair.Count == 2)
                {
                    doubles[j] = true;
                    j++;
                }

                else
                {
                    return false;
                }

                if(doubles[0] && doubles[1])
                {
                    j = 0;
                    return true;
                }

            }

            return false;

        }

        private bool pair()
        {
            var result = cardNumbers.GroupBy(i => i)
.Select(g => new { Value = g.Key, Count = g.Count() })
.Where(x => x.Count > 1)
.ToList();

            foreach (var pair in result)
            {
                if (pair.Count == 2)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
