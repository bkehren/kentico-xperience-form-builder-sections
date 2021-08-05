using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace AskTheExpertsDemo.Models.FormComponents
{
    public class HeadlineInputComponentProperties : FormComponentProperties<string>
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Headline text", DefaultValue = "", Tooltip = "", Order = 1)]
        public string HeadlineText { get; set; } = "";

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Headline CSS class", DefaultValue = "", Tooltip = "", Order = 2)]
        public string HeadlineCssClass { get; set; } = "";

        [DefaultValueEditingComponent(TextInputComponent.IDENTIFIER)]
        public override string DefaultValue { get; set; }

        public HeadlineInputComponentProperties() : base(FieldDataType.Text, 1000) { }
    }
}
