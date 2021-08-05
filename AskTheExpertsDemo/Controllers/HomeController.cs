using AskTheExpertsDemo.Controllers;
using AskTheExpertsDemo.Models;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.ATED;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController))]

namespace AskTheExpertsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;

        public HomeController(IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public async Task<ActionResult> Index(CancellationToken cancellationToken)
        {
            var page = pageDataContextRetriever.Retrieve<TreeNode>().Page;

            var model = new HomeViewModel
            {
                PageData = page
            };

            return View(model);
        }
    }
}
