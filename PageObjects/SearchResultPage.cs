using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using UnitTestProjectMs.Utils;

namespace UnitTestProjectMs.PageObjects
{
    public class SearchResultPage : CorePage
    {
        [FindsBy(How = How.XPath, Using = @"//li[@data-result-number= '1']//h1/a")]
        protected IWebElement firstResultText { get; set; }

        
        public string FirstResult() => Wait.UntilVisible(firstResultText, 2000).Text;
        
    }
    
}
