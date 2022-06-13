using System.DirectoryServices.AccountManagement;

namespace Demo.AzKeyVault.Identity.API;

public class AdUserProvider : IAdUserProvider
{
    public Task<bool> UserHasPermisssionToGroup(string groupName, string SamAccountName)
    {
        return Task.Run(() =>
          {
              try
              {
                  var principalContext = new PrincipalContext(ContextType.Domain, "credito.bcp.com.pe");

                  UserPrincipal user = UserPrincipal.FindByIdentity(principalContext, SamAccountName);
                  GroupPrincipal group = GroupPrincipal.FindByIdentity(principalContext, groupName);
                  return user != null && user.IsMemberOf(group);

              }
              catch (System.Exception)
              {

                  return false;
              }

          });
    }
}
