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
}
