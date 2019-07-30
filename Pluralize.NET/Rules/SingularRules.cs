using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pluralize.NET.Rules
{
    internal static class SingularRules
    {
        public static IDictionary<Regex, string> GetRules()
        {
            return new Dictionary<Regex, string>
            {
                // rules are in priority order
                {new Regex("sheep$",RegexOptions.IgnoreCase),      "$0"},
                {new Regex("pox$",RegexOptions.IgnoreCase),        "$0"},
                {new Regex("o[iu]s$",RegexOptions.IgnoreCase),     "$0"},
                {new Regex("measles$/",RegexOptions.IgnoreCase),   "$0"},
                {new Regex("fish$",RegexOptions.IgnoreCase),       "$0"},
                {new Regex("deer$",RegexOptions.IgnoreCase),       "$0"},
                {new Regex("[^aeiou]ese$",RegexOptions.IgnoreCase),"$0"},

               {new Regex("men$",RegexOptions.IgnoreCase), "man" },
               {new Regex("(eau)x?$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(child)ren$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(pe)(rson|ople)$",RegexOptions.IgnoreCase), "$1rson"},
               {new Regex("(matr|append)ices$",RegexOptions.IgnoreCase), "$1ix"},
               {new Regex("(cod|mur|sil|vert|ind)ices$",RegexOptions.IgnoreCase), "$1ex"},
               {new Regex("(alumn|alg|vertebr)ae$",RegexOptions.IgnoreCase), "$1a"},
               {new Regex("(apheli|hyperbat|periheli|asyndet|noumen|phenomen|criteri|organ|prolegomen|hedr|automat)a$",RegexOptions.IgnoreCase), "$1on"},
               {new Regex("(agend|addend|millenni|dat|extrem|bacteri|desiderat|strat|candelabr|errat|ov|symposi|curricul|quor)a$",RegexOptions.IgnoreCase), "$1um"},
               {new Regex("(alumn|syllab|octop|vir|radi|nucle|fung|cact|stimul|termin|bacill|foc|uter|loc|strat)(?:us|i)$",RegexOptions.IgnoreCase), "$1us"},
               {new Regex("(test)(?:is|es)$",RegexOptions.IgnoreCase), "$1is"},
               {new Regex("(movie|twelve|abuse|e[mn]u)s$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(analy|ba|diagno|parenthe|progno|synop|the|empha|cri)(?:sis|ses)$",RegexOptions.IgnoreCase), "$1sis"},
               {new Regex("(x|ch|ss|sh|zz|tto|go|cho|alias|[^aou]us|t[lm]as|gas|(?:her|at|gr)o|ris)(?:es)?$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(seraph|cherub)im$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("\\b((?:tit)?m|l)ice$",RegexOptions.IgnoreCase), "$1ouse"},
               {new Regex("\\b(mon|smil)ies$",RegexOptions.IgnoreCase), "$1ey"},
               {new Regex("\\b([pl]|zomb|(?:neck|cross)?t|coll|faer|food|gen|goon|group|lass|talk|goal|cut)ies$",RegexOptions.IgnoreCase), "$1ie"},
               {new Regex("ies$",RegexOptions.IgnoreCase), "y"},
               {new Regex("(ar|(?:wo|[ae])l|[eo][ao])ves$",RegexOptions.IgnoreCase), "$1f"},
               {new Regex("(wi|kni|(?:after|half|high|low|mid|non|night|[^\\w]|^)li)ves$",RegexOptions.IgnoreCase), "$1fe"},
               {new Regex("(ss)$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("s$",RegexOptions.IgnoreCase), ""}
            };
        }
    }
}
