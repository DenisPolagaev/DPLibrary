using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DPLibraryTest.DPCollections.System.Collections.Generic
{
    [TestFixture]
    public class IDictionaryExtensionsTest
    {
        [Test]
        public void AddOrUpdate()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.AddOrUpdate("Fizz", 1); // return 1;
            
            var value1 = dictionary.AddOrUpdate("Fizz", 2);
            Assert.AreEqual(2, value1);
        }

        [Test]
        public void GetOrUpdate()
        {
            var dictionary = new Dictionary<string, int>();
            var value1 = dictionary.GetOrAdd("Fizz", 1); // return 1;
            var value2 = dictionary.GetOrAdd("Fizz", 0); // return 1; // словарь уже содержит такой ключ

            var value3 = dictionary.GetOrAdd("Fizz1", (n) => 1);
            Assert.AreEqual(1, value1);
            Assert.AreEqual(1, value2);
            Assert.AreEqual(1, value3);
        }

        [Test]
        public void ContainsAllKey()
        {
            var dictionary = new Dictionary<string, int> {{"a", 1}, {"b", 2}, {"c", 3}};

            var result = dictionary.ContainsAll(
                new KeyValuePair<string, int>("a", 1),
                new KeyValuePair<string, int>("b", 2));
            
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ContainsAnyKey()
        {
            var dictionary = new Dictionary<string, int> {{"a", 1}, {"b", 2}, {"c", 3}};

            var result = dictionary.ContainsAny(
                new KeyValuePair<string, int>("a", 1),
                new KeyValuePair<string, int>("c", 2),
                new KeyValuePair<string, int>("c", 2)
                );
            Assert.AreEqual(true, result);
        }

        [Test]
        public void RemoveIfContainsKey()
        {
            var dictionary = new Dictionary<string, int> {{"a", 1}, {"b", 2}, {"c", 3}};
            
            dictionary.RemoveIfContainsKey("a");
            var itemCount = dictionary.Keys.Count;
            Assert.AreEqual(2, itemCount);
        }

        [Test]
        public void ToSorterDictionary()
        {
            var dictionary = new Dictionary<string, int> {{"b", 2},{"a", 1}, {"c", 3}};
            
            SortedDictionary<string, int> result = dictionary.ToSortedDictionary();

            Assert.AreEqual(1, result.First().Value);
        }
    }
}