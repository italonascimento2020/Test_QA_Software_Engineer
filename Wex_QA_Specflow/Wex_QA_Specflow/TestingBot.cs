using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Wex_QA_Specflow
{
    [Binding]
    public sealed class TestingBot
    {
        private TestingBotDriver tbDriver;
        private string[] tags;

        [BeforeScenario]
        [Obsolete]
        public void BeforeScenario()
        {
            tbDriver = new TestingBotDriver(ScenarioContext.Current);
            ScenarioContext.Current["tbDriver"] = tbDriver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //tbDriver.Cleanup();
        }
    }
}
