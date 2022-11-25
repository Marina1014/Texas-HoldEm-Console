using FirstPokerTry.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using FirstPokerTry.Logics.Gameplay;

namespace FirstPokerTry
{
    class Program
    {
        public static void Main(String[] args)
        {
            var game = new TheGame(0, 800, 0, 800, 0);
            game.PlayGame();

        }
    }
}