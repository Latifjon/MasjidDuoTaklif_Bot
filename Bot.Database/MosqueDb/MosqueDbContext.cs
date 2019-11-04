using Bot.Database.MosqueDb.Tables;
using Microsoft.EntityFrameworkCore;

namespace Bot.Database.MosqueDb
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class MosqueDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public MosqueDbContext()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public MosqueDbContext(DbContextOptions<MosqueDbContext> options) 
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.\\SQLSERVER;Database=MosqueDB;Trusted_Connection=True;");
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<BotUser> BotUsers { get; set; }
    }
}
