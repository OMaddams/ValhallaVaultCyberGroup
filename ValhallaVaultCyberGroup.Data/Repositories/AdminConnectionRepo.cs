using ValhallaVaultCyberGroup.Data.Models.AdminConnection;
using ValhallaVaultCyberGroup.Ui.Data;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public class AdminConnectionRepo
    {
        private readonly ApplicationDbContext context;

        public AdminConnectionRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAdminConnectionAsync(AdminConnectionModel connectionToAdd)
        {
            await context.AdminConnections.AddAsync(connectionToAdd);
            await context.SaveChangesAsync();
        }
    }
}
