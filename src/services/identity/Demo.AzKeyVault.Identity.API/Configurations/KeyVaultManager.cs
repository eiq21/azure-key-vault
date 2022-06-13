using Azure.Security.KeyVault.Secrets;

namespace Demo.AzKeyVault.Identity.API.Configurations;

public class KeyVaultManager : IKeyVaultManager
{
    private readonly SecretClient secretClient;

    public KeyVaultManager(SecretClient secretClient)
    {
        this.secretClient = secretClient;
    }
    public async Task<string> GetSecret(string secretName)
    {
        try
        {
            KeyVaultSecret keyValueSecret = await secretClient.GetSecretAsync(secretName);
            return keyValueSecret.Value;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

