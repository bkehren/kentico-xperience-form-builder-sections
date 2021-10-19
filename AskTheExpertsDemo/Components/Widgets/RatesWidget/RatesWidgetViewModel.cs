using System;
using System.Collections.Generic;
using AskTheExpertsDemo.Models.Widgets.Rates;

namespace AskTheExpertsDemo.Components.Widgets.RatesWidget
{
    public class RatesWidgetViewModel
    {
        public IEnumerable<RateViewModel> Rates { get; set; }

        public static RatesWidgetViewModel GetViewModel(List<RateViewModel> rates)
        {
            return new RatesWidgetViewModel
            {
                Rates = rates
            };
        }
    }
}
