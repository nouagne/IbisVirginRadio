using System.Data.Entity;

namespace MRM.UMS.Core.DAL
{
    /// <summary>
    /// Fournit un DbContext EntityFramework (héritant de DbContext pour le pattern UnitOfWork)
    /// </summary>
    public class EFDbContext : DbContext
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe EntityDbContext
        /// </summary>
        public EFDbContext()
            : base("virginradio")
        {
        }

        public virtual DbSet<BO.User> Users { get; set; }
        public virtual DbSet<BO.Role> Roles { get; set; }
        public virtual DbSet<BO.UserRole> UserRoles { get; set; }

        /// <summary>
        /// Surcharge de la méthode OnModelCreating pour ajouter la déclaration des contraintes et dépendances
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EFDbContext>(null);
            base.OnModelCreating(modelBuilder);

            // Déclaration de la relation 1:n entre les entités "user" et "userrole"
            modelBuilder.Entity<BO.User>()    
               .HasMany(u => u.UserRoles)
               .WithOptional()
               .HasForeignKey(ur => ur.UserId)
               .WillCascadeOnDelete();

            // Déclaration de la relation 1:n entre les entités "role" et "userrole"
            modelBuilder.Entity<BO.Role>()
               .HasMany(r => r.UserRoles)
               .WithOptional()
               .HasForeignKey(ur => ur.RoleId)
               .WillCascadeOnDelete();
        }
    }
}
