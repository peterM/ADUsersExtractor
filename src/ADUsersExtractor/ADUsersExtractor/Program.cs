using System;
using System.Collections.Generic;

using ADUserExtractor.Lib;
using ADUserExtractor.Lib.Formatters;
using ADUserExtractor.Lib.Writers;

namespace ADUsersExtractor
{
    static class Program
    {
        static void Main(string[] args)
        {
            string groupName = "groupName";
            string domain = "domain";

            Credentials credentials = new Credentials
            {
                UserName = "username",
                Password = "password"
            };

            AdUserExtractor aDUserExtractor = new AdUserExtractor();
            Dictionary<string, string> users = aDUserExtractor.GetUserData(domain, groupName, credentials);

            string filename = new GroupFileNameProvider().GetFileName(groupName);

            Formatter[] formatters = GetFormatters();
            UsersWriter[] usersWriters = GetWriters(filename);

            foreach (Formatter formatter in formatters)
            {
                foreach (UsersWriter writer in usersWriters)
                {
                    writer.Write(users, formatter);
                }
            }

            Console.ReadKey();
        }

        private static UsersWriter[] GetWriters(string filename)
        {
            return new UsersWriter[]
            {
                 new UsersFileWriter(filename),
                 new UsersConsoleWriter()
            };
        }

        private static Formatter[] GetFormatters()
        {
            return new Formatter[]
            {
                new CsvFormatter(),
                new TxtFormatter()
            };
        }
    }
}
