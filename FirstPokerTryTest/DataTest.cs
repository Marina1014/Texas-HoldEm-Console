using FirstPokerTry.Logics.Gameplay;
using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FirstPokerTry.Logics.Objects;
using FirstPokerTry.Data;

namespace FirstPokerTryTest;

public class DataTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnCardDeck()
    {
        var cardDeck = JsonFileReader.GetJsonData();

        int result = 52;

        Assert.That(result, Is.EqualTo(cardDeck.Count));

    }
}
