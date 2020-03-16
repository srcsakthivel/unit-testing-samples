using csharp_sample;
using System;
using Xunit;

namespace csharp_sample_xunit
{
    public class UnitTest1
    {
        [Fact]
        public void Testadd()
        {
            var obj = new Class1();
            Assert.Equal(8, obj.add(5, 3));
        }
        [Fact]
        public void Testsub()
        {
            var obj = new Class1();
            Assert.Equal(2, obj.sub(5, 3));
        }
    }
}
