using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskTheExpertsDemo.Models.Widgets.Rates
{
    public interface IRatesRepo : IRepo
    {
        IEnumerable<RateViewModel> GetRateModels(string orderBy = "");
    }
}
