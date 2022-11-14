using FirstPokerTry.Logics.Gameplay;
using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTryTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnHighestValue()
    {
        
    }

    [Test]
    public void ShouldCheckIfPairExists()
    {
        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, _rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, _rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, _rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, _rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, _rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, _rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, _rank = 14}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, _rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, _rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, _rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, _rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, _rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, _rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, _rank = 14}
        };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfPairExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker.checkIfPairExists(hand1);

        Assert.That(result1, Is.EqualTo(expected1));

    }

    [Test]
    public void ShouldCheckIfStraight()
    {

        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, _rank = 6},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, _rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, _rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, _rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, _rank = 9},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, _rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, _rank = 2}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, _rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, _rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, _rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, _rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, _rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, _rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, _rank = 13}
        };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfStraighExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkIfStraighExists(hand1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result1, Is.EqualTo(expected1));
        });
    }
}