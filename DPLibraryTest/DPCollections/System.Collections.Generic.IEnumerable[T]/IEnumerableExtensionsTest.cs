using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;

namespace DPLibraryTest.DPCollections.System.Collections.Generic
{
    [TestFixture]
    public class IEnumerableExtensionsTest
    {
        [Test]
        public void ToObservableCollection()
        {
            IEnumerable<string> a = new List<string>();
            var c = new ObservableCollection<string>(a);
        }
        
        [Test]
        public void ContainsAllKey()
        {
            IEnumerable<string> dictionary = new List<string>();

            var result = dictionary.ContainsAll("af", "af");
            
            Assert.AreEqual(false, result);
        }

        [Test]
        public void ContainsAnyKey()
        {
            IEnumerable<string> dictionary = new List<string>();
            
            var result = dictionary.ContainsAny("af", "af");
            
            Assert.AreEqual(false, result);
        }

        [Test]
        public void ForEach()
        {
            IEnumerable<int> dictionary = new List<int>(){1,2,3};
            
            int sum = 0;
            dictionary.ForEach((c) => sum += c);
            
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void ReversedForEach()
        {
            IEnumerable<int> dictionary = new List<int>(){1,2,3};
            
            int sum = 0;
            dictionary.ForEachReverse((c) => sum += c);
            Assert.AreEqual(6, sum);
        }
        class FOO
        {
            public string a;
            public int b;
        }
        
        [Test]
        public void GetAllRepeated()
        {
            var ls = new List<FOO>()
            {
                new FOO(){a = "1", b= 1},
                new FOO(){a = "1", b= 2},
                new FOO(){a = "2", b= 3}
            };
            var repeated = ls.GetAllRepeated((c)=> c.a == "1");
            Assert.AreEqual(2, repeated.Count());
        }

        [Test]
        public void GetAllDuplicates()
        {
            var ls = new List<FOO>()
            {
                new FOO(){a = "1", b= 1},
                new FOO(){a = "1", b= 2},
                new FOO(){a = "2", b= 1}
            };
            var duplicatesAB = ls.GetDuplicates(a=> new {a.a, a.b});
            Assert.AreEqual(0, duplicatesAB.Count());
            var duplicatesA = ls.GetDuplicates(a=> a.a);
            Assert.AreEqual(1, duplicatesA.Count());
            var duplicatesB = ls.GetDuplicates(a=> a.b);
            Assert.AreEqual(1, duplicatesB.Count());
        }

        [Test]
        public void GetMoreThanOnceRepeated()
        {
            var ls = new List<FOO>()
            {
                new FOO(){a = "1", b= 1},
                new FOO(){a = "1", b= 2},
                new FOO(){a = "2", b= 1},
                new FOO(){a = "2", b= 1}
            };
            var duplicatesA = ls.GetMoreThanOnceRepeated(c=> c.a);
            Assert.AreEqual(2, duplicatesA.Count());
            var duplicatesB = ls.GetMoreThanOnceRepeated(c => c.b);
            Assert.AreEqual(2, duplicatesB.Count());
        }

        [Test]
        public void IsEmpty()
        {
            IEnumerable<string> en = new List<string>(){"agag"};
            Assert.AreEqual(false, en.IsEmpty());
            en = new List<string>();
            Assert.AreEqual(true, en.IsEmpty());
        }

        [Test]
        public void IsNotNullOrEmpty()
        {
            IEnumerable<string> en = new List<string>(){"agag"};
            Assert.AreEqual(true, en.IsNotNullOrEmpty());
            en = new List<string>();
            Assert.AreEqual(false, en.IsNotNullOrEmpty());
        }

        [Test]
        public void StringJoin()
        {
            IEnumerable<string> en = new List<string>(){"agag", "agag", "aagag"};
            string enJoin = "agag,agag,aagag";
            Assert.AreEqual(enJoin, en.StringJoin(","));
        }
    }
}