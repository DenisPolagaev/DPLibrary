using System;
using NUnit.Framework;

namespace DPLibraryTest.DPCore.System.Object
{
    [TestFixture]
    public class ObjectExtensionsTest
    {
        [Test]
        public void As()
        {
            Assert.DoesNotThrow(() =>
            { 
                var obj = "afagaggag";
                var str = obj.As<string>();
            });
            Assert.Throws<InvalidCastException>(() =>
            { 
                var obj = "afagaggag";
                var str = obj.As<int>();
            });
        }

        [Test]
        public void IsNull()
        {
            object s = null;
            Assert.AreEqual(true, s.IsNull());
        }
        
        [Test]
        public void IsNotNull()
        {
            object s = "";
            Assert.AreEqual(true, s.IsNotNull());
        }
        
        [Test]
        public void ReferenceEquals()
        {
            string a = "";
            var b = a;
            Assert.True(a.RefEquals(b));
        }
    }
}