using IS_413___Mission_10___Backend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IS_413___Mission_10___Backend.Controllers
{
    [Route("[controller]")] //Defines how we can access the api (in this case our controller name)
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlerRepository;

        public BowlingLeagueController(IBowlingRepository temp) // Sets an instance of our repository
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers.ToArray(); // Sends our bowler data to an array and returns the data when called

            return bowlerData;
        }
    }
}
