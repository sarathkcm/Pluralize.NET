using System.Text.RegularExpressions;

namespace Pluralize.NET
{
    public interface IPluralize
    {
        void AddIrregularRule(string single, string plural);
        void AddPluralRule(Regex rule, string replacement);
        void AddPluralRule(string rule, string replacement);
        void AddSingularRule(Regex rule, string replacement);
        void AddSingularRule(string rule, string replacement);
        void AddUncountableRule(Regex rule);
        void AddUncountableRule(string word);
        string Format(string word, int count, bool inclusive = false);
        bool IsPlural(string word);
        bool IsSingular(string word);
        string Pluralize(string word);
        string Singularize(string word);
    }
}