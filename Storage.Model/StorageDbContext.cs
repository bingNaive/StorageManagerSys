using System.Data.Entity;

namespace Storage.Model
{
    public class StorageDbContext:DbContext
    {
        public StorageDbContext()
            : base("name=CodeFirst")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StorageDbContext>());    
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u=>u.CusExportProducts)
                .WithRequired(u=>u.Customer)
                .HasForeignKey(u=>u.CusId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<User>()
                .HasMany(u=>u.HeadExportProducts)
                .WithRequired(u=>u.Head)
                .HasForeignKey(u=>u.UserId)
                .WillCascadeOnDelete(false);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProType> ProTypes { get; set; }
        public DbSet<ProDetailType> ProDetailTypes { get; set; }
        public DbSet<ProValue> ProValues { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Profit> Profits { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IncludeProduct> IncludeProducts { get; set; }
        public DbSet<ExportProduct> ExportProducts { get; set; }
    }
}