using Kentico.Forms.Web.Mvc;
using Kentico.Forms.Web.Mvc.Widgets;


/// <summary>
/// Documentation link:
/// https://docs.xperience.io/developing-websites/form-builder-development/customizing-the-form-widget#CustomizingtheFormwidget-Settingglobalrenderingconfigurations
/// </summary>
namespace AskTheExpertsDemo
{
    public class FormBuilderCustomizations
    {
        public static void SetGlobalRenderingConfigurations()
        {
            // Wraps input and explanation text
            FormFieldRenderingConfiguration.Widget.EditorWrapperConfiguration =
                new ElementRenderingConfiguration
                {
                    ElementName = string.Empty
                };

            // Wraps input HTML and validation message
            FormFieldRenderingConfiguration.Widget.ComponentWrapperConfiguration =
                new ElementRenderingConfiguration
                {
                    ElementName = string.Empty
                };

            // Sets a new rendering configuration for the 'Form' widget, adding attributes
            // to the form element and the submit button and wrapping the form in two 'div' blocks
            FormWidgetRenderingConfiguration.Default = new FormWidgetRenderingConfiguration
            {
                // Form element HTML attributes
                FormHtmlAttributes = { { "class", "bg-light px-3 py-3 contact-form" } },

                // Submit button HTML attributes
                SubmitButtonHtmlAttributes = { { "class", "btn btn-primary submit-button" } }
            };
        }
    }
}
