using Kentico.Forms.Web.Mvc;

namespace AskTheExpertsDemo.Models
{
    public class FourColumnFormSectionProperties : BaseFormSectionProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Column one width", Order = 3, Tooltip = "Must be a value of 1-12. Combined value of all columns cannot exceed 12.")]
        public string ColumnOneWidth { get; set; } = "3";

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Column two width", Order = 4, Tooltip = "Must be a value of 1-12. Combined value of all columns cannot exceed 12.")]
        public string ColumnTwoWidth { get; set; } = "3";

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Column three width", Order = 5, Tooltip = "Must be a value of 1-12. Combined value of all columns cannot exceed 12.")]
        public string ColumnThreeWidth { get; set; } = "3";

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Column four width", Order = 6, Tooltip = "Must be a value of 1-12. Combined value of all columns cannot exceed 12.")]
        public string ColumnFourWidth { get; set; } = "3";
    }
}
