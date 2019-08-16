using System.Text.RegularExpressions;

namespace Pluralize.NET.Rules
{
    public class ReplaceRule
    {
        public Regex Condition { get; set; }
        public string ReplaceWith { get; set; }
    }
}
