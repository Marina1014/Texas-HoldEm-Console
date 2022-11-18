using System;
using DryIoc.ImTools;
//using FirstPokerTry.Logics.CardFactory.Classes;
//using FirstPokerTry.Logics.Gameplay;

namespace FirstPokerTry.UI
{
    public class GameDisplay
    {

        public int Pot;
        public string CardsOnTable;
        public int PlayerNumber;

        public int Player1Pot;
        public int Player1Bet;
        public string Player1Hand;

        public int Player2Pot;
        public int Player2Bet;
        public string Player2Hand;


        public void PrintInitialGameMenu()
        {
            Console.WriteLine("Welcome to Texas Hold'em Poker!");
            Console.WriteLine("The pot is currently at " + Pot);
            Console.WriteLine("Player 1 has " + Player1Pot);
            Console.WriteLine("Player 2 has " + Player2Pot);
            Console.WriteLine("Press any key to play a new game.");
            Console.ReadKey();
            Console.Clear();
        }
        public void PrintDealtCards()
        {
            Console.WriteLine("Player 1 has been dealt " + Player1Hand);
            Console.WriteLine("Player 2 has been dealt " + Player2Hand);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public void PrintCardsOnTable()
        {
            Console.WriteLine("The cards on the table are " + CardsOnTable);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public void PrintPlayersTurn(int playerNumber)
        {
            Console.WriteLine("Player " + playerNumber + "'s turn.");
            Console.WriteLine("Would you like to bet (b) or fold (f)?");
            Console.ReadKey();

            if (Console.ReadKey().Key == ConsoleKey.B)
            {
                Console.Clear();
                PrintBetMenu();
            }
            else if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.WriteLine("Player " + playerNumber + " has folded.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine("Would you like to bet (b) or fold (f)?");
            }
        }
        public void PrintBetMenu()
        {
            Console.WriteLine("How much would you like to bet?");
            Console.WriteLine("Press 1 to bet 10, 2 to bet 20, 3 to bet 30, 4 to bet 40,");
            Console.WriteLine("5 to bet 50, 6 to bet 60, 7 to bet 70, 8 to bet 80, or 9 to bet 90.");
        }
        public int ReadBetInput()
        {
            int bet = 0;
            return Console.ReadKey().Key == ConsoleKey.D1 ? bet = 10 :
            Console.ReadKey().Key == ConsoleKey.D2 ? bet = 20 :
            Console.ReadKey().Key == ConsoleKey.D3 ? bet = 30 :
            Console.ReadKey().Key == ConsoleKey.D4 ? bet = 40 :
            Console.ReadKey().Key == ConsoleKey.D5 ? bet = 50 :
            Console.ReadKey().Key == ConsoleKey.D6 ? bet = 60 :
            Console.ReadKey().Key == ConsoleKey.D7 ? bet = 70 :
            Console.ReadKey().Key == ConsoleKey.D8 ? bet = 80 :
            Console.ReadKey().Key == ConsoleKey.D9 ? bet = 90 :
            bet = 0;
        }
        public void PrintPlayersBet(int playerNumber, int bet)
        {
            Console.WriteLine("Player " + playerNumber + " has bet " + bet);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public void PrintPotStatus()
        {
            Console.WriteLine("Pot: " + Pot);
            Console.WriteLine("Player 1 Pot: " + Player1Pot);
            Console.WriteLine("Player 2 Pot: " + Player2Pot);
        }
        public void PrintWinner(int playerNumber)
        {
            Console.WriteLine("Player " + playerNumber + " has won the game!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}

