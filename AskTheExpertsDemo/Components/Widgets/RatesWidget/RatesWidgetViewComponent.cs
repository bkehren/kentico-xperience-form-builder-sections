using AskTheExpertsDemo.Components.Widgets.RatesWidget;
using AskTheExpertsDemo.Models.Widgets.Rates;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly: RegisterWidget(
    "ate.rateswidget",
    typeof(RatesWidgetViewComponent),
    "Rates listing",
    typeof(RatesWidgetProperties),
    Description = "Displays listing of custom table rates",
    IconClass = "icon-photo")]

namespace AskTheExpertsDemo.Components.Widgets.RatesWidget
{
    public class RatesWidgetViewComponent : ViewComponent
    {
        private readonly IRatesRepo ratesRepo;

        public RatesWidgetViewComponent(IRatesRepo ratesRepo)
        {
            this.ratesRepo = ratesRepo;
        }

        public ViewViewComponentResult Invoke(ComponentViewModel<RatesWidgetProperties> viewModel)
        {
            var rates = new List<RateViewModel>();
            string orderBy = viewModel.Properties.OrderBy;

            rates = ratesRepo.GetRateModels(orderBy).ToList();

            var model = RatesWidgetViewModel.GetViewModel(rates);

            return View("~/Components/Widgets/RatesWidget/_RatesWidget.cshtml", model);
        }
    }
}
