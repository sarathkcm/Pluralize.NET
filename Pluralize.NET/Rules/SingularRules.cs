using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pluralize.NET.Rules
{
    internal static class SingularRules
    {
        public static IList<ReplaceRule> GetRules()
        {
            return new List<ReplaceRule>
            {
                // rules are ordered more generic first
                new ReplaceRule { Condition = new Regex("s$", RegexOptions.IgnoreCase), ReplaceWith = ""},
                new ReplaceRule { Condition = new Regex("(ss)$", RegexOptions.IgnoreCase), ReplaceWith = "$1"},
                new ReplaceRule { Condition = new Regex("(wi|kni|(?:after|half|high|low|mid|non|night|[^\\w]|^)li)ves$", RegexOptions.IgnoreCase), ReplaceWith = "$1fe"},
                new ReplaceRule { Condition = new Regex("(ar|(?:wo|[ae])l|[eo][ao])ves$", RegexOptions.IgnoreCase), ReplaceWith = "$1f"},
                new ReplaceRule { Condition = new Regex("ies$", RegexOptions.IgnoreCase), ReplaceWith ="y"},
                new ReplaceRule { Condition = new Regex("\\b([pl]|zomb|(?:neck|cross)?t|coll|faer|food|gen|goon|group|lass|talk|goal|cut)ies$", RegexOptions.IgnoreCase), ReplaceWith = "$1ie" },
                new ReplaceRule { Condition = new Regex("\\b(mon|smil)ies$", RegexOptions.IgnoreCase), ReplaceWith = "$1ey"},
                new ReplaceRule { Condition = new Regex("\\b((?:tit)?m|l)ice$", RegexOptions.IgnoreCase), ReplaceWith = "$1ouse"},
                new ReplaceRule { Condition = new Regex("(seraph|cherub)im$", RegexOptions.IgnoreCase), ReplaceWith = "$1"},
                new ReplaceRule { Condition = new Regex("(x|ch|ss|sh|zz|tto|go|cho|alias|[^aou]us|t[lm]as|gas|(?:her|at|gr)o|[aeiou]ris)(?:es)?$", RegexOptions.IgnoreCase), ReplaceWith = "$1"},
                new ReplaceRule { Condition = new Regex("(analy|diagno|parenthe|progno|synop|the|empha|cri|ne)(?:sis|ses)$", RegexOptions.IgnoreCase), ReplaceWith = "$1sis"},
                new ReplaceRule { Condition = new Regex("(movie|twelve|abuse|e[mn]u)s$", RegexOptions.IgnoreCase), ReplaceWith = "$1"},
                new ReplaceRule { Condition = new Regex("(test)(?:is|es)$", RegexOptions.IgnoreCase), ReplaceWith = "$1is"},
                new ReplaceRule { Condition = new Regex("(alumn|syllab|octop|vir|radi|nucle|fung|cact|stimul|termin|bacill|foc|uter|loc|strat)(?:us|i)$", RegexOptions.IgnoreCase), ReplaceWith = "$1us"},
                new ReplaceRule { Condition = new Regex("(agend|addend|millenni|dat|extrem|bacteri|desiderat|strat|candelabr|errat|ov|symposi|curricul|quor)a$", RegexOptions.IgnoreCase), ReplaceWith = "$1um"},
                new ReplaceRule { Condition = new Regex("(apheli|hyperbat|periheli|asyndet|noumen|phenomen|criteri|organ|prolegomen|hedr|automat)a$", RegexOptions.IgnoreCase), ReplaceWith = "$1on"},
                new ReplaceRule { Condition = new Regex("(alumn|alg|vertebr)ae$", RegexOptions.IgnoreCase), ReplaceWith = "$1a"},
                new ReplaceRule { Condition = new Regex("(cod|mur|sil|vert|ind)ices$", RegexOptions.IgnoreCase), ReplaceWith = "$1ex"},
                new ReplaceRule { Condition = new Regex("(matr|append)ices$", RegexOptions.IgnoreCase), ReplaceWith = "$1ix"},
                new ReplaceRule { Condition = new Regex("(pe)(rson|ople)$", RegexOptions.IgnoreCase), ReplaceWith = "$1rson"},
                new ReplaceRule { Condition = new Regex("(child)ren$", RegexOptions.IgnoreCase), ReplaceWith = "$1"},
                new ReplaceRule { Condition = new Regex("(eau)x?$", RegexOptions.IgnoreCase), ReplaceWith = "$1"},
                new ReplaceRule { Condition = new Regex("men$", RegexOptions.IgnoreCase), ReplaceWith = "man" },

                new ReplaceRule { Condition = new Regex("[^aeiou]ese$", RegexOptions.IgnoreCase), ReplaceWith = "$0"},
                new ReplaceRule { Condition = new Regex("deer$", RegexOptions.IgnoreCase), ReplaceWith = "$0"},
                new ReplaceRule { Condition = new Regex("fish$", RegexOptions.IgnoreCase), ReplaceWith = "$0"},
                new ReplaceRule { Condition = new Regex("measles$", RegexOptions.IgnoreCase), ReplaceWith = "$0"},
                new ReplaceRule { Condition = new Regex("o[iu]s$", RegexOptions.IgnoreCase), ReplaceWith = "$0"},
                new ReplaceRule { Condition = new Regex("pox$", RegexOptions.IgnoreCase), ReplaceWith = "$0"},
                new ReplaceRule { Condition = new Regex("sheep$", RegexOptions.IgnoreCase), ReplaceWith = "$0" }
            };
        }
    }
}
