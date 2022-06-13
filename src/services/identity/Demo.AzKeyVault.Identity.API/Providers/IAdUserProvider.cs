namespace Demo.AzKeyVault.Identity.API;

public interface IAdUserProvider
{
    Task<bool> UserHasPermisssionToGroup(string groupName, string SamAccountName);
}