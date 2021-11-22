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

        /// <summary>
        /// Controller logger object.
        /// </summary>
        private readonly ILogger<GameController> _logger;

        /// <summary>
        /// The game service domain logics.
        /// </summary>
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
        [Route("proces-player-bets")]
        public async Task<ActionResult> ProcesBet()
        {
            try
            {
                // Get all the player bets from the repository
                var playerBets = _gameService.GetAllPlayerBets();

                // process each player bet and proces the win.
                foreach(var playerBet in playerBets)
                {
                    switch (playerBet.bet.type)
                    {
                        case (int)BetType.Direct:
                            _gameService.ProcesBetDirect(playerBet);
                            break;
                        case (int)BetType.Divided:
                            _gameService.ProcesBetDivided(playerBet);
                            break;
                        case (int)BetType.Street:
                            _gameService.ProcesBetStreet(playerBet);
                            break;
                        case (int)BetType.Corner:
                            _gameService.ProcesBetCorner(playerBet);
                            break;
                        case (int)BetType.FiveNumbers:
                            _gameService.ProcesBetFiveNumbers(playerBet);
                            break;
                        case (int)BetType.Line:
                            _gameService.ProcesBetLine(playerBet);
                            break;
                        case (int)BetType.Dozen:
                            _gameService.ProcesBetDozen(playerBet);
                            break;
                        case (int)BetType.Column:
                            _gameService.ProcesBetColumn(playerBet);
                            break;
                        case (int)BetType.DoubleDozen:
                            _gameService.ProcesBetDoubleDozen(playerBet);
                            break;
                        case (int)BetType.DoubleColumn:
                            _gameService.ProcesBetDoubleColumn(playerBet);
                            break;
                        case (int)BetType.Color:
                            _gameService.ProcesBetColors(playerBet);
                            break;
                        case (int)BetType.Odd:
                            _gameService.ProcesBetOdds(playerBet);
                            break;
                        default:
                            break;
                    }
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
        [Route("wheel")]
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
        [Route("player-bet")]
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
