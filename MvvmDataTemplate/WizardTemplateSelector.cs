using System;
using MvvmDataTemplate.Models;
using MvvmDataTemplate.Templates;
using Xamarin.Forms;

namespace MvvmDataTemplate
{
    public class WizardTemplateSelector : DataTemplateSelector
    {
        private DataTemplate StepOneTemplate = new StepOneTemplate();

        private DataTemplate StepTwoTemplate = new StepTwoTemplate();

        private DataTemplate StepThreeTemplate = new StepThreeTemplate();

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (((Wizard)item).Page)
            {
                case WizardPage.STEP_ONE:
                    return StepOneTemplate;
                case WizardPage.STEP_TWO:
                    return StepTwoTemplate;
                case WizardPage.STEP_THREE:
                    return StepThreeTemplate;
                default:
                    return new DataTemplate();
            }
        }
    }
}
