using Moq;
using NUnit.Framework;

namespace Ohce.Test
{
    public class GreeterTest
    {

        [Test]
        public void SaysGoodMorningWhenHourIs9()
        {
            var mockClock = new Mock<IClock>();
            mockClock.Setup(clock => clock.GetCurrentHour()).Returns(9);
            var greeter = new Greeter(mockClock.Object);

            string result = greeter.Greet();

            Assert.That(result, Is.EqualTo("Good morning"));

        }

        [Test]
        public void SaysGoodAfternoonWhenHourIs16()
        {
            var mockClock = new Mock<IClock>();
            mockClock.Setup(clock => clock.GetCurrentHour()).Returns(16);
            var greeter = new Greeter(mockClock.Object);

            string result = greeter.Greet();

            Assert.That(result, Is.EqualTo("Good afternoon"));
        }

        [Test]
        public void SaysGoodNightWhenHourIs0()
        {
            var mockClock = new Mock<IClock>();
            mockClock.Setup(clock => clock.GetCurrentHour()).Returns(0);
            var greeter = new Greeter(mockClock.Object);

            string result = greeter.Greet();

            Assert.That(result, Is.EqualTo("Good night"));
        }
    }
}