using System;
using Microsoft.AspNet.Mvc;
using System.Linq;
using architecture_throwdown.Models;

namespace architecture_throwdown.Controllers
{
	
    public class HomeController : Controller
    {
		//[Route("index")]
		public ActionResult Index()
		{
			var slamText = new string[] {
				"Yo architecture so weak they be losing data at Google",
				"Yo abstractions so leaky they need a diaper.",
				"Yo code so bloated they gave the servers Midol Extra Strength.",
				"Yo code so tightly coupled it should go get a room.",
				"Yo memory footprint so high they gave it a piss test.",
				"Yo codebase so heavy they only let it eat salad.",
				"Yo dependencies so convoluted they call it the Alabama Family.",
				"Yo code is so weird they call your test project Gandalf. None shall pass.",
				"Yo design so astronautical they called NASA for a rescue.",
				"Yo code is so bad even your scaffolding is made of spaghetti.",
				"Yo architecture is so shaky your nickname is Jenga.",
				"Yo code is so bad your co-workers asked you to practice the ZERO responsibility principle."
			};
			var slamViews = slamText.Select(t => new SlamViewModel(t));
			var model = new HomePageViewModel(slamViews);
			return View(model);
		}
    }
}