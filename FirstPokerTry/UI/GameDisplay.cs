using System;
using DryIoc.ImTools;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.UI
{
    public class GameDisplay
    {

        public int Pot { get; set; }
        public List<CardObject> cardsOnTable { get; set; }
        private int _playerNumber;

        public int Player1Pot { get; set; }
        public int Player1Bet { get; set; }

        public int Player2Pot { get; set; }
        public int Player2Bet { get; set; }

        public GameDisplay(int pot, int player1Pot, int player1Bet, int player2Pot, int player2Bet)
        {
            Pot = pot;
            Player1Pot = player1Pot;
            Player1Bet = player1Bet;
            Player2Pot = player2Pot;
            Player2Bet = player2Bet;
        }

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
            Console.WriteLine("");
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

        public void PrintCardsOnTable()
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
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumber + "'s turn.");
            Console.WriteLine("Press B to bet, press any key to fold.");

            var input = Console.ReadKey();

            while (true)
            {
                if (input.Key == ConsoleKey.B)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void PrintBetMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("How much would you like to bet?");
            Console.WriteLine("Press 1 to bet 10, 2 to bet 20, 3 to bet 30, 4 to bet 40, 5 to bet 50,");
            Console.WriteLine("6 to bet 60, 7 to bet 70, 8 to bet 80, 9 to bet 90, or 0 to bet 100.");
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

        public int ValidateBetBasedOnPot(int bet, int playerPot, int playerNumber)
        {
            if (playerNumber == 1)
            {
                if (bet > playerPot)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You don't have enough money to bet that much.");
                    Console.WriteLine("");
                    return 0;
                }
                else
                {
                    return bet;
                }
            }

            if (playerNumber == 2)
            {
                if (bet > playerPot)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You don't have enough money to bet that much.");
                    Console.WriteLine("");
                    return 0;
                }
                else
                {
                    return bet;
                }
            }
            else return 0;
        }

        public int ValidateBetBasedOnMinimum(int bet, int otherBet, int playerNumber)
        {
            if (playerNumber == 1)
            {
                if (bet < otherBet)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You must bet at least as much as the other player.");
                    Console.WriteLine("");
                    PrintBetMenu();
                    return ValidateBetBasedOnMinimum(ReadBetInput(), otherBet, playerNumber);
                }
                else
                {
                    return bet;
                }
            }
            else if (playerNumber == 2)
            {
                if (bet < otherBet)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You must bet at least as much as the other player.");
                    Console.WriteLine("");
                    PrintBetMenu();
                    return ValidateBetBasedOnMinimum(ReadBetInput(), otherBet, playerNumber);
                }
                else
                {
                    return bet;
                }
            }
            else
            {
                return 0;
            }
        }

        public void PrintPlayerFolded(int playerNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumber + " has folded.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
  
        public void PrintPlayersBet(int playerNumber, int bet)
        {
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumber + " has bet " + bet);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void PrintPotStatus(int pot, int player1Pot, int player2Pot)
        {
            Console.WriteLine("");
            Console.WriteLine("Pot: " + pot);
            Console.WriteLine("Player 1 Pot: " + player1Pot);
            Console.WriteLine("Player 2 Pot: " + player2Pot);
        }

        public void PrintWinner(int playerNumber, int pot)
        {
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumber + " has won the round!");
            Console.WriteLine("The whole pot of " + pot + " is yours!");
            Console.WriteLine("Press any key to start a new round.");
            Console.ReadKey();
            Console.Clear();
        }

        public void PrintUltimateWinner(int playerNumer, int pot)
        {
            Console.WriteLine("");
            Console.WriteLine("Player " + playerNumer + " Has won Texas Hold'em Poker!");
            Console.WriteLine("Congratulations on your win of " + pot);
            Console.WriteLine("Press any key to exit game");
            Console.ReadKey();
        }
    }
}