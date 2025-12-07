using Microsoft.EntityFrameworkCore;

namespace chronovault_api.Infra.Data
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyConfigurationsFromAssembly(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserCredentialConfiguration());
        }
    }
}
