using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TexasHoldEmRyberg.Models;

namespace TexasHoldEmRyberg.Controllers
{
    public class CardController : Controller
    {

        private PokerContext context;

        public CardController(PokerContext ctx) => context = ctx;

        CurrentHand cH = new CurrentHand();
        [HttpGet]
        public IActionResult NewHand()
        {

            Card hand1, hand2;

            hand1 = context.Cards.Find(cH.Hand1);
            hand2 = context.Cards.Find(cH.Hand2);

            

            List<Card> cards = new List<Card>
            {
                hand1,
                hand2
            };

            return View(cards);
        }

        
    }
}
