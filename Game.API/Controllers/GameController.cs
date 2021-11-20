/// <summary>
///  This class implements the yankee roulette game.
/// </summary>


using Game.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        #region Variables

        private readonly ILogger<GameController> _logger;
        private readonly IGameService _gameService;

        #endregion

        public GameController(ILogger<GameController> logger,
                              IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
        }

        #region Endpoints

        // -------------------------------------------- INTERNAL BETS -------------------------------------------------------------
        [HttpGet]
        public async Task<ActionResult> BetDirect()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetDivided()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> betStreet()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> betCorner()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetFiveNumbers()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetLine()
        {
            return Ok();
        }

        // -------------------------------------------- EXTERNAL BETS -------------------------------------------------------------
        [HttpGet]
        public async Task<ActionResult> BetDozen()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetColumn()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetDoubleDozen()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetDoubleColumn()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetColors()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> BetOdds()
        {
            return Ok();
        }

        #endregion
    }
}
