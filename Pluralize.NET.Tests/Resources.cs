using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Pluralize.NET.Tests
{
    public static class Resources
    {
        private static readonly Lazy<string> _inputData;
        private static readonly Lazy<string> _pluralToSingularExceptions;
        private static readonly Lazy<string> _singularToPluralExceptions;
        static Resources()
        {
            _inputData = new Lazy<string>(() => GetFileContents("Pluralize.NET.Tests.TestData.InputData.csv"));
            _pluralToSingularExceptions = new Lazy<string>(() => GetFileContents("Pluralize.NET.Tests.TestData.PluralToSingularExceptions.csv"));
            _singularToPluralExceptions = new Lazy<string>(() => GetFileContents("Pluralize.NET.Tests.TestData.SingularToPluralExceptions.csv"));
        }

        static string GetFileContents(string namespaceAndFileName)
        {
            try
            {
                using (var stream = typeof(Resources).GetTypeInfo().Assembly.GetManifestResourceStream(namespaceAndFileName))
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                    return reader.ReadToEnd();
            }
            catch (Exception exception)
            {
                throw new Exception($"Failed to read Embedded Resource {namespaceAndFileName}", exception);
            }
        }
        public static string InputData => _inputData.Value;
        public static string PluralToSingularExceptions => _pluralToSingularExceptions.Value;
        public static string SingularToPluralExceptions => _singularToPluralExceptions.Value;
    }
}