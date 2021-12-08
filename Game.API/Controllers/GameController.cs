/// <summary>
///  This class implements the yankee roulette game.
/// </summary>


using Game.API.DTOs;
using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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
                // List of players and their corresponding wins
                List<PlayerBetResponse> response = new List<PlayerBetResponse>() { };

                // Get all the player bets from the repository
                var playerBets = await Task.Run(() => _gameService.GetAllPlayerBets());

                double? playerWin = 0.0;

                // process each player bet and proces the win.
                foreach(var playerBet in playerBets)
                {
                    switch (playerBet.bet.type)
                    {
                        case (int)BetType.Direct:
                            playerWin = _gameService.ProcesBetDirect(playerBet);
                            break;
                        case (int)BetType.Divided:
                            playerWin = _gameService.ProcesBetDivided(playerBet);
                            break;
                        case (int)BetType.Street:
                            playerWin = _gameService.ProcesBetStreet(playerBet);
                            break;
                        case (int)BetType.Corner:
                            playerWin = _gameService.ProcesBetCorner(playerBet);
                            break;
                        case (int)BetType.FiveNumbers:
                            playerWin = _gameService.ProcesBetFiveNumbers(playerBet);
                            break;
                        case (int)BetType.Line:
                            playerWin = _gameService.ProcesBetLine(playerBet);
                            break;
                        case (int)BetType.Dozen:
                            playerWin = _gameService.ProcesBetDozen(playerBet);
                            break;
                        case (int)BetType.Column:
                            playerWin = _gameService.ProcesBetColumn(playerBet);
                            break;
                        case (int)BetType.DoubleDozen:
                            playerWin = _gameService.ProcesBetDoubleDozen(playerBet);
                            break;
                        case (int)BetType.DoubleColumn:
                            playerWin = _gameService.ProcesBetDoubleColumn(playerBet);
                            break;
                        case (int)BetType.Color:
                            playerWin = _gameService.ProcesBetColors(playerBet);
                            break;
                        case (int)BetType.Odd:
                            playerWin = _gameService.ProcesBetOdds(playerBet);
                            break;
                        default:
                            break;
                    }
                    response.Add(new PlayerBetResponse() { playerId = playerBet.Id,  playerWin = playerWin});
                }
                return Ok(response);
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
                await Task.Run(() => _gameService.Wheel());
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
                await Task.Run(() => _gameService.UserBet(bet));
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
