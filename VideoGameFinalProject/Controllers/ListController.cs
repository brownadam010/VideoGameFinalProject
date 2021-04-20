using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameFinalProject.Models;

namespace VideoGameFinalProject.Controllers
{
    public class ListController : Controller
    {
        private GameContext context { get; set; }

        public ListController(GameContext ctx)
        {
            context = ctx;
        }
        public IActionResult TopGames()
        {
            var games = context.Games
                .OrderBy(m => m.GameName)
                .ToList();
            return View(games);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Games = context.Games.OrderBy(g => g.GameName).ToList();
            return View("Edit", new Game());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Games = context.Games.OrderBy(g => g.GameName).ToList();
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.GameId == 0)
                    context.Games.Add(game);
                else
                    context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("TopGames", "List");
            }
            else
            {
                ViewBag.Action = (game.GameId == 0) ? "Add" : "Edit";
                ViewBag.Games = context.Games.OrderBy(g => g.GameName).ToList();
                return View(game);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("TopGames", "List");
        }
    }
}
