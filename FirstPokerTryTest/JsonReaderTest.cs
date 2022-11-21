using FirstPokerTry.Logics.Gameplay;
using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FirstPokerTry.Logics.Objects;
using FirstPokerTry.Data;
using FirstPokerTry.Data.Json;

namespace FirstPokerTryTest
{
	public class JsonReaderTest
	{
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnCardDeck()
        {
            var cardDeck = JsonCardDeckFileReader.GetJsonCardDeck();
                      
            int result = 52;

            Assert.That(result, Is.EqualTo(cardDeck.Count));

        }
    }
}

