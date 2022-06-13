using Azure.Identity;
using Demo.AzKeyVault.Identity.API;
using Demo.AzKeyVault.Identity.API.Configurations;
using Microsoft.Extensions.Azure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddAzureClients(options =>
    {
        options.AddSecretClient(new Uri("<you url key vault>"));
        options.UseCredential(new DefaultAzureCredential());
    });
    builder.Services.AddScoped<IAdUserProvider, AdUserProvider>();
    builder.Services.AddSingleton<IKeyVaultManager, KeyVaultManager>();

    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();

}



