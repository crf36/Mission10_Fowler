using Microsoft.EntityFrameworkCore;

namespace IS_413___Mission_10___Backend.Data
{
    public class BowlingLeagueContext : DbContext
    {
        public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options) : base(options)
        {
        }

        // Links our database rows to our project so we can access tables
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}