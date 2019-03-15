using System.Collections.Generic;
using System.IO;
using System.Linq;

using ADUserExtractor.Lib.Formatters;

namespace ADUserExtractor.Lib.Writers
{
    public class UsersFileWriter : UsersWriter
    {
        private readonly string _filePath;

        public UsersFileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public override void Write(Dictionary<string, string> users, Formatter formatter)
        {
            File.WriteAllLines($"{_filePath}{formatter.FormatExtension}", formatter.Format(users).ToArray());
        }
    }
}
