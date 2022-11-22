namespace RemoteFileExplorer.Models
{
    public class ExplorerDb : DbContext
    {
        public ExplorerDb(DbContextOptions<ExplorerDb> options) : base(options){}
        public DbSet<File> Files => Set<File>();
        public DbSet<User> Users => Set<User>();

    }
}
