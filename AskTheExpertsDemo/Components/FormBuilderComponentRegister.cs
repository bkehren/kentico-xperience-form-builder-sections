using AskTheExpertsDemo;
using Kentico.Forms.Web.Mvc;
using AskTheExpertsDemo.Models.FormComponents;
using AskTheExpertsDemo.Models;

// Form Components
[assembly: RegisterFormComponent(ComponentIdentifiers.FORM_COMPONENT_HEADLINE_INPUT,
    typeof(HeadlineInputComponent),
    "Headline Text Input",
    Description = "Allows a user to enter a section title",
    IconClass = "icon-l-header-text",
    ViewName = ComponentIdentifiers.FORM_COMPONENT_HEADLINE_VIEW)]

// Form Sections
[assembly: RegisterFormSection(ComponentIdentifiers.ONE_COLUMN_FORM_SECTION,
    "One Column Section",
    customViewName: ComponentIdentifiers.ONE_COLUMN_FORM_SECTION_VIEW,
    PropertiesType = typeof(OneColumnFormSectionProperties),
    Description = "Organizes fields into 1 full-width column.",
    IconClass = "icon-l-cols-1")]

[assembly: RegisterFormSection(ComponentIdentifiers.TWO_COLUMN_FORM_SECTION,
    "Two Column Section",
    customViewName: ComponentIdentifiers.TWO_COLUMN_FORM_SECTION_VIEW,
    PropertiesType = typeof(TwoColumnFormSectionProperties),
    Description = "Organizes fields into 2 equal-width columns side-by-side.",
    IconClass = "icon-l-cols-2")]

[assembly: RegisterFormSection(ComponentIdentifiers.THREE_COLUMN_FORM_SECTION,
    "Three Column Section",
    customViewName: ComponentIdentifiers.THREE_COLUMN_FORM_SECTION_VIEW,
    PropertiesType = typeof(ThreeColumnFormSectionProperties),
    Description = "Organizes fields into 3 equal-width columns side-by-side.",
    IconClass = "icon-l-cols-3")]

[assembly: RegisterFormSection(ComponentIdentifiers.FOUR_COLUMN_FORM_SECTION,
    "Four Column Section",
    customViewName: ComponentIdentifiers.FOUR_COLUMN_FORM_SECTION_VIEW,
    PropertiesType = typeof(FourColumnFormSectionProperties),
    Description = "Organizes fields into 4 equal-width columns side-by-side.",
    IconClass = "icon-l-cols-4")]