using Kentico.Forms.Web.Mvc;

/// <summary>
/// Documentation Link:
/// https://docs.xperience.io/developing-websites/form-builder-development/developing-form-components
/// </summary>
namespace AskTheExpertsDemo.Models.FormComponents
{
    public class HeadlineInputComponent : FormComponent<HeadlineInputComponentProperties, string>
    {
        public const string IDENTIFIER = "HeadlineInputComponent";
        // Disables automatic server-side evaluation for the component
        public override bool CustomAutopostHandling => true;

        [BindableProperty]
        public string Value { get; set; } = "";

        public override string GetValue()
        {
            return Value;
        }

        public override void SetValue(string value)
        {
            Value = value;
        }
    }
}
