using Microsoft.EntityFrameworkCore;

namespace IS_413___Mission_10___Backend.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlerContext;

        public EFBowlingRepository(BowlingLeagueContext temp) // Sets an instance of our context so we can use it
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers // Grabs our bowler data while including the team from the teams table
            .Include(t => t.Team);
        public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}
