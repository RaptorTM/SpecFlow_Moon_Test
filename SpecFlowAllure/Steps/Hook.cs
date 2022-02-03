using Allure.Commons;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowAllure.Steps
{
    [Binding]
    class Hook
    {
        private AllureLifecycle _allureLifecycle;
        private readonly ScenarioContext _scenarioContext;
        private static string? fullname;

        public Hook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _allureLifecycle = AllureLifecycle.Instance;
        }

        [AfterScenario]
        public void RenameTestCaseFullname()
        {
            Console.WriteLine(TestContext.CurrentContext.Test.FullName);
            _scenarioContext.TryGetValue(out TestResult testresult);
            _allureLifecycle.UpdateTestCase(testresult.uuid, tc =>
            {
                tc.fullName = TestContext.CurrentContext.Test.FullName;
            });
        }
    }
}
