using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pluralize.NET.Rules
{
    internal static class PluralRules
    {
        public static Dictionary<Regex, string> GetRules()
        {
            return new Dictionary<Regex, string>
            {
                {new Regex("s?$",RegexOptions.IgnoreCase), "s"},
                {new Regex("[^\u0000-\u007F]$",RegexOptions.IgnoreCase), "$0"},
                {new Regex("([^aeiou]ese)$",RegexOptions.IgnoreCase), "$1"},
                {new Regex("(ax|test)is$",RegexOptions.IgnoreCase), "$1es"},
                {new Regex("(alias|[^aou]us|tlas|gas|ris)$",RegexOptions.IgnoreCase), "$1es"},
                {new Regex("(e[mn]u)s?$",RegexOptions.IgnoreCase), "$1s"},
                {new Regex("([^l]ias|[aeiou]las|[emjzr]as|[iu]am)$",RegexOptions.IgnoreCase), "$1"},
                {new Regex("(alumn|syllab|octop|vir|radi|nucle|fung|cact|stimul|termin|bacill|foc|uter|loc|strat)(?:us|i)$",RegexOptions.IgnoreCase), "$1i"},
                {new Regex("(alumn|alg|vertebr)(?:a|ae)$",RegexOptions.IgnoreCase), "$1ae"},
                {new Regex("(seraph|cherub)(?:im)?$",RegexOptions.IgnoreCase), "$1im"},
                {new Regex("(her|at|gr)o$",RegexOptions.IgnoreCase), "$1oes"},
                {new Regex("(agend|addend|millenni|dat|extrem|bacteri|desiderat|strat|candelabr|errat|ov|symposi|curricul|automat|quor)(?:a|um)$",RegexOptions.IgnoreCase), "$1a"},
                {new Regex("(apheli|hyperbat|periheli|asyndet|noumen|phenomen|criteri|organ|prolegomen|hedr|automat)(?:a|on)$",RegexOptions.IgnoreCase), "$1a"},
                {new Regex("sis$",RegexOptions.IgnoreCase), "ses"},
                {new Regex("(?:(kni|wi|li)fe|(ar|l|ea|eo|oa|hoo)f)$",RegexOptions.IgnoreCase), "$1$2ves"},
                {new Regex("([^aeiouy]|qu)y$",RegexOptions.IgnoreCase), "$1ies"},
                {new Regex("([^ch][ieo][ln])ey$",RegexOptions.IgnoreCase), "$1ies"},
                {new Regex("(x|ch|ss|sh|zz)$",RegexOptions.IgnoreCase), "$1es"},
                {new Regex("(matr|cod|mur|sil|vert|ind|append)(?:ix|ex)$",RegexOptions.IgnoreCase), "$1ices"},
                {new Regex("(m|l)(?:ice|ouse)$",RegexOptions.IgnoreCase), "$1ice"},
                {new Regex("(pe)(?:rson|ople)$",RegexOptions.IgnoreCase), "$1ople"},
                {new Regex("(child)(?:ren)?$",RegexOptions.IgnoreCase), "$1ren"},
                {new Regex("eaux$",RegexOptions.IgnoreCase), "$0"},
                {new Regex("m[ae]n$",RegexOptions.IgnoreCase), "men"},
                {new Regex("^thou$",RegexOptions.IgnoreCase), "you" },


                {new Regex("pox$",RegexOptions.IgnoreCase),        "$0"},
                {new Regex("ois$",RegexOptions.IgnoreCase),        "$0"},
                {new Regex("deer$",RegexOptions.IgnoreCase),       "$0"},
                {new Regex("fish$",RegexOptions.IgnoreCase),       "$0"},
                {new Regex("sheep$",RegexOptions.IgnoreCase),      "$0"},
                {new Regex("measles$/",RegexOptions.IgnoreCase),   "$0"},
                {new Regex("[^aeiou]ese$",RegexOptions.IgnoreCase),"$0"}
            };
        }
    }
}
