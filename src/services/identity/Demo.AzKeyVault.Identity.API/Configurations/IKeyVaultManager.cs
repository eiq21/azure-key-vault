namespace Demo.AzKeyVault.Identity.API.Configurations;


public interface IKeyVaultManager
{
    public Task<string> GetSecret(string secretName);
}

