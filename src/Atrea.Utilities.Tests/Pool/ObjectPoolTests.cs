using System;
using Atrea.Utilities.Pool;
using FluentAssertions;
using NUnit.Framework;

namespace Atrea.Utilities.Tests.Pool
{
    [TestFixture]
    public class ObjectPoolTests
    {
        private class Foo
        {
            public int Bar { get; set; }
        }

        [Test]
        public void Get_Creates_New_Object_When_Pool_Is_Empty()
        {
            var objectPool = new ObjectPool<Foo>(() => new Foo());

            var result = objectPool.Get();

            result.Should().BeOfType<Foo>();
        }

        [Test]
        public void Get_Reuses_Object_In_The_Pool()
        {
            var objectPool = new ObjectPool<Foo>(() => new Foo());

            var foo = new Foo {Bar = 10};

            objectPool.Put(foo);

            var reusedFoo = objectPool.Get();

            reusedFoo.Bar.Should().Be(foo.Bar);

            var newFoo = objectPool.Get();

            newFoo.Should().NotBeEquivalentTo(reusedFoo);
        }

        [Test]
        public void Null_Object_Generator_Function_Results_In_ArgumentNullException()
        {
            Func<ObjectPool<Foo>> act = () =>
            {
                var objectPool = new ObjectPool<Foo>(null);

                return objectPool;
            };

            act.Should().Throw<ArgumentNullException>();
        }
    }
}