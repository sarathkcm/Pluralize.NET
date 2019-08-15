using Pluralize.NET.Rules;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pluralize.NET
{
    public abstract class PluralizerBase : IPluralize
    {
        protected readonly IDictionary<Regex, string> _pluralRules = PluralRules.GetRules();
        protected readonly IDictionary<Regex, string> _singularRules = SingularRules.GetRules();
        protected readonly ICollection<string> _uncountables = Uncountables.GetUncountables();
        protected readonly IDictionary<string, string> _irregularPlurals = IrregularRules.GetIrregularPlurals();
        protected readonly IDictionary<string, string> _irregularSingles = IrregularRules.GetIrregularSingulars();

        private static readonly Regex _replacementRegex = new Regex("\\$(\\d{1,2})");

        public string Pluralize(string word)
        {
            return Transform(word, _irregularSingles, _irregularPlurals, _pluralRules);
        }

        public string Singularize(string word)
        {
            return Transform(word, _irregularPlurals, _irregularSingles, _singularRules);
        }

        public bool IsSingular(string word)
        {
            return Singularize(word) == word;
        }

        public bool IsPlural(string word)
        {
            return Pluralize(word) == word;
        }

        public string Format(string word, int count, bool inclusive = false)
        {
            var pluralized = count == 1 ?
                Singularize(word) : Pluralize(word);

            return (inclusive ? count + " " : "") + pluralized;
        }

        public void AddPluralRule(Regex rule, string replacement)
        {
            _pluralRules.Add(rule, replacement);
        }

        public void AddPluralRule(string rule, string replacement)
        {
            var regexRule = SanitizeRule(rule);
            _pluralRules.Add(regexRule, replacement);
        }

        public void AddSingularRule(Regex rule, string replacement)
        {
            _singularRules.Add(rule, replacement);
        }

        public void AddSingularRule(string rule, string replacement)
        {
            var regexRule = SanitizeRule(rule);
            _singularRules.Add(regexRule, replacement);
        }

        public void AddUncountableRule(string word)
        {
            _uncountables.Add(word);
        }

        public void AddUncountableRule(Regex rule)
        {
            _pluralRules.Add(rule, "$0");
            _singularRules.Add(rule, "$0");
        }

        public void AddIrregularRule(string single, string plural)
        {
            _irregularSingles.Add(single, plural);
            _irregularPlurals.Add(plural, single);
        }

        private Regex SanitizeRule(string rule)
        {
            return new Regex($"^{rule}$", RegexOptions.IgnoreCase);
        }

        private string RestoreCase(string originalWord, string newWord)
        {
            // Tokens are an exact match.
            if (originalWord == newWord)
                return newWord;

            // Lower cased words. E.g. "hello".
            if (originalWord == originalWord.ToLower())
                return newWord.ToLower();

            // Upper cased words. E.g. "HELLO".
            if (originalWord == originalWord.ToUpper())
                return newWord.ToUpper();

            // Title cased words. E.g. "Title".
            if (originalWord[0] == char.ToUpper(originalWord[0]))
                return char.ToUpper(newWord[0]) + newWord.Substring(1);

            // Lower cased words. E.g. "test".
            return newWord.ToLower();
        }

        private string ApplyRules(string token, string originalWord, IDictionary<Regex, string> rules)
        {
            // Empty string or doesn't need fixing.
            if (string.IsNullOrEmpty(token) || _uncountables.Contains(token))
                return originalWord;

            var length = rules.Count;

            // Iterate over the sanitization rules and use the first one to match.
            foreach (KeyValuePair<Regex, string> rule in rules)
            {
                // If the rule passes, return the replacement.
                if (rule.Key.IsMatch(originalWord))
                {
                    var match = rule.Key.Match(originalWord);
                    var matchString = match.Groups[0].Value;
                    if (string.IsNullOrWhiteSpace(matchString))
                        return rule.Key.Replace(originalWord, GetReplaceMethod(originalWord[match.Index - 1].ToString(), rule.Value), 1);
                    return rule.Key.Replace(originalWord, GetReplaceMethod(matchString, rule.Value), 1);
                }
            }

            return originalWord;
        }

        private MatchEvaluator GetReplaceMethod(string originalWord, string replacement)
        {
            return match =>
            {
                return RestoreCase(originalWord, _replacementRegex.Replace(replacement, m => match.Groups[int.Parse(m.Groups[1].Value)].Value));
            };
        }

        private string Transform(string word, IDictionary<string, string> replacables,
            IDictionary<string, string> keepables, IDictionary<Regex, string> rules)
        {
            if (keepables.ContainsKey(word)) return word;
            if (replacables.TryGetValue(word, out string token)) return RestoreCase(word, token);
            return ApplyRules(word, word, rules);
        }
    }
}
