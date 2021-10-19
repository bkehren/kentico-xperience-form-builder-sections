using CMS.CustomTables;
using CMS.DataEngine;
using System.Collections.Generic;

namespace AskTheExpertsDemo.Models.Widgets.Rates
{
    public class RatesRepo : IRatesRepo
    {
        public IEnumerable<RateViewModel> GetRateModels(string orderBy = "")
        {
            string customTableClassName = "ate.SampleData";

            List<RateViewModel> rateViewModels = new List<RateViewModel>();

            // Gets the custom table
            DataClassInfo customTable = DataClassInfoProvider.GetDataClassInfo(customTableClassName);
            if (customTable != null)
            {
                // Gets the first custom table record whose value in the 'ItemName' field is equal to "SampleName"
                var items = CustomTableItemProvider.GetItems(customTableClassName)
                    .OrderBy(orderBy);

                foreach (var cti in items)
                {
                    rateViewModels.Add(new RateViewModel(cti));
                }                
            }
            return rateViewModels;
        }
    }
}
