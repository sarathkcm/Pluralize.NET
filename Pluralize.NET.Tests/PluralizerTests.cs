using NUnit.Framework;
using Pluralize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralize.NET.Tests
{
    [TestFixture]
    public class PluralizerTests
    {
        Pluralizer _pluralizer = new Pluralizer();

        [Test]
        public void InputData()
        {
            var input = Resources.InputData.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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

        [Test]
        public void ExceptionPluralToSingularException()
        {
            var input = Resources.PluralToSingularExceptions.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var singular = line.Split(',')[0];
                var plural = line.Split(',')[1];
                Assert.AreEqual(singular, _pluralizer.Singularize(plural));
                Assert.AreEqual(singular, _pluralizer.Singularize(singular));
            }
        }
        [Test]
        public void ExceptionSingularToPluralException()
        {
            var input = Resources.SingularToPluralExceptions.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var singular = line.Split(',')[0];
                var plural = line.Split(',')[1];
                Assert.AreEqual(plural, _pluralizer.Pluralize(singular));
                Assert.AreEqual(plural, _pluralizer.Pluralize(plural));
            }
        }

    }
}
