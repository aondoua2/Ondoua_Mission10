
//namespace Mish10.Data
//{
//    // implement the Interface
//    public class EFBowlerRepository : IBowlerRepository
//    {
//        private BowlingLeague3Context _bowlerContext;
//        public EFBowlerRepository(BowlingLeague3Context temp)
//        {
//            _bowlerContext = temp;

//        }
//        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
//        public IEnumerable<Team> Teams => _bowlerContext.Teams;

//        public Team GetTeamByID(int? teamID)
//        {
//            return _bowlerContext.Teams.Find(teamID);
//        }

//        public Team GetTeamById(int? teamID)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}


namespace Mish10.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlingLeague3Context _bowlerContext;

        public EFBowlerRepository(BowlingLeague3Context bowlerContext)
        {
            _bowlerContext = bowlerContext;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlerContext.Teams;

        public Team GetTeamById(int? teamID)
        {
            var team = _bowlerContext.Teams.Find(teamID);
            return team;
        }
    }
}



