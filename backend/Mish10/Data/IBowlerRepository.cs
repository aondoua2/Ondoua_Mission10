namespace Mish10.Data
{
    public interface IBowlerRepository
    {
        // this should also include the Teams data
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        Team GetTeamById(int? teamID);

    }
}
