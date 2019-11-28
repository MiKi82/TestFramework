using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using UnitTestProjectMs.Utils;

namespace UnitTestProjectMs.PageObjects

{

    public class SportPage : CorePage
    {
        [FindsBy(How = How.XPath, Using = @"(//button[@aria-labelledby = 'sp-c-filter-nav__label'])[2]")]  
        protected IWebElement moreBtn { get; set; }

        [FindsBy(How = How.XPath, Using = @"(//div[@id = 'sp-c-filter-nav__expanded-block']//button[text() = 'Scottish Prem'])[2]")]
        protected IWebElement scotlandPrenBtn { get; set; }

        [FindsBy(How = How.XPath, Using = @"(//a[@href = '/sport/football/scottish-premiership/scores-fixtures'])[2]")]
        protected IWebElement viewAllscotlandPremBtn { get; set; }

        [FindsBy(How = How.XPath, Using = @"//span[text() = 'RESULTS']/parent::a")]
        protected IWebElement resultsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = @"(//div[@class ='qa-match-block']/descendant::abbr/following-sibling::span)[1]")]
        protected IWebElement teamOnResultPg { get; set; }


        [FindsBy(How = How.XPath, Using = @"(//span[@class ='sp-c-fixture__block']/span)[1]")]
        protected IWebElement scoreOnResultPg { get; set; }



        public void Invoke()
        {

            Driver.Navigate().GoToUrl(@"https://www.bbc.com/sport");
            Driver.Manage().Window.Maximize();
        }   
        
        

        public void ClickMoreBtnOnSportPg() => Wait.UntilVisible(moreBtn,10000).Click();

        public void ClickScotlandLeagueBtnOnSportPg() => Wait.UntilVisible(scotlandPrenBtn,10000).Click();
        
        public void ClickScotlandPrenAllMatchBtnOnSportPg() => Wait.UntilVisible(viewAllscotlandPremBtn,10000).Click();
        
        public void ClickResultsBtnOnSportPg() => Wait.UntilVisible(resultsBtn,10000).Click();
        
       
    }
    
    
}
