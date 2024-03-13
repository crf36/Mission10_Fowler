namespace IS_413___Mission_10___Backend.Data
{
    public interface IBowlingRepository // Defines our bowler repository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
