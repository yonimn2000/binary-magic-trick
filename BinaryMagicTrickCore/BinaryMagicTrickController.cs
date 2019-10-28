using System;
using System.Collections.Generic;

namespace YonatnanMankovich.BinaryMagicTrickCore
{
    public class BinaryMagicTrickController
    {
        public int LowerBound { get; private set; }
        public int UpperBound { get; private set; }
        public int TheGuessedNumber { get; private set; } = 0;
        public int NumberOfCards { get; private set; }
        public int CurrentCardNumber { get; private set; } = 0;

        public BinaryMagicTrickController(int lowerBound, int upperBound)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
            NumberOfCards = (int)Math.Ceiling(Math.Log(upperBound + 1, 2));
        }

        public List<int> GetNextCardMembers()
        {
            if (CurrentCardNumber < NumberOfCards)
            {
                List<int> cardMembers = new List<int>((UpperBound - LowerBound) / 2);
                int firstNumberOnCard = (int)Math.Pow(2, CurrentCardNumber); // AKA 2^CurrentCardNumber
                int printedNumber = firstNumberOnCard;
                while (printedNumber <= UpperBound)
                {
                    for (int i = 0; i < firstNumberOnCard && printedNumber <= UpperBound; i++)
                    {
                        cardMembers.Add(printedNumber);
                        printedNumber++;
                    }
                    printedNumber += firstNumberOnCard;
                }
                CurrentCardNumber++;
                return cardMembers;
            }
            return null;
        }

        public void CardHasNumber()
        {
            TheGuessedNumber += (int)Math.Pow(2, CurrentCardNumber - 1);
        }
    }
}