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
        private List<CardObject> firstThreeCards = new List<CardObject> { };
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
            
            firstThreeCards.Add(deck[0]);            
            firstThreeCards.Add(deck[1]);            
            firstThreeCards.Add(deck[2]);
           
            deck.RemoveAt(0);
            deck.RemoveAt(0);
            deck.RemoveAt(0);
            isShuffled = true;

            return firstThreeCards;       
        }

        public List<CardObject> DealPlayerHand(List<CardObject> deck)
        {
            shuffledDeck(deck);
            List<CardObject> playerHand = new List<CardObject> { };

            playerHand.Add(deck[0]);            
            playerHand.Add(deck[1]);
            deck.RemoveAt(0);
            deck.RemoveAt(0);
            isShuffled = true;

            return playerHand;
        }

        public List<CardObject> DealNextCard(List<CardObject> deck)
        {
            shuffledDeck(deck);
            
            firstThreeCards.Add(deck[0]);            
            deck.RemoveAt(0);            
            isShuffled = true;

            return firstThreeCards;
        }


    }    
}
