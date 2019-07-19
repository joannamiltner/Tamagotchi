using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {

        public static Grumpson grumpson;

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

    [HttpPost("getname")]
    public IActionResult GetName(string name)
    {
        grumpson = new Grumpson(name);
        return Redirect("/game");
    }

    [HttpGet("game")]
    public IActionResult Game()
    {
        return View(grumpson);
    }


    [HttpGet("feed")]
    public IActionResult Feed()
    {
        grumpson.Feed();
        grumpson.Check();
        return Redirect("/game");
    }

    [HttpGet("rest")]
    public IActionResult Rest()
    {
        grumpson.Sleep();
        grumpson.Check();
        return Redirect("/game");
    }

        [HttpGet("pet")]
    public IActionResult Pet()
    {
        grumpson.Pet();
        grumpson.Check();
        return Redirect("/game");
    }

        [HttpGet("toy")]
    public IActionResult Toy()
    {
        grumpson.Play();
        grumpson.Check();
        return Redirect("/game");
    }

    }
}
