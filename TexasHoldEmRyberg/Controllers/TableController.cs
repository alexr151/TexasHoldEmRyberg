using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TexasHoldEmRyberg.Models;

namespace TexasHoldEmRyberg.Controllers
{
    public class TableController : Controller
    {

        private PokerContext context;

        public TableController(PokerContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Table()
        {
            CurrentHand cH = new();
            List<int> ids = CurrentHand.createTableIds();

            for (int i = 1; i < 8; i++)
            {
                Table table = new Table();
                table.CardId = ids[i-1];
                table.Card = context.Cards.Find(ids[i - 1]);
                context.Tables.Add(table);
            }

            context.SaveChanges();


            Card back = context.Cards.Find(53);
            List<Card> tables = new List<Card>
            {
                back,
                back,
                back,
                back,
                back
            };

            ViewBag.Table = tables;

            List<Card> hand = new List<Card>
            {
                back,
                back
            };

            ViewBag.Hand = hand;

            return View();
        }

        [HttpGet]
        public IActionResult PreFlop()
        {
            Card hand1, hand2, back;
            Table hand1id, hand2id;

            List<Table> tableList = context.Tables.OrderBy(t => t.TableId).ToList();


            back = context.Cards.Find(53);

            ViewBag.Flop1 = back;
            ViewBag.Flop2 = back;
            ViewBag.Flop3 = back;
            ViewBag.Turn = back;
            ViewBag.River = back;

            hand1 = context.Cards.Find(hand1id.CardId);
            hand2 = context.Cards.Find(hand2id.CardId);

            ViewBag.Hand1 = hand1;
            ViewBag.Hand2 = hand2;


            return View();
        }

        [HttpGet]
        public IActionResult Flop()
        {
            Card flop1, flop2, flop3, hand1, hand2, back;
            Table flop1id, flop2id, flop3id, hand1id, hand2id;
            back = context.Cards.Find(53);


            flop1id = context.Tables.Find(3);
            flop2id = context.Tables.Find(4);
            flop3id = context.Tables.Find(5);
            hand1id = context.Tables.Find(1);
            hand2id = context.Tables.Find(2);

            flop1 = context.Cards.Find(flop1id.CardId);
            flop2 = context.Cards.Find(flop2id.CardId);
            flop3 = context.Cards.Find(flop3id.CardId);

            ViewBag.Flop1 = flop1;
            ViewBag.Flop2 = flop2;
            ViewBag.Flop3 = flop3;
            ViewBag.Turn = back;
            ViewBag.River = back;

            hand1 = context.Cards.Find(hand1id.CardId);
            hand2 = context.Cards.Find(hand2id.CardId);

            ViewBag.Hand1 = hand1;
            ViewBag.Hand2 = hand2;


            return View();
        }

        [HttpGet]
        public IActionResult Turn()
        {
            Card flop1, flop2, flop3, turn, hand1, hand2, back;
            Table flop1id, flop2id, flop3id, turnid, hand1id, hand2id;
            back = context.Cards.Find(53);


            flop1id = context.Tables.Find(3);
            flop2id = context.Tables.Find(4);
            flop3id = context.Tables.Find(5);
            turnid = context.Tables.Find(6);
            hand1id = context.Tables.Find(1);
            hand2id = context.Tables.Find(2);

            flop1 = context.Cards.Find(flop1id.CardId);
            flop2 = context.Cards.Find(flop2id.CardId);
            flop3 = context.Cards.Find(flop3id.CardId);
            turn = context.Cards.Find(turnid.CardId);

            ViewBag.Flop1 = flop1;
            ViewBag.Flop2 = flop2;
            ViewBag.Flop3 = flop3;
            ViewBag.Turn = turn;
            ViewBag.River = back;

            hand1 = context.Cards.Find(hand1id.CardId);
            hand2 = context.Cards.Find(hand2id.CardId);

            ViewBag.Hand1 = hand1;
            ViewBag.Hand2 = hand2;


            return View();

        }

        [HttpGet]
        public IActionResult River()
        {
            Card flop1, flop2, flop3, turn, hand1, hand2, river;
            Table flop1id, flop2id, flop3id, turnid, hand1id, hand2id, riverid;

            flop1id = context.Tables.Find(3);
            flop2id = context.Tables.Find(4);
            flop3id = context.Tables.Find(5);
            turnid = context.Tables.Find(6);
            riverid = context.Tables.Find(7);
            hand1id = context.Tables.Find(1);
            hand2id = context.Tables.Find(2);

            flop1 = context.Cards.Find(flop1id.CardId);
            flop2 = context.Cards.Find(flop2id.CardId);
            flop3 = context.Cards.Find(flop3id.CardId);
            turn = context.Cards.Find(turnid.CardId);
            river = context.Cards.Find(riverid.CardId);

            ViewBag.Flop1 = flop1;
            ViewBag.Flop2 = flop2;
            ViewBag.Flop3 = flop3;
            ViewBag.Turn = turn;
            ViewBag.River = river;

            hand1 = context.Cards.Find(hand1id.CardId);
            hand2 = context.Cards.Find(hand2id.CardId);

            ViewBag.Hand1 = hand1;
            ViewBag.Hand2 = hand2;


            return View();
        }


        [HttpGet]
        public IActionResult Done()
        {
            for (int i = 1; i < 8; i++)
            {
                var table = context.Tables.Find(i);
                context.Tables.Remove(table);
            }

            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
