using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluralize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralize.NET.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class PluralizerTests
    {
        Pluralizer _pluralizer = new Pluralizer();

        [TestMethod]
        public void TestMethod()
        {
            var input = Resources.InputData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var singular = line.Split(',')[0];
                var plural = line.Split(',')[1];
                Assert.AreEqual(plural, _pluralizer.Pluralize(singular));
                Assert.AreEqual(plural, _pluralizer.Pluralize(plural));
                Assert.AreEqual(singular, _pluralizer.Singularize(plural));
                Assert.AreEqual(singular, _pluralizer.Singularize(singular));
            }
        }

        
    }
}
