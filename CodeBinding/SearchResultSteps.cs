using TechTalk.SpecFlow;
using UnitTestProjectMs.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectMs.BLL;


namespace UnitTestProjectMs
{

    [Binding]
    public class SearchResultSteps
    {
        private readonly Bll bll = new Bll();

        [When(@"User copys text of the link which located under the headline article")]
        public void WhenUserCopysTextOfTheLinkWhichLocatedUnderTheHeadlineArticle()
        {
            bll.CopyTextOfTheLinkUnderTheHeadlineArticle();
        }
        
        [When(@"User inserts this text to the search bar")]
        public void WhenUserInsertsThisTextToTheSearchBar()
        {
            bll.PasteTextOfTheLinkUnderTheHeadlineArticle();
        }
        
        [Then(@"User verified that '(.*)' matching to the first search query result")]
        public void ThenUserVerifiedThatMatchingToTheFirstSearchQueryResult(string result)
        {
            var searchResultPG = new SearchResultPage();
            string firstResult = searchResultPG.FirstResult();
            Assert.AreEqual(result, firstResult);
        }
    }
}
