using System.Collections.Generic;
using Atrea.Utilities.Enums;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Utilities.Tests.Enums
{
    public enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public enum Friends { }

    [TestFixture]
    public class EnumUtilsTests
    {
        [Test]
        public void AsEnumerable_Generates_Expected_Enumerable_With_NonEmpty_Enum()
        {
            var expectedEnumerable = new[]
            {
                Weekday.Monday,
                Weekday.Tuesday,
                Weekday.Wednesday,
                Weekday.Thursday,
                Weekday.Friday
            };

            var enumerable = EnumUtils<Weekday>.AsEnumerable();

            enumerable.Should().BeEquivalentTo(expectedEnumerable);
        }

        [Test]
        public void AsEnumerable_Generates_Expected_Enumerable_With_Empty_Enum()
        {
            var enumerable = EnumUtils<Friends>.AsEnumerable();

            enumerable.Should().BeEmpty();
        }

        [Test]
        public void AsDictionary_Generates_Expected_Dictionary_With_NonEmpty_Enum()
        {
            var expectedDictionary = new Dictionary<int, string>
            {
                {0, "Monday"},
                {1, "Tuesday"},
                {2, "Wednesday"},
                {3, "Thursday"},
                {4, "Friday"}
            };

            var dictionary = EnumUtils<Weekday>.AsDictionary();

            dictionary.Should().BeEquivalentTo(expectedDictionary);
        }

        [Test]
        public void AsDictionary_Generates_Expected_Dictionary_With_Empty_Enum()
        {
            var dictionary = EnumUtils<Friends>.AsDictionary();

            dictionary.Should().BeEmpty();
        }
    }
}