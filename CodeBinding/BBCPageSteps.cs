using TechTalk.SpecFlow;
using UnitTestProjectMs.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectMs.BLL;


namespace UnitTestProjectMs.CodeBinding
{
    [Binding]
    public class BbcPageSteps
    {
        private readonly Bll bll = new Bll();



        [Given(@"That User on the BBC\.com web site")]
        public void GivenThatUserOnTheBBC_ComWebSite()
        {
            bll.UserOnBbcComPage();
        }

        
        [When(@"User proceed to BBC News page")]
        public void WhenUserProceedToBBCNewsPage()
        {
            bll.ClickNewsBtn();
        }


        [Then(@"User can see a BBC News page and '(.*)' news article on page")]
        public void ThenUserCanSeeABBCNewsPageAndNewsArticleOnPage(string news)
        {
            var newsPage = new NewsPage();
            string headlineNews = newsPage.GetRealResultHeadline();
            Assert.AreEqual(news, headlineNews);
        }

    }
}

