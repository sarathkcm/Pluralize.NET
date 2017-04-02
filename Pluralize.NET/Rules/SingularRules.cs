using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pluralize.NET.Rules
{
    internal static class SingularRules
    {
        public static Dictionary<Regex, string> GetRules()
        {
            return new Dictionary<Regex, string>
            {
               {new Regex("s$",RegexOptions.IgnoreCase), ""},
               {new Regex("(ss)$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("((a)naly|(b)a|(d)iagno|(p)arenthe|(p)rogno|(s)ynop|(t)he)(?:sis|ses)$",RegexOptions.IgnoreCase), "$1sis"},
               {new Regex("(^analy)(?:sis|ses)$",RegexOptions.IgnoreCase), "$1sis"},
               {new Regex("(wi|kni|(?:after|half|high|low|mid|non|night|[^\\w]|^)li)ves$",RegexOptions.IgnoreCase), "$1fe"},
               {new Regex("(ar|(?:wo|[ae])l|[eo][ao])ves$",RegexOptions.IgnoreCase), "$1f"},
               {new Regex("ies$",RegexOptions.IgnoreCase), "y"},
               {new Regex("\\b([pl]|zomb|(?:neck|cross)?t|coll|faer|food|gen|goon|group|lass|talk|goal|cut)ies$",RegexOptions.IgnoreCase), "$1ie"},
               {new Regex("\\b(mon|smil)ies$",RegexOptions.IgnoreCase), "$1ey"},
               {new Regex("(m|l)ice$",RegexOptions.IgnoreCase), "$1ouse"},
               {new Regex("(seraph|cherub)im$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(x|ch|ss|sh|zz|tto|go|cho|alias|[^aou]us|tlas|gas|(?:her|at|gr)o|ris)(?:es)?$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(e[mn]u)s?$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(movie|twelve)s$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(cris|test|diagnos)(?:is|es)$",RegexOptions.IgnoreCase), "$1is"},
               {new Regex("(alumn|syllab|octop|vir|radi|nucle|fung|cact|stimul|termin|bacill|foc|uter|loc|strat)(?:us|i)$",RegexOptions.IgnoreCase), "$1us"},
               {new Regex("(agend|addend|millenni|dat|extrem|bacteri|desiderat|strat|candelabr|errat|ov|symposi|curricul|quor)a$",RegexOptions.IgnoreCase), "$1um"},
               {new Regex("(apheli|hyperbat|periheli|asyndet|noumen|phenomen|criteri|organ|prolegomen|hedr|automat)a$",RegexOptions.IgnoreCase), "$1on"},
               {new Regex("(alumn|alg|vertebr)ae$",RegexOptions.IgnoreCase), "$1a"},
               {new Regex("(cod|mur|sil|vert|ind)ices$",RegexOptions.IgnoreCase), "$1ex"},
               {new Regex("(matr|append)ices$",RegexOptions.IgnoreCase), "$1ix"},
               {new Regex("(pe)(rson|ople)$",RegexOptions.IgnoreCase), "$1rson"},
               {new Regex("(child)ren$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("(eau)x?$",RegexOptions.IgnoreCase), "$1"},
               {new Regex("men$",RegexOptions.IgnoreCase), "man" },

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
