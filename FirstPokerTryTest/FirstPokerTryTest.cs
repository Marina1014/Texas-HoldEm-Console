using FirstPokerTry.Logics.Gameplay;
using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;
using FirstPokerTry.Data;

namespace FirstPokerTryTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SouldCheckIfStraightFlush()
    {
        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Queen, rank = 11},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.King, rank = 12}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Queen, rank = 11 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.King, rank = 12 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkIfRoyalFlushExits(hand1);

        var handChecker2 = new HandChecker();
        bool expected2 = handChecker2.checkIfRoyalFlushExits(hand2);

        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }
    
    [Test]
    public void ShouldCheckIfStraightFlush()
    {

        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 6 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfStraightFlushExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkIfStraightFlushExists(hand1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result1, Is.EqualTo(expected1));
        });
    }

    [Test]
    public void ShouldCheckIfFourOfAKind()
    {

        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 3}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkifFourOfAKindExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkifFourOfAKindExists(hand1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result1, Is.EqualTo(expected1));
        });
    }

    [Test]
    public void ShouldCheckIfFullHouse()
    {

        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 3}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfFullHouseExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkIfFullHouseExists(hand1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result1, Is.EqualTo(expected1));
        });
    }

    [Test]
    public void ShouldCheckIfFlush()
    {

        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 6},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfFlushExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkIfFlushExists(hand1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result1, Is.EqualTo(expected1));
        });
    }


    [Test]
    public void ShouldCheckIfStraight()
    {

        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
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

    [Test]
    public void ShouldCheckIfPairExists()
    {
        List<CardObject> hand = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 5 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 10}
        };

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 2 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 10}
        };

        bool result = false;
        bool result1 = true;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfPairExists(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker.checkIfPairExists(hand1);

        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result1, Is.EqualTo(expected1));

    }
}
