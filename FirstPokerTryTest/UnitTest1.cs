using FirstPokerTry.Logics.Gameplay;

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
        int[] hand = new int[] { 3, 1, 9, 4, 5 };
        int result = 9;
        var handChecker = new HandChecker();
        handChecker.FindHighestValue(hand);

        Assert.That(result, Is.EqualTo(handChecker));
    }
    [SetUp]
    public void Setup1()
    {
    }

    [Test]
    public void shouldShuffleDeck()
    {
        int[] hand = new int[] { 1, 2, 3, 4, 5 };
        int result != int[] { 1, 2, 3, 4, 5};
        var handChecker = new HandChecker();
        handChecker.FindHighestValue(hand);

        Assert.That(result, Is.EqualTo(handChecker));
    }
}
