using Atrea.Utilities.Random;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Utilities.Tests.Random
{
    [TestFixture]
    public class ThreadLocalRandomBuilderTests
    {
        [Test]
        public void Builder_Can_Build_CryptoRandom()
        {
            var threadLocalRandomBuilder = new ThreadLocalRandomBuilder();

            var random = threadLocalRandomBuilder.WithGeneratorValueFactory(() => new CryptoRandom()).Build();

            random.GetType().Should().Be<CryptoRandom>();
        }

        [Test]
        public void Builder_Can_Build_FakeRandom()
        {
            var threadLocalRandomBuilder = new ThreadLocalRandomBuilder();

            var random = threadLocalRandomBuilder.WithGeneratorValueFactory(() => new FakeRandom()).Build();

            random.GetType().Should().Be<FakeRandom>();
        }

        [Test]
        public void Builder_Can_Build_Random()
        {
            var threadLocalRandomBuilder = new ThreadLocalRandomBuilder();

            var random = threadLocalRandomBuilder.WithGeneratorValueFactory(() => new Utilities.Random.Random())
                .Build();

            random.GetType().Should().Be<Utilities.Random.Random>();
        }
    }
}