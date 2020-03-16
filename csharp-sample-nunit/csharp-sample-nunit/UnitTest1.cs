using csharp_sample;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testadd()
        {
            var obj = new Class1();
            Assert.AreEqual(8, obj.add(5, 3));
        }
        [Test]
        public void Testsub()
        {
            var obj = new Class1();
            Assert.AreEqual(2, obj.sub(5, 3));
        }
    }
}