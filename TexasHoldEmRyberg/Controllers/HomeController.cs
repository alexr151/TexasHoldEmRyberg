using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TexasHoldEmRyberg.Models;

namespace TexasHoldEmRyberg.Controllers
{
    public class HomeController : Controller
    {
        private PokerContext context;

        public HomeController(PokerContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var cards = context.Cards.OrderBy(c => c.CardId).ToList();


            return View(cards);
        }

        public IActionResult NewHand()
        {
            return RedirectToAction("NewHand", "Test");
        }
    }
}
