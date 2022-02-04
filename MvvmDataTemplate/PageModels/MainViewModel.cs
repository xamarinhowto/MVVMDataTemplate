using System;
using System.Collections.Generic;
using MvvmDataTemplate.Models;

namespace MvvmDataTemplate
{
    public class MainPageModel
    {
        public MainPageModel()
        {
            var wizard = new List<Wizard>();
            wizard.Add(new Wizard(WizardPage.STEP_ONE));
            wizard.Add(new Wizard(WizardPage.STEP_TWO));
            wizard.Add(new Wizard(WizardPage.STEP_THREE));
            Wizard = new List<Wizard>(wizard);
        }

        public List<Wizard> Wizard { get; set; }
    }
}
