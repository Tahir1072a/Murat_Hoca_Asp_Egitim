using Entity_Layer.Concrete;
using Microsoft.EntityFrameworkCore;
//Migration : Code First Yaklaşımıdır. Burada oluşturduğumuz entityler direkt olarak sql içinde bir database olarak oluşturulur.
namespace Data_Access_Layer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost, 1433;Database=MuratDB;User ID=SA;Password=Viabelli34*.;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}