using Assignment7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment7.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player() { PId = 1, PName = "Dhoni", PCountry = "India", PType = "All-rounder" },
            new Player() { PId = 2, PName = "Rahul", PCountry = "Australia", PType = "Wicketkeeper" },
            new Player() { PId = 3, PName = "Virat", PCountry = "India", PType = "Batsman" },
        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Player player)
        {
            players.Add(player);
            return RedirectToAction("Index");
        }
    }
}
