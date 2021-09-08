using NUnit.Framework;

namespace DPLibraryTest.DPCore.System.Boolean
{
    [TestFixture]
    public class BooleanExtensionsTest
    {
        [Test]
        public void ExecuteFalse()
        {
            var fls = false;
            var result = false;
            fls.ExecuteIfFalse(()=>result = true);
            Assert.AreEqual(true, result);
        }
        
        [Test]
        public void ExecuteTrue()
        {
            var tr = true;
            var result = false;
            tr.ExecuteIfTrue(()=>result = true);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void SelectValue()
        {
            string result = string.Empty;
            var flag = true;
            result = flag.SelectValue("Дом", "Забор");
            Assert.AreEqual("Дом", result);
        }

        [Test]
        public void ToString()
        {
            var flag = true;
            string result = flag.ToString("Да","Нет");
            Assert.AreEqual("Да", result);
        }

        [Test]
        public void ToBinary()
        {
            var flag = true;
            Assert.AreEqual(1, flag.ToBinary());
        }
    }
}