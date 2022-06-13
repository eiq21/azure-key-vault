namespace Demo.AzKeyVault.Identity.API.Providers;

public interface ISecretProvider{
  public Task<string> GetSecret(string secretName);
}