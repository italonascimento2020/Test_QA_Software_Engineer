using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Wex_QA_Specflow
{
    public class TestingBotDriver
    {
        private IWebDriver driver;
        private string profile;
        private string environment;
        private ScenarioContext context;

        public TestingBotDriver(ScenarioContext context)
        {
            this.context = context;
        }

        [Obsolete]
        public IWebDriver Init(string profile, string environment)
        {
            NameValueCollection caps = ConfigurationManager.GetSection("capabilities/" + profile) as NameValueCollection;
            NameValueCollection settings = ConfigurationManager.GetSection("environments/" + environment) as NameValueCollection;

            DesiredCapabilities capability = new DesiredCapabilities();

            foreach (string keys in caps.AllKeys)
            {
                capability.SetCapability(keys, caps[keys]);
            }

            foreach (string keys in settings.AllKeys)
            {
                capability.SetCapability(keys, settings[keys]);
            }

            String key = Environment.GetEnvironmentVariable("TB_KEY");
            if (key == null)
            {
                key = ConfigurationManager.AppSettings.Get("key");
            }

            String secret = Environment.GetEnvironmentVariable("TB_SECRET");
            if (secret == null)
            {
                secret = ConfigurationManager.AppSettings.Get("secret");
            }

            capability.SetCapability("key", key);
            capability.SetCapability("secret", secret);

            driver = new RemoteWebDriver(new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "/wd/hub/"), capability);
            return driver;
        }

        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
