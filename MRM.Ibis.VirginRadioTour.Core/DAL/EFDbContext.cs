using System.Data.Entity;

namespace MRM.Ibis.VirginRadioTour.Core.DAL
{
    /// <summary>
    /// Représente le DbContext permettant d'utiliser des données d'entités dans la base de donnée
    /// </summary>
    public class EFDbContext : DbContext
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe EFDbContext
        /// </summary>
        public EFDbContext()
            : base("virginradio")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //this.Database.Log += this.Log;
        }

        private DbContextTransaction _dbContextTransaction;

        public void BeginTransaction()
        {
            if (this._dbContextTransaction == null)
            {
                this._dbContextTransaction = this.Database.BeginTransaction();
            }
        }

        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public virtual DbSet<BO.Participation> Entities { get; set; }

        public virtual DbSet<BO.Event> Events { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EFDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {            
            int num = base.SaveChanges();
            if (_dbContextTransaction != null) { _dbContextTransaction.Commit(); }
            return num;
        }

        protected void Log(string sql)
        {
            System.Diagnostics.Trace.WriteLine(sql);
        }
    }
}
