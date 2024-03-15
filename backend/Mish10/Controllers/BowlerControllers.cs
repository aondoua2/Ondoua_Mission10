using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mish10.Data;
using SQLitePCL;

//namespace Mish10.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BowlerControllers : ControllerBase
//    {
//        private IBowlerRepository _bowlerRepository;
//        // constructor 
//        public BowlerControllers(IBowlerRepository temp)
//        {
//           _bowlerRepository = temp;
//        }

//        // set up a get method
//        [HttpGet]
//        public IEnumerable<Bowler> Get()
//        {
//            //var bowlerData = _bowlerRepository.Bowlers.ToArray();
//            //return bowlerData;
//            var bowlers = _bowlerRepository.Bowlers.Include("Team");
//            return (_bowlerRepository.Bowlers.ToArray(), bowlers);


//        }
//    }
//}

namespace Mish10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerControllers : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        // constructor 
        public BowlerControllers(IBowlerRepository bowlerRepository)
        {
            _bowlerRepository = bowlerRepository;
        }

        // set up a get method
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlers = _bowlerRepository.Bowlers;

            foreach (var bowler in bowlers)
            {
                var team = _bowlerRepository.GetTeamById(bowler.TeamID);

                if (team != null)
                {
                    bowler.Team = team;
                }
            }

            return bowlers
                .Where(x => x.Team.TeamName == "Sharks" || x.Team.TeamName == "Marlins");
        }
    }

}



