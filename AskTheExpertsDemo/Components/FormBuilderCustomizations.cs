using Kentico.Forms.Web.Mvc;
using Kentico.Forms.Web.Mvc.Widgets;

namespace AskTheExpertsDemo
{
    public class FormBuilderCustomizations
    {
        public static void SetGlobalRenderingConfigurations()
        {
            //// Modifies the default FormFieldRenderingConfiguration for the 'Form' widget
            //// Specifying a new FormFieldRenderingConfiguration instance completely replaces the default Kentico configuration
            //FormFieldRenderingConfiguration.Widget.RootConfiguration =
            //     new ElementRenderingConfiguration
            //     {
            //         ElementName = "div",
            //         HtmlAttributes = { { "class", "form-field" } }
            //     };

            //FormFieldRenderingConfiguration.Widget.ExplanationTextWrapperConfiguration =
            //     new ElementRenderingConfiguration
            //     {
            //         ElementName = "div",
            //         HtmlAttributes = { { "class", "explanation-text" } }
            //     };

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

                //// Elements wrapping the Form element
                //FormWrapperConfiguration = new FormWrapperRenderingConfiguration
                //{
                //    ElementName = "div",
                //    HtmlAttributes = { { "class", "form-widget-form" } },
                //    // Adds an additional div element wrapper
                //    ChildConfiguration = new ElementRenderingConfiguration
                //    {
                //        ElementName = "div"
                //    }
                //}
            };
        }
    }
}
