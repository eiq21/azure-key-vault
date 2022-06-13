using Azure.Security.KeyVault.Secrets;

namespace Demo.AzKeyVault.Identity.API.Providers;

public class SecretProvider : ISecretProvider
{
    private readonly SecretClient secretClient;

    public SecretProvider(SecretClient secretClient)
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