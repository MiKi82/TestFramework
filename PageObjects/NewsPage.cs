using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using UnitTestProjectMs.Utils;

namespace UnitTestProjectMs.PageObjects
{

    public class NewsPage : CorePage
    {
        // =================== Page Elements =======================
        
        [FindsBy(How = How.XPath, Using = @"(//h3)[1]")] //div[@data-entityid = "container-top-stories#1"]//h3
        protected IWebElement mainHeadLine { get; set; } 

        [FindsBy(How = How.XPath, Using = @"(//h3)[3]")] //div[@data-entityid = "container-top-stories#2"]//h3
        protected IWebElement headLine1 { get; set; } 

        [FindsBy(How = How.XPath, Using = @"(//h3)[4]")]  //div[@data-entityid = "container-top-stories#3"]//h3
        protected IWebElement headLine2 { get; set; } 

        [FindsBy(How = How.XPath, Using = @"(//h3)[5]")]  //div[@data-entityid = "container-top-stories#4"]//h3
        protected IWebElement headLine3 { get; set; } 

        [FindsBy(How = How.XPath, Using = @"(//h3)[6]")]  //div[@data-entityid = "container-top-stories#5"]//h3
        protected IWebElement headLine4 { get; set; } 

        [FindsBy(How = How.XPath, Using = @"(//h3)[7]")]  //div[@data-entityid = "container-top-stories#6"]//h3
        protected IWebElement headLine5 { get; set; }

        [FindsBy(How = How.XPath, Using = @"//div[@data-entityid = 'container-top-stories#1']/descendant::span[5]")]  
        protected IWebElement categorySpan { get; set; }

        [FindsBy(How = How.XPath, Using = @"//input[@id = 'orb-search-q']")]
        protected IWebElement searchBar { get; set; }

        [FindsBy(How = How.XPath, Using = @"//button[@id = 'orb-search-button']")]
        protected IWebElement searchBtn { get; set; }
        
        public void Invoke()
        {

            Driver.Navigate().GoToUrl(@"https://www.bbc.com/news");
            Driver.Manage().Window.Maximize();
        }


        public string GetRealResultHeadline()
        {

            return Wait.UntilVisible( mainHeadLine,2000).Text;
           
        }

        public List<string> GetRealResultsHeadersList()
        {
            List<string> result = new List<string>();
            result.Add(headLine1.Text);
            result.Add(headLine2.Text);
            result.Add(headLine3.Text);
            result.Add(headLine4.Text);
            result.Add(headLine5.Text);
            return result;
        }

        public string GetCategoryText() => Wait.UntilVisible(categorySpan,2000).Text;
        
        public void SearchResult()
        {
            Wait.UntilVisible( searchBar,2000).SendKeys(GetCategoryText());
            Wait.UntilVisible( searchBtn,2000).Click();

        }
        
         
    }


}
