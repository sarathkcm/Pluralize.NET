using NUnit.Framework;

namespace Pluralize.NET.Tests
{
    [TestFixture]
    public class PluralizeHelperTests
    {
        [Test]
        public void Pluralize_Integer_Plural()
        {
            var expected = "Found 10 matches";

            var actual = $"Found {10.Pluralize("matches")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_Integer_Singulare()
        {
            var expected = "Found 1 match";

            var actual = $"Found {1.Pluralize("matches")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_ZeroInteger_Plural()
        {
            var expected = "Found 0 matches";

            var actual = $"Found {0.Pluralize("matches")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_Double_Plural()
        {
            var expected = $"Revenew of {10.5} milions";

            var actual = $"Revenew of {10.5.Pluralize("milions")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_Double_Singulare()
        {
            var expected = $"Revenew of {1.0} milion";

            var actual = $"Revenew of {1.0.Pluralize("milions")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_ZeroDouble_Plural()
        {
            var expected = $"Revenew of {0.0} milions";

            var actual = $"Revenew of {0.0.Pluralize("milions")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_Fraction_Singular()
        {
            var expected = $"Revenew of {0.1} milion";

            var actual = $"Revenew of {0.1.Pluralize("milions")}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_String_Plural()
        {
            var expected = "Found 10 matches";

            var actual = $"Found 10 {"matches".Pluralize(10)}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_String_Singulare()
        {
            var expected = "Found 1 match";

            var actual = $"Found 1 {"matches".Pluralize(1)}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Pluralize_String_ZeroCount_Plural()
        {
            var expected = "Found 0 matches";

            var actual = $"Found 0 {"matches".Pluralize(0)}";

            Assert.AreEqual(expected, actual);
        }
    }
}
