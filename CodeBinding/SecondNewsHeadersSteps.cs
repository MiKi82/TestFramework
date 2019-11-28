using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTestProjectMs.Utils;
using UnitTestProjectMs.BLL;

namespace UnitTestProjectMs.CodeBinding
{
    [Binding]
    public class SecondNewsHeadersSteps
    {
        private readonly Bll bll = new Bll();
        private List<string> RealResults { get; set; }



        [Given(@"That User on the BBC News web page")]
        public void GivenThatUserOnTheBBCNewsWebPage()
        {
      
            bll.UserOnBbcNewsPage();
        }

        [When(@"User check if all second articles are present")]
        public void WhenUserCheckIfAllSecondArticlesArePresent()
        {
           
            RealResults = bll.CheckingSecondHeadersArticleArePresent();
            CollectionAssert.AllItemsAreNotNull(RealResults);
        }
        

        [Then(@"User sees all BBC News second headers")]
        public void ThenUserSeesAllBBCNewsSecondHeaders(Table table)
        {
            List<string> expectedResult = TableExtentions.TabaleToString(table);
            CollectionAssert.AreEqual(expectedResult, RealResults);
        }



    }
}

