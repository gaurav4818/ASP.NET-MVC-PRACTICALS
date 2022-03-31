using NUnit.Framework;
using Practical8.Models;

namespace Practical_8.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var s = new Helloworldtest();
            Assert.That(s.hello(), Is.EqualTo("Hello World"));
        }
    }
}