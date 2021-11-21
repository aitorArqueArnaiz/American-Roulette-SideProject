/// <summary>
///  This class implements the yankee roulette game.
/// </summary>


using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using static Game.Domain.Shared.Enums;

namespace Game.Controllers
{
    [ApiController]
    [Route("api/v1/roulette")]
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

        [HttpPost]
        [Route("ProcesUserBets")]
        public async Task<ActionResult> ProcesBet([FromBody] Bet bet)
        {
            try
            {
                switch(bet.bet.type)
                {
                    case (int)BetType.Direct:
                        _gameService.ProcesBetDirect(bet);
                        break;
                    case (int)BetType.Divided:
                        _gameService.ProcesBetDivided(bet);
                        break;
                    case (int)BetType.Street:
                        _gameService.ProcesBetStreet(bet);
                        break;
                    case (int)BetType.Corner:
                        _gameService.ProcesBetCorner(bet);
                        break;
                    case (int)BetType.FiveNumbers:
                        _gameService.ProcesBetFiveNumbers(bet);
                        break;
                    case (int)BetType.Line:
                        _gameService.ProcesBetLine(bet);
                        break;
                    case (int)BetType.Dozen:
                        _gameService.ProcesBetDozen(bet);
                        break;
                    case (int)BetType.Column:
                        _gameService.ProcesBetColumn(bet);
                        break;
                    case (int)BetType.DoubleDozen:
                        _gameService.ProcesBetDoubleDozen(bet);
                        break;
                    case (int)BetType.DoubleColumn:
                        _gameService.ProcesBetDoubleColumn(bet);
                        break;
                    case (int)BetType.Color:
                        _gameService.ProcesBetColors(bet);
                        break;
                    case (int)BetType.Odd:
                        _gameService.ProcesBetOdds(bet);
                        break;
                    default:
                        break;
                }
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user process bet's operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        [Route("Wheel")]
        public async Task<ActionResult> Wheel()
        {
            try
            {
                _gameService.Wheel();
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during wheel operation {error.Message}");
                return NotFound(error.Message);
            }
        }

        [HttpPut]
        [Route("UserBet")]
        public async Task<ActionResult> Bet([FromBody] Bet bet)
        {
            try
            {
                _gameService.UserBet(bet);
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during save the user bet operation {error.Message}");
                return NotFound(error.Message);
            }
        }

        #endregion
    }
}
