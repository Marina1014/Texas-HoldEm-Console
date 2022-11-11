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
        List<CardObject> hand = new List<CardObject>
        {
            new CardObject() {}
        }
    }

    [Test]
    public void ShouldCheckIfStraight()
    {
        int[] hand = new int[] { 3, 6, 2, 4, 5 };
        int[] hand1 = new int[] { 7, 1, 9, 4, 5, 3 };

        bool result = true;
        bool result1 = false;

        var handChecker = new HandChecker();
        bool expected = handChecker.checkIfStraight(hand);

        var handChecker1 = new HandChecker();
        bool expected1 = handChecker1.checkIfStraight(hand1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result1, Is.EqualTo(expected1));
        });
    }
}
