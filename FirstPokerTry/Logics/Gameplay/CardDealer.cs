//using ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPokerTry.Data;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.Logics.Gameplay
{
    public class CardDealer
    {
        private bool isShuffled = false;
        private List<CardObject> cardsOnTable = new List<CardObject> { };        
        private List<CardObject> cardsPlayer1 = new List<CardObject> { };
        private List<CardObject> cardsPlayer2 = new List<CardObject> { };


        private List<CardObject> shuffledDeck(List<CardObject> deck)
        {
            var shuffledDeck = new DeckShuffle();
           
            if (!isShuffled)
            {
                shuffledDeck.CardList(deck);
            }

            return deck;
        }

        public List<CardObject> DealFirstThreeCards(List<CardObject> deck)
        {

            shuffledDeck(deck);
            
            cardsOnTable.Add(deck[0]);            
            cardsOnTable.Add(deck[1]);            
            cardsOnTable.Add(deck[2]);
           
            deck.RemoveAt(0);
            deck.RemoveAt(0);
            deck.RemoveAt(0);
            isShuffled = true;

            cardsPlayer1.Add(cardsOnTable[0]);
            cardsPlayer1.Add(cardsOnTable[1]);
            cardsPlayer1.Add(cardsOnTable[2]);
            cardsPlayer2.Add(cardsOnTable[0]);
            cardsPlayer2.Add(cardsOnTable[1]);
            cardsPlayer2.Add(cardsOnTable[2]);

            return cardsOnTable;       
        }

        public List<CardObject> DealPlayer1Hand(List<CardObject> deck)
        {
            shuffledDeck(deck);
            
            cardsPlayer1.Add(deck[0]);            
            cardsPlayer1.Add(deck[1]);
            deck.RemoveAt(0);
            deck.RemoveAt(0);

            isShuffled = true;

            return cardsPlayer1;
        }

        public List<CardObject> DealPlayer2Hand(List<CardObject> deck)
        {
            shuffledDeck(deck);

            cardsPlayer2.Add(deck[0]);
            cardsPlayer2.Add(deck[1]);
            deck.RemoveAt(0);
            deck.RemoveAt(0);

            isShuffled = true;

            return cardsPlayer2;
        }

        public List<CardObject> DealNextCard(List<CardObject> deck)
        {
            shuffledDeck(deck);
            
            cardsOnTable.Add(deck[0]);            
            deck.RemoveAt(0);            
            isShuffled = true;

            cardsPlayer1.Add(cardsOnTable[cardsOnTable.Count - 1]);
            cardsPlayer2.Add(cardsOnTable[cardsOnTable.Count - 1]);

            return cardsOnTable;
        }

        public List<CardObject> getCardsPlayer1()
        {         
            return cardsPlayer1;
        }

        public List<CardObject> getCardsPlayer2()
        {       
            return cardsPlayer2;
        }
    }    
}
