using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using UnitTestProjectMs.Utils;

namespace UnitTestProjectMs.PageObjects
{
    public class BbcPage : CorePage
    {

        [FindsBy(How = How.XPath, Using = @"(//a[text() = 'News'])[1]")]
        protected IWebElement newsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = @"(//a[text() = 'Sport'])[1]")]
        protected IWebElement sportBtn { get; set; }



        public void Invoke()
        {

            Driver.Navigate().GoToUrl(@"https://www.bbc.com");
            Driver.Manage().Window.Maximize();
        }

        public void ClickSportBtn()
        {
            Wait.UntilVisible(sportBtn,2000).Click();
        }
        
        public void ClickNewsBtn()
        {
           Wait.UntilVisible(newsBtn, 2000).Click();
        }
        
            
        
    }

    
}
