using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TxDOTTest
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I see the application opened")]
        public void GivenISeeTheApplicationOpened()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I enter the Username and Password")]
        public void ThenIEnterTheUsernameAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I click Login button")]
        public void ThenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
