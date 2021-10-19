using Kentico.PageBuilder.Web.Mvc;
using Kentico.Forms.Web.Mvc;

namespace AskTheExpertsDemo.Components.Widgets.RatesWidget
{
    public class RatesWidgetProperties : IWidgetProperties
    {
        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Order by", Order = 0)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "SampleRate1 ASC;Rate ASC\r\nSampleRate1 DESC;Rate DESC")]
        public string OrderBy { get; set; } = "SampleRate1 ASC";
    }
}
