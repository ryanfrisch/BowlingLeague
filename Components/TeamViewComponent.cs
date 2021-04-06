using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// set up team viewcomponent
namespace BowlingLeague.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        public TeamViewComponent (BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {
            // assign selectedteam through the viewbag so we can access and display it
            ViewBag.SelectedTeam = RouteData?.Values["team"];
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
