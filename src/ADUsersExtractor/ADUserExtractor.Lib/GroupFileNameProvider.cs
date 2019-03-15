using System;

namespace ADUserExtractor.Lib
{
    public class GroupFileNameProvider
    {
        public string GetFileName(string groupName) => $"C:\\Temp\\{groupName}_{DateTime.Now.ToString("yyyy_MM_dd")}";
    }
}
