using AskTheExpertsDemo.Controllers;
using AskTheExpertsDemo.Models;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.ATED;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Page.CLASS_NAME, typeof(PageController))]

namespace AskTheExpertsDemo.Controllers
{
    public class PageController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;

        public PageController(IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public async Task<ActionResult> Index(CancellationToken cancellationToken)
        {
            var page = pageDataContextRetriever.Retrieve<TreeNode>().Page;

            var model = new PageViewModel
            {
                PageData = page
            };

            return View(model);
        }
    }
}
