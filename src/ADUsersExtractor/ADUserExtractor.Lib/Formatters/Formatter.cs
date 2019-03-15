using System.Collections.Generic;

namespace ADUserExtractor.Lib.Formatters
{
    public abstract class Formatter
    {
        public abstract string FormatExtension { get; }

        public abstract IEnumerable<string> Format(Dictionary<string, string> users);
    }
}
