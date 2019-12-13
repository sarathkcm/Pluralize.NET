using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pluralize.NET.Rules
{
    internal static class PluralRules
    {
        public static IList<ReplaceRule> GetRules()
        {
            return new List<ReplaceRule>
            {
                // rules are ordered more generic first
                new ReplaceRule { Condition = new Regex("s?$",RegexOptions.IgnoreCase), ReplaceWith = "s" },
                new ReplaceRule { Condition = new Regex("[^\u0000-\u007F]$",RegexOptions.IgnoreCase),  ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("([^aeiou]ese)$", RegexOptions.IgnoreCase), ReplaceWith = "$1" },
                new ReplaceRule { Condition = new Regex("(ax|test)is$",RegexOptions.IgnoreCase),  ReplaceWith = "$1es" },
                new ReplaceRule { Condition = new Regex("(alias|[^aou]us|t[lm]as|gas|ris)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1es" },
                new ReplaceRule { Condition = new Regex("(e[mn]u)s?$",RegexOptions.IgnoreCase),  ReplaceWith = "$1s" },
                new ReplaceRule { Condition = new Regex("([^l]ias|[aeiou]las|[ejzr]as|[iu]am)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1" },
                new ReplaceRule { Condition = new Regex("(alumn|syllab|vir|radi|nucle|fung|cact|stimul|termin|bacill|foc|uter|loc|strat)(?:us|i)$", RegexOptions.IgnoreCase), ReplaceWith = "$1i" },
                new ReplaceRule { Condition = new Regex("(alumn|alg|vertebr)(?:a|ae)$",RegexOptions.IgnoreCase), ReplaceWith = "$1ae" },
                new ReplaceRule { Condition = new Regex("(seraph|cherub)(?:im)?$",RegexOptions.IgnoreCase), ReplaceWith = "$1im" },
                new ReplaceRule { Condition = new Regex("(her|at|gr)o$", RegexOptions.IgnoreCase), ReplaceWith = "$1oes" },
                new ReplaceRule { Condition = new Regex("(agend|addend|millenni|dat|extrem|bacteri|desiderat|strat|candelabr|errat|ov|symposi|curricul|automat|quor)(?:a|um)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1a" },
                new ReplaceRule { Condition = new Regex("(apheli|hyperbat|periheli|asyndet|noumen|phenomen|criteri|organ|prolegomen|hedr|automat)(?:a|on)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1a" },
                new ReplaceRule { Condition = new Regex("sis$",RegexOptions.IgnoreCase), ReplaceWith = "ses" },
                new ReplaceRule { Condition = new Regex("(?:(kni|wi|li)fe|(ar|l|ea|eo|oa|hoo)f)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1$2ves" },
                new ReplaceRule { Condition = new Regex("([^aeiouy]|qu)y$",RegexOptions.IgnoreCase),  ReplaceWith = "$1ies" },
                new ReplaceRule { Condition = new Regex("([^ch][ieo][ln])ey$",RegexOptions.IgnoreCase),  ReplaceWith = "$1ies" },
                new ReplaceRule { Condition = new Regex("(x|ch|ss|sh|zz)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1es" },
                new ReplaceRule { Condition = new Regex("(matr|cod|mur|sil|vert|ind|append)(?:ix|ex)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1ices" },
                new ReplaceRule { Condition = new Regex("\\b((?:tit)?m|l)(?:ice|ouse)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1ice" },
                new ReplaceRule { Condition = new Regex("(pe)(?:rson|ople)$",RegexOptions.IgnoreCase),  ReplaceWith = "$1ople" },
                new ReplaceRule { Condition = new Regex("(child)(?:ren)?$",RegexOptions.IgnoreCase),  ReplaceWith = "$1ren" },
                new ReplaceRule { Condition = new Regex("eaux$",RegexOptions.IgnoreCase),  ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("m[ae]n$",RegexOptions.IgnoreCase), ReplaceWith = "men" },
                new ReplaceRule { Condition = new Regex("^thou$",RegexOptions.IgnoreCase), ReplaceWith = "you" },


                new ReplaceRule { Condition = new Regex("pox$",RegexOptions.IgnoreCase), ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("o[iu]s$",RegexOptions.IgnoreCase), ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("deer$",RegexOptions.IgnoreCase), ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("fish$",RegexOptions.IgnoreCase), ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("sheep$",RegexOptions.IgnoreCase), ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("measles$/",RegexOptions.IgnoreCase), ReplaceWith = "$0" },
                new ReplaceRule { Condition = new Regex("[^aeiou]ese$",RegexOptions.IgnoreCase), ReplaceWith = "$0" }
            };
        }
    }
}
