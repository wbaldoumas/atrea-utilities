using System;
using Atrea.Utilities.Random;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Utilities.Tests.Random
{
    [TestFixture]
    public class CryptoRandomTests
    {
        [Test]
        public void Next_Generates_Random_Number_Within_Range()
        {
            // arrange
            var cryptoRandom = new CryptoRandom();

            // act
            var result = cryptoRandom.Next();

            // assert
            result.Should().BeInRange(0, int.MaxValue);
        }

        [Test]
        public void Next_With_Max_Generates_Random_Number_Within_Range()
        {
            // arrange
            const int max = 10;
            var cryptoRandom = new CryptoRandom();

            // act
            var result = cryptoRandom.Next(max);

            // assert
            result.Should().BeInRange(0, max);
        }

        [Test]
        public void Next_With_Max_Below_Zero_Generates_Exception()
        {
            // act
            const int max = -1;
            var cryptoRandom = new CryptoRandom();

            // act
            Func<int> act = () =>
            {
                var next = cryptoRandom.Next(max);

                return next;
            };

            // assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Next_With_Range_Generates_Random_Number_Within_Range()
        {
            // arrange
            const int min = 5;
            const int max = 10;
            
            var cryptoRandom = new CryptoRandom();

            // act
            var result = cryptoRandom.Next(min, max);


            result.Should().BeInRange(min, max);
        }

        [Test]
        public void Next_With_MinValue_Equal_To_MaxValue_Returns_MinValue()
        {
            // arrange
            const int min = 5;
            const int max = 5;
            const int expectedValue = 5;

            var cryptoRandom = new CryptoRandom();

            // act
            var result = cryptoRandom.Next(min, max);


            result.Should().Be(expectedValue);
        }

        [Test]
        public void Next_With_Bad_MinValue_Generates_Exception()
        {
            // arrange
            const int min = -1;
            const int max = 10;

            var cryptoRandom = new CryptoRandom();

            // act
            Func<int> act = () =>
            {
                var next = cryptoRandom.Next(min, max);

                return next;
            };

            // assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Next_With_MinValue_Greater_Than_MaxValue_Generates_Exception()
        {
            // arrange
            const int min = 11;
            const int max = 10;

            var cryptoRandom = new CryptoRandom();

            // act
            Func<int> act = () =>
            {
                var next = cryptoRandom.Next(min, max);

                return next;
            };

            // assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Next_With_MaxValue_Less_Than_Zero_Generates_Exception()
        {
            // arrange
            const int min = -10;
            const int max = -1;

            var cryptoRandom = new CryptoRandom();

            // act
            Func<int> act = () =>
            {
                var next = cryptoRandom.Next(min, max);

                return next;
            };

            // assert
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void NextDouble_Generates_Random_Number_Within_Range()
        {
            // arrange
            var cryptoRandom = new CryptoRandom();

            // act
            var result = cryptoRandom.NextDouble();

            // assert
            result.Should().BeInRange(0.0, 1.0);
        }

        [Test]
        public void NextBytes_Generates_Random_Bytes_Within_Range()
        {
            // arrange
            var cryptoRandom = new CryptoRandom();

            var bytes = new byte[10];

            // act
            cryptoRandom.NextBytes(bytes);

            // assert
            foreach (var randomByte in bytes)
            {
                randomByte.Should().BeInRange(0, 255);
            }
        }

        [Test]
        public void NextBytes_With_Null_Buffer_Generates_Exception()
        {
            var cryptoRandom = new CryptoRandom();

            Action act = () => cryptoRandom.NextBytes(null);

            act.Should().Throw<ArgumentNullException>();
        }
    }
}