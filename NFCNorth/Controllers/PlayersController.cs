using DataService.Repositories;
using Microsoft.AspNetCore.Mvc;
using NFCNorth.Models;
using System;
using System.Threading.Tasks;

namespace NFCNorth.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IDataRepository _repository;
        
        public PlayersController(IDataRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IActionResult> PlayerDetail(int? playerID)
        {
            // Default to Swift for display purposes
            if (!playerID.HasValue)
                playerID = 57212;

            var player = await _repository.GetPlayerAsync(playerID.Value);
            var info = await _repository.GetLionInfoAsync(playerID.Value);
            var passing = await _repository.GetPlayerPassingStatsAsync(playerID.Value);
            var rushing = await _repository.GetPlayerRushingStatsAsync(playerID.Value);
            var receiving = await _repository.GetPlayerReceivingStatsAsync(playerID.Value);

            var vm = new PlayerDetailViewModel
            {
                FullName = player.FullName,
                Team = player.TeamName,
                HeadshotLocation = player.NFLHeadshotSrc,
                PassingStats = passing,
                PlayerInfo = info,
                ReceivingStats = receiving,
                RushingStats = rushing
            };

            return View(vm);
        }

        public IActionResult PlayerList()
        {
            return View();
        }

        public async Task<IActionResult> PlayerGrid()
        {
            return new OkObjectResult(await _repository.GetPlayerListAsync());
        }
    }
}