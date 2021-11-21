/// <summary>
///  This class implements the yankee roulette game.
/// </summary>


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
        public async Task<ActionResult> Bet(int betType, string number, int bet)
        {
            try
            {
                switch(betType)
                {
                    case (int)BetType.Direct:
                        _gameService.ProcesBetDirect(number, bet);
                        break;
                    case (int)BetType.Divided:
                        _gameService.ProcesBetDivided(number);
                        break;
                    case (int)BetType.Street:
                        _gameService.ProcesBetStreet(number);
                        break;
                    case (int)BetType.Corner:
                        _gameService.ProcesBetCorner(number);
                        break;
                    case (int)BetType.FiveNumbers:
                        _gameService.ProcesBetFiveNumbers(number);
                        break;
                    case (int)BetType.Line:
                        _gameService.ProcesBetLine(number);
                        break;
                    case (int)BetType.Dozen:
                        _gameService.ProcesBetDozen(number);
                        break;
                    case (int)BetType.Column:
                        _gameService.ProcesBetColumn(number);
                        break;
                    case (int)BetType.DoubleDozen:
                        _gameService.ProcesBetDoubleDozen(number);
                        break;
                    case (int)BetType.DoubleColumn:
                        _gameService.ProcesBetDoubleColumn(number);
                        break;
                    case (int)BetType.Color:
                        _gameService.ProcesBetColors(number);
                        break;
                    case (int)BetType.Odd:
                        _gameService.ProcesBetOdds(number);
                        break;
                    default:
                        break;
                }
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during user bet operation {error.Message}");
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> Spin(int betType, int number)
        {
            try
            {
                _gameService.Spin();
                return Ok();
            }
            catch (Exception error)
            {
                _logger.LogError($"Error ocurred during spin operation {error.Message}");
                return NotFound(error.Message);
            }
        }


        #endregion
    }
}
