using System.Collections.Generic;

using ADUserExtractor.Lib.Formatters;

namespace ADUserExtractor.Lib.Writers
{
    public abstract class UsersWriter
    {
        public abstract void Write(Dictionary<string, string> users, Formatter formatter);
    }
}
