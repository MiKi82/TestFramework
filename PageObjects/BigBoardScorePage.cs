using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using SeleniumExtras.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using UnitTestProjectMs.Utils;

namespace UnitTestProjectMs.PageObjects
{
    public class BigBoardScorePage : CorePage
    {
        [FindsBy(How = How.XPath, Using = @"//div[@class = 'match-overview-header match-overview-header--football']/descendant::span[@class = 'fixture__block']/span")]
        protected IList<IWebElement> shownScoreResulLists { get; set; }

        [FindsBy(How = How.XPath, Using = @"//a[@data-istats-container='results_link']")]
        protected IWebElement backToResults { get; set; }

        public string[] GetResultFromTheScreen()
        {
            
            List<string> results = shownScoreResulLists.Select(s => s.Text).ToList();
            string[] myArrScore = results.ToArray();
            return myArrScore;
        }

        public void ClickOnBackToResultsLink()
        {
            Wait.UntilVisible(backToResults, 2000).Click();
        }
    }
}
