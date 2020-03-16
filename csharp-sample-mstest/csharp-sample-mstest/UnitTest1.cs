using csharp_sample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp_sample_mstest.csproj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testadd()
        {
            var obj = new Class1();
            Assert.AreEqual(8, obj.add(5, 3));
        }
        [TestMethod]
        public void Testsub()
        {
            var obj = new Class1();
            Assert.AreEqual(2, obj.sub(5, 3));
        }
    }
}
