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

        [HttpGet]
        public async Task<ActionResult> Bet(int betType, int number)
        {
            try
            {
                switch(betType)
                {
                    case (int)BetType.Direct:
                        _gameService.BetDirect(number);
                        break;
                    case (int)BetType.Divided:
                        _gameService.betDivided(number);
                        break;
                    case (int)BetType.Street:
                        _gameService.BetStreet(number);
                        break;
                    case (int)BetType.Corner:
                        _gameService.BetCorner(number);
                        break;
                    case (int)BetType.FiveNumbers:
                        _gameService.BetFiveNumbers(number);
                        break;
                    case (int)BetType.Line:
                        _gameService.BetLine(number);
                        break;
                    case (int)BetType.Dozen:
                        _gameService.betDozen(number);
                        break;
                    case (int)BetType.Column:
                        _gameService.BetColumn(number);
                        break;
                    case (int)BetType.DoubleDozen:
                        _gameService.betDoubleDozen(number);
                        break;
                    case (int)BetType.DoubleColumn:
                        _gameService.BetDoubleColumn(number);
                        break;
                    case (int)BetType.Color:
                        _gameService.BetColors(number);
                        break;
                    case (int)BetType.Odd:
                        _gameService.BetOdds(number);
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

        #endregion
    }
}
