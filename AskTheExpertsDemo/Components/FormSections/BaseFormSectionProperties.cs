using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;

/// <summary>
/// Documentation Link:
/// https://docs.xperience.io/developing-websites/form-builder-development/developing-custom-form-layouts
/// </summary>
namespace AskTheExpertsDemo.Models
{
    public class BaseFormSectionProperties : IFormSectionProperties
    {
        /// <summary>
        /// Form section title
        /// </summary>
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 0, Label = "Section Title", Tooltip = "Text at the top of a section")]
        public string SectionTitle { get; set; }

        /// <summary>
        /// Form section text
        /// </summary>
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 1, Label = "Section sub text", Tooltip = "Text after the title")]
        public string SectionSubText { get; set; }

        /// <summary>
        /// Form section text
        /// </summary>
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 2, Label = "Post section text", Tooltip = "Text after the section")]
        public string SectionPostText { get; set; }
    }
}
