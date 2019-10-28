using System;
using System.Collections.Generic;

namespace YonatnanMankovich.BinaryMagicTrickCore
{
    public class BinaryMagicTrickController
    {
        public int Bound { get; private set; }
        public int TheGuessedNumber { get; private set; } = 0;
        public int NumberOfCards { get; private set; }
        public int CurrentCardNumber { get; private set; } = 0;

        public BinaryMagicTrickController(int bound)
        {
            Bound = bound;
            NumberOfCards = (int)Math.Ceiling(Math.Log(bound + 1, 2));
        }

        public List<int> GetNextCardMembers()
        {
            if (HasNextCard())
            {
                List<int> cardMembers = new List<int>(Bound / 2);
                int firstNumberOnCard = (int)Math.Pow(2, CurrentCardNumber); // AKA 2^CurrentCardNumber
                int printedNumber = firstNumberOnCard;
                while (printedNumber <= Bound)
                {
                    for (int i = 0; i < firstNumberOnCard && printedNumber <= Bound; i++)
                    {
                        cardMembers.Add(printedNumber);
                        printedNumber++;
                    }
                    printedNumber += firstNumberOnCard;
                }
                CurrentCardNumber++;
                return cardMembers;
            }
            throw new Exception("No more cards.");
        }

        public bool HasNextCard()
        {
            return CurrentCardNumber < NumberOfCards;
        }

        public void CardHasNumber()
        {
            TheGuessedNumber += (int)Math.Pow(2, CurrentCardNumber - 1);
        }
    }
}