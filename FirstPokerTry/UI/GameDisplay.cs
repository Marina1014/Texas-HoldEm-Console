using System;
using DryIoc.ImTools;
using FirstPokerTry.Logics.Objects;
//using FirstPokerTry.Logics.CardFactory.Classes;
//using FirstPokerTry.Logics.Gameplay;

namespace FirstPokerTry.UI
{
    public class GameDisplay
    {

        private int _pot;
        private string _cardsOnTable;
        private int _playerNumber;

        private int _player1Pot;
        private int _player1Bet;
        private string _player1Hand;

        private int _player2Pot;
        private int _player2Bet;
        private string _player2Hand;

        public GameDisplay(int Pot, int Player1Pot, int Player1Bet, int Player2Pot, int Player2Bet)
        {
            _pot = Pot;
            _player1Pot = Player1Pot;
            _player1Bet = Player1Bet;
            _player2Pot = Player2Pot;
            _player2Bet = Player2Bet;
        }

        public void PrintInitialGameMenu()
        {
            Console.WriteLine("Welcome to Texas Hold'em Poker!");
            Console.WriteLine("The pot is currently at " + _pot);
            Console.WriteLine("Player 1 has " + _player1Pot);
            Console.WriteLine("Player 2 has " + _player2Pot);
            Console.WriteLine("Press any key to play a new game.");
            Console.ReadKey();
            Console.Clear();
        }

        public void PrintPlayerHand(int playerNumber, List<CardObject> playerHand)
        {
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumber + " has been dealt:");
            foreach (CardObject card in playerHand)
            {
                Console.WriteLine($"{card.Suit} {card.Value}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void PrintDealtCards(List<CardObject> player1Hand, List<CardObject> player2Hand)
        {
            Console.WriteLine("Dealing cards, look away player 2!");
            Console.WriteLine("Press any key when you're ready.");
            Console.ReadKey();
            PrintPlayerHand(1, player1Hand);
            Console.Clear();

            Console.WriteLine("Dealing cards, look away player 1!");
            Console.WriteLine("Press any key when your're ready.");
            Console.ReadKey();
            PrintPlayerHand(2, player2Hand);
            Console.Clear();
        }

        public void PrintCardsOnTable(List<CardObject> cardsOnTable)
        {
            Console.WriteLine("");
            Console.WriteLine("The cards on the table are:");
            foreach (CardObject card in cardsOnTable)
            {
                Console.WriteLine($"{card.Suit} {card.Value}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public bool PrintPlayersTurn(int playerNumber)
        {
            bool bet;
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumber + "'s turn.");
            Console.WriteLine("Would you like to bet (b) or fold (f)?");

            var input = Console.ReadKey();

            while (input.Key != ConsoleKey.B && input.Key != ConsoleKey.F)
            {
                Console.WriteLine("Please enter a valid input.");
            }

            while (true)
            {
                if (input.Key == ConsoleKey.B)
                {
                    return true;
                }
                else if (input.Key == ConsoleKey.F)
                {
                    return false;
                }
            }
        }

        public void PrintBetMenu()
        {
            Console.WriteLine("How much would you like to bet?");
            Console.WriteLine("Press 1 to bet 10, 2 to bet 20, 3 to bet 30, 4 to bet 40, 5 to bet 50,");
            Console.WriteLine("6 to bet 60, 7 to bet 70, 8 to bet 80, 9 to bet 90, or 0 to bet 100.");
            //ReadBetInput();
        }

        public int ReadBetInput()
        {
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    return 10;
                case ConsoleKey.D2:
                    return 20;
                case ConsoleKey.D3:
                    return 30;
                case ConsoleKey.D4:
                    return 40;
                case ConsoleKey.D5:
                    return 50;
                case ConsoleKey.D6:
                    return 60;
                case ConsoleKey.D7:
                    return 70;
                case ConsoleKey.D8:
                    return 80;
                case ConsoleKey.D9:
                    return 90;
                case ConsoleKey.D0:
                    return 100;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    return ReadBetInput();
            }
        }

        public void PrintPlayerFolded(int playerNumber)
        {
            Console.WriteLine("Player " + playerNumber + " has folded.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
  
        public void PrintPlayersBet(int playerNumber, int bet)
        {
            Console.WriteLine("Player " + playerNumber + " has bet " + bet);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void PrintPotStatus(int _pot, int _player1Pot, int _player2Pot)
        {
            Console.WriteLine("Pot: " + _pot);
            Console.WriteLine("Player 1 Pot: " + _player1Pot);
            Console.WriteLine("Player 2 Pot: " + _player2Pot);
        }

        public void PrintWinner(int playerNumber)
        {
            Console.WriteLine("Player " + playerNumber + " has won the game!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void PrintDraw()
        {
            Console.WriteLine("The game has ended in a draw!");
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}

