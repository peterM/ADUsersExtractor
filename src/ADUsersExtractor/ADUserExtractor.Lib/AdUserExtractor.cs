using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace ADUserExtractor.Lib
{
    public class AdUserExtractor
    {
        public Dictionary<string, string> GetUserData(string domain, string groupName, Credentials credentials)
        {
            Dictionary<string, string> usersPairs = new Dictionary<string, string>();
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domain, credentials.UserName, credentials.Password))
            using (GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName))
            {
                if (group != null)
                {
                    PrincipalSearchResult<Principal> users = group.GetMembers(true);
                    foreach (UserPrincipal user in users)
                    {
                        string key = user.SamAccountName;
                        string value = user.DisplayName;

                        usersPairs.Add(key, value);
                    }
                }
            }

            return usersPairs;
        }
    }
}
