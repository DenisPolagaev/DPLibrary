using NUnit.Framework;

namespace DPLibraryTest.DPCore.System.DateTime
{
    [TestFixture]
    public class DateTimeTest
    {
        [Test]
        public void IsDateEqual()
        {
            var firstDateTime = new global::System.DateTime(2021, 10, 8, 10, 10, 10);
            var secondDateTime = new global::System.DateTime(2021, 10, 8, 10, 10, 10);
            Assert.AreEqual(true,firstDateTime.IsDateEqual(secondDateTime));
            
        }
    }
}