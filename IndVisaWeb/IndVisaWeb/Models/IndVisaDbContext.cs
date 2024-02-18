using Microsoft.EntityFrameworkCore;

namespace IndVisaWeb.Models
{
    public class IndVisaDbContext : DbContext      
    {
        public IndVisaDbContext(DbContextOptions<IndVisaDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Visa> Visas { get; set; }
    }
}
