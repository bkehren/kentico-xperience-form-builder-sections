using Kentico.Forms.Web.Mvc;

namespace AskTheExpertsDemo.Models
{
    public class TwoColumnFormSectionProperties : BaseFormSectionProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Column one width", Order = 3, Tooltip = "Must be a value of 1-12. Combined value of both columns cannot exceed 12.")]
        public string ColumnOneWidth { get; set; } = "6";

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Column two width", Order = 4, Tooltip = "Must be a value of 1-12. Combined value of both columns cannot exceed 12.")]
        public string ColumnTwoWidth { get; set; } = "6";
    }
}
