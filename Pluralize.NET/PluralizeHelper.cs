namespace Pluralize.NET
{
    public static class PluralizeHelper
    {
        public static string Pluralize(this int count, string unit)
        {
            return new Pluralizer().Format(unit, count, true);
        }

        public static string Pluralize(this float count, string unit)
        {
            return new Pluralizer().Format(unit, (int)count, true);
        }

        public static string Pluralize(this double count, string unit)
        {
            return new Pluralizer().Format(unit, (int)count, true);
        }

        public static string Pluralize(this string unit, int count)
        {
            return new Pluralizer().Format(unit, count);
        }
    }
}
