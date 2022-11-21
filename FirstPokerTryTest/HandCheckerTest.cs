using FirstPokerTry.Logics.Gameplay;
using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;
using FirstPokerTry.Data;

namespace FirstPokerTryTest;

public class HandCheckerTest
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

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfRoyalFlushExits(hand1);
        bool expected2 = handChecker.checkIfRoyalFlushExits(hand2);

        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }
    
    [Test]
    public void ShouldCheckIfStraightFlush()
    {

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 6 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfStraightFlushExists(hand1);
        bool expected2 = handChecker.checkIfStraightFlushExists(hand2);
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }

    [Test]
    public void ShouldCheckIfFourOfAKind()
    {

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkifFourOfAKindExists(hand1);
        bool expected2 = handChecker.checkifFourOfAKindExists(hand2);
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }

    [Test]
    public void ShouldCheckIfFullHouse()
    {

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 3}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfFullHouseExists(hand1);
        bool expected2 = handChecker.checkIfFullHouseExists(hand2);
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }

    [Test]
    public void ShouldCheckIfFlush()
    {

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Seven, rank = 6},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 3},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfFlushExists(hand1);
        bool expected2 = handChecker.checkIfFlushExists(hand2);
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }


    [Test]
    public void ShouldCheckIfStraight()
    {

        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Nine, rank = 8 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13}
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfStraighExists(hand1);
        bool expected2 = handChecker.checkIfStraighExists(hand2);
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }

    [Test]
    public void ShoudlCheckIfThreeOfAKindExists()
    {
        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4},
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 }
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkifThreeOfAKindExists(hand1);
        bool expected2 = handChecker.checkifThreeOfAKindExists(hand2);

        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }


    [Test]
    public void ShouldCheckIfTwoPairExists()
    {
        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 }
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 }
        };

        bool result1 = true;
        bool result2 = false;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfTwoPairsExists(hand1);
        bool expected2 = handChecker.checkIfTwoPairsExists(hand2);

        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });

    }

    [Test]
    public void ShouldCheckIfPairExists()
    {
        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10}
        };

        bool result1 = false;
        bool result2 = true;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfPairExists(hand1);
        bool expected2 = handChecker.checkIfPairExists(hand2);
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });
    }

    [Test]
    public void ShouldCheckIfHighestRank()
    {
        List<CardObject> hand1 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Six, rank = 5 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Two, rank = 1 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Eight, rank = 7 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10}
        };

        List<CardObject> hand2 = new()
        {
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ten, rank = 9 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Three, rank = 2 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Clubs, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Five, rank = 4 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Ace, rank = 13 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Spades, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Diamonds, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Four, rank = 3 },
            new CardObject { Suit = FirstPokerTry.Logics.CardFactory.Enumerations.SuitEnum.Hearts, Value = FirstPokerTry.Logics.CardFactory.Enumerations.ValueEnum.Jack, rank = 10}
        };

        bool result1 = false;
        bool result2 = true;

        var handChecker = new HandChecker();
        bool expected1 = handChecker.checkIfHighestValue(hand1);
        bool expected2 = handChecker.checkIfHighestValue(hand2);

        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        });

    }
}
