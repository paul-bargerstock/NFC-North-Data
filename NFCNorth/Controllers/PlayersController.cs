using DataService.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult PlayerDetail()
        {
            return View();
        }

        public IActionResult PlayerList()
        {
            return View();
        }

        public async Task<IActionResult> PlayerGrid()
        {
            return new OkObjectResult(await _repository.GetPlayerListAsync());
        }

        public IActionResult QBComparison()
        {
            return PartialView("_QBComparison");
        }

        public IActionResult LionsInfo(int playerID)
        {
            return PartialView("_LionsInfo");
        }
    }
}