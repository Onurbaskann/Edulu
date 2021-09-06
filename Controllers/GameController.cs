using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edulu3.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        [Route("Game/GamePage")]
        public ActionResult GamePage()
        {
            return View();
        }
    }
}