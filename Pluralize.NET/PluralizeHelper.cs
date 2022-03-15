namespace Pluralize.NET
{
    public static class PluralizeHelper
    {
        public static string Pluralize(this int count, string unit)
        {
            return new Pluralizer().Format(unit, count, true);
        }

        public static string Pluralize(this double count, string unit)
        {
            if ((int)count == 0 && count != 0)
                return $"{count} {new Pluralizer().Format(unit, 1, false)}";
            return $"{count} {new Pluralizer().Format(unit, (int)count, false)}";
        }

        public static string Pluralize(this string unit, int count)
        {
            return new Pluralizer().Format(unit, count);
        }
    }
}
