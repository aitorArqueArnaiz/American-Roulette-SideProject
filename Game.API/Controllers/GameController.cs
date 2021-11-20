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
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetDivided()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> betStreet()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> betCorner()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetFiveNumbers()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetLine()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        // -------------------------------------------- EXTERNAL BETS -------------------------------------------------------------
        [HttpGet]
        public async Task<ActionResult> BetDozen()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetColumn()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetDoubleDozen()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetDoubleColumn()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetColors()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BetOdds()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        #endregion
    }
}
