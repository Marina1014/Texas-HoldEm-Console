using FirstPokerTry.Data;
using FirstPokerTry.Logics.CardFactory.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FirstPokerTry
{
    class Program
    {

        // Main Method
        public static void Main(String[] args)
        {
            var cardDeck = JsonFileReader.GetJsonData();
            Debug.WriteLine(cardDeck);
        }
    }
}