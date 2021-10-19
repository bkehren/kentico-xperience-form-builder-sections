using CMS.CustomTables;
using CMS.CustomTables.Types.ATE;

namespace AskTheExpertsDemo.Models.Widgets.Rates
{
    public class RateViewModel
    {
        public RateViewModel() { }

        public RateViewModel(CustomTableItem customTableItem)
        {
            RateAmount = customTableItem.GetIntegerValue(nameof(SampleDataItem.SampleRate1), -1);
            RateDescription = customTableItem.GetStringValue(nameof(SampleDataItem.SampleDescription), "");
            RateTitle = customTableItem.GetStringValue(nameof(SampleDataItem.SampleTitle), "");
        }

        public string RateTitle { get; set; }
        public string RateDescription { get; set; }
        public int RateAmount { get; set; }

    }
}
