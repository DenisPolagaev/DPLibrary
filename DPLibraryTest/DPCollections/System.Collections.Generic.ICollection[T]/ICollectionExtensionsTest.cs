using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DPLibraryTest.DPCollections.System.Collections.Generic
{
    [TestFixture]
    public class ICollectionExtensionsTest
    {
        [Test]
        public void AddRange()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");
            Assert.AreEqual(3, stringCollection.Count);
        }
        
        [Test]
        public void ContainsAllFalseResult()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.ContainsAll("Вася", "Петя", "Сюся");
            Assert.AreEqual(false, result);
        }
        
        [Test]
        public void ContainsAllTrueResult()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.ContainsAll("Вася", "Петя");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void ContainsAnyFalseResult()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.ContainsAny("Денис", "Серега", "Люда");
            Assert.AreEqual(false, result);
        }
        
        [Test]
        public void ContainsAnyTrueResultTest()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.ContainsAny("Вася", "Антон");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsEmptyCollection()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.IsEmpty();
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsNotEmptyCollection()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.IsNotEmpty();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsNotNullOrEmpty()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            var result = stringCollection.IsNotNullOrEmpty();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsNullOrEmpty()
        {
            ICollection<string> stringCollection = null;
            var result = stringCollection.IsNullOrEmpty();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void RemoveRange()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");

            stringCollection.RemoveRange("Петя");
            Assert.AreEqual(2, stringCollection.Count);
        }

        [Test]
        public void RemoveWhere()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");
            
            stringCollection.RemoveWhere((s)=>s.Equals("Вася"));
            Assert.AreEqual(2, stringCollection.Count);
        }
        
        [Test]
        public void RemoveWhereMethod()
        {
            ICollection<string> stringCollection = new List<string>();
            stringCollection.AddRange("Вася", "Петя", "Люся");
            
            stringCollection.RemoveWhere(IsVasia);
            Assert.AreEqual(2, stringCollection.Count);
        }

        private static bool IsVasia(string name)
        {
            return string.Equals(name, "Вася", StringComparison.Ordinal);
        }
    }
}