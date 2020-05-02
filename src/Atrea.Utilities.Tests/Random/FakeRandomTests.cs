using Atrea.Utilities.Random;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Utilities.Tests.Random
{
    [TestFixture]
    public class FakeRandomTests
    {
        private static readonly double[] Values = { 5, 4, 6, 3, 7, 2, 8, 1, 9, 0 };

        [Test]
        public void Next_Generates_Random_Numbers_In_Expected_Order()
        {
            var random = new FakeRandom(Values);

            foreach (var value in Values)
            {
                var nextRandomValue = random.Next();

                nextRandomValue.Should().Be((int) value);
            }
        }

        [Test]
        public void Next_Using_All_Values_Loops_Values_To_Beginning()
        {
            var random = new FakeRandom(Values);

            foreach (var value in Values)
            {
                var nextRandomValue = random.Next();

                nextRandomValue.Should().Be((int) value);
            }

            // ensure that values are used again, in the same order.
            foreach (var value in Values)
            {
                var nextRandomValue = random.Next();

                nextRandomValue.Should().Be((int) value);
            }
        }

        [Test]
        public void Next_With_Max_Generates_Random_Numbers_In_Expected_Order()
        {
            var random = new FakeRandom(Values);

            foreach (var value in Values)
            {
                var nextRandomValue = random.Next(10);

                nextRandomValue.Should().Be((int) value);
            }
        }

        [Test]
        public void Next_With_Range_Generates_Random_Numbers_In_Expected_Order()
        {
            var random = new FakeRandom(Values);

            foreach (var value in Values)
            {
                var nextRandomValue = random.Next(10, 100);

                nextRandomValue.Should().Be((int) value);
            }
        }

        [Test]
        public void NextDouble_Generates_Random_Numbers_In_Expected_Order()
        {
            var random = new FakeRandom(Values);

            foreach (var value in Values)
            {
                var nextRandomValue = random.NextDouble();

                nextRandomValue.Should().Be(value);
            }
        }
    }
}