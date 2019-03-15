using System.Collections.Generic;
using System.Linq;

namespace ADUserExtractor.Lib.Formatters
{
    public class TxtFormatter : Formatter
    {
        public override string FormatExtension => ".txt";

        public override IEnumerable<string> Format(Dictionary<string, string> users)
        {
            foreach (KeyValuePair<string, string> item in users.OrderBy(d => d.Key))
            {
                yield return $"{item.Key} - {item.Value}";
            }
        }
    }
}
