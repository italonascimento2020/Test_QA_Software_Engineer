using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;

namespace Wex_QA_Specflow.Steps
{
    public class DadosTable
    {
        public decimal valor { get; set; }

        public string livro { get; set; }
    }

    [Binding]
    public class AmazonSteps
    {
        public IWebDriver driver = new ChromeDriver();
        public string Livro;

        [Given(@"I navigate to “www\.amazon\.com”\.")]
        public void GivenINavigateToWww_Amazon_Com_()
        {  
            driver.Navigate().GoToUrl("http:www.amazon.com");
        }
        
        [When(@"I select the option “Books” in the dropdown next to the search text input criteria\.")]
        public void WhenISelectTheOptionBooksInTheDropdownNextToTheSearchTextInputCriteria_()
        { 
            IWebElement element = driver.FindElement(By.Id("searchDropdownBox"));

            SelectElement dp = new SelectElement(element);

            dp.SelectByText("Books");

             

            //element.SendKeys("Book");
        }

        [Then(@"I search for “Test automation”\.")]
        public void ThenISearchForTestAutomation_()
        {
            IWebElement element = driver.FindElement(By.Id("twotabsearchtextbox"));

            element.SendKeys("Test automation");

            element = driver.FindElement(By.ClassName("nav-input"));

            element.Click();

        } 

        [Then(@"I select the cheapest book of the page without using any sorting method available\.")]
        public void ThenISelectTheCheapestBookOfThePageWithoutUsingAnySortingMethodAvailable_()
        {
            IWebElement element = driver.FindElement(By.Id("s-result-sort-select"));

            IList<IWebElement> table = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[4]/div[1]/div"));
            
            DadosTable dados;
            List<DadosTable> listaDados = new List<DadosTable>();

            foreach (var item in table)
            {
                if (!String.IsNullOrEmpty(item.Text))
                {
                    dados = new DadosTable();

                    dados.valor = Convert.ToDecimal(item.FindElement(By.ClassName("a-price")).Text.Replace("$", "").Replace("\r\n", "."));
                    dados.livro = item.FindElement(By.ClassName("a-text-normal")).Text;

                    listaDados.Add(dados);
                     
                } 
            }

            var itemClick = listaDados.ToList().OrderBy(x => x.valor).First();
             
            foreach (var item in table)
            {
                if (item.Text.Contains(itemClick.livro))
                {
                    element = item.FindElement(By.ClassName("a-text-normal")); 
                }
            }

            this.Livro = itemClick.livro;

            element.Click(); 
            //ScenarioContext.Current.Pending();
        }

        [When(@"I reach the detailed book page, I check if the name in the header is the same name of the book that I select previously\.")]
        public void WhenIReachTheDetailedBookPageICheckIfTheNameInTheHeaderIsTheSameNameOfTheBookThatISelectPreviously_()
        {
            try
            {
                if (!driver.FindElement(By.Id("ebooksProductTitle")).Text.Equals(this.Livro))
                {
                    throw new Exception("Isn't same book!"); 
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            
        }
        
    }
}
