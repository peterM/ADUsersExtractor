using System;
using System.Collections.Generic;

using ADUserExtractor.Lib.Formatters;

namespace ADUserExtractor.Lib.Writers
{
    public class UsersConsoleWriter : UsersWriter
    {
        public override void Write(Dictionary<string, string> users, Formatter formatter)
        {
            if (!(formatter is TxtFormatter))
            {
                return;
            }

            foreach (string item in formatter.Format(users))
            {
                Console.WriteLine(item);
            }
        }
    }
}
