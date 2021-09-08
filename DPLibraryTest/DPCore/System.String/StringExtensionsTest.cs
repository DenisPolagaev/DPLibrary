using System.Linq;
using System.Security;
using NUnit.Framework;

namespace DPLibraryTest.DPCore.System.String
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        public void ToNumber()
        {
            string number = "0";
            Assert.DoesNotThrow(() =>
            {
                double d = number.ToDouble();
                int i = number.ToInt32();
                byte b = number.ToByte();
            });
        }

        [Test]
        public void ToBoolean()
        {
            string boolean = "true";
            Assert.DoesNotThrow(() =>
            {
                bool b = boolean.ToBoolean();
            });
        }

        [Test]
        public void ToChar()
        {
            string ch = "r";
            Assert.DoesNotThrow(() =>
            {
                char character = ch.ToChar();
            });
        }
        [Test]
        public void ToDateTime()
        {
            string dateTime = "2020/12/15 11:12:12";
            Assert.DoesNotThrow(() =>
            {
                var dt = dateTime.ToDateTime();
            });
        }

        [Test]
        public void IfNotEmpty()
        {
            string str = global::System.String.Empty;
            Assert.AreEqual("дом", str.IfNotEmpty("дом"));
        }

        [Test]
        public void IsEmpty()
        {
            string str = global::System.String.Empty;
            Assert.IsTrue(str.IsEmpty());
        }

        [Test]
        public void IsNotEmpty()
        {
            string str = global::System.String.Empty;
            var result = str.IsNotEmpty();
            Assert.IsFalse(result);
        }

        [Test]
        public void ToSecureString()
        {
            SecureString secureString = new SecureString();
            var password = "passsword";

            password.ToArray().ForEach((c) => secureString.AppendChar(c));
            var securePassword = password.ToSecuredString();
            
            Assert.AreEqual(secureString.ToUnsecuredString(), securePassword.ToUnsecuredString());
        }
    }
}