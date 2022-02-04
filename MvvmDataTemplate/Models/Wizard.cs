using System;
using MvvmDataTemplate.TemplateModels;

namespace MvvmDataTemplate.Models
{
    public class Wizard
    {
        public Wizard(WizardPage page)
        {
            Page = page;
            Model = GetModel();
        }

        public WizardPage Page { get; set; }

        public BaseTemplateModel Model { get; set; }

        private BaseTemplateModel GetModel()
        {
            switch(Page)
            {
                case WizardPage.STEP_ONE:
                    return new StepOneTemplateModel();
                case WizardPage.STEP_TWO:
                    return new StepTwoTemplateModel();
                case WizardPage.STEP_THREE:
                    return new StepThreeTemplateModel();
                default:
                    return new BaseTemplateModel();
            }
        }
    }

    public enum WizardPage
    {
        STEP_ONE,
        STEP_TWO,
        STEP_THREE
    }
}
