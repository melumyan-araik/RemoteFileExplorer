using RemoteFileExplorer.Models.Auth;

namespace RemoteFileExplorer.Models
{
    public class ExplorerDb : DbContext
    {
        public ExplorerDb(DbContextOptions<ExplorerDb> options) : base(options){}
        public DbSet<EntityFile> Files => Set<EntityFile>();
        public DbSet<User> Users => Set<User>();

    }
}
