using TechTalk.SpecFlow;
using UnitTestProjectMs.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using UnitTestProjectMs.BLL;

namespace UnitTestProjectMs.CodeBinding
{
    [Binding]
    public class SportPageSteps
    {
        private string[] actualScoreMachTable { get; set; }
        private readonly Bll bll = new Bll();


        [Given(@"That User on the BBC com web page")]
        public void GivenThatUserOnTheBBCComWebPage()
        {
            bll.UserOnBbcComPage();
        }

        [Given(@"That User proceed on the BBC Sport page")]
        public void GivenThatUserProceedOnTheBBCSportPage()
        {
            bll.ProceedToSportPage();
        }


        [When(@"User goes on More")]
        public void WhenUserGoesOnMore()
        {
            bll.clickOnMoreBtn();
        }


        [When(@"User proceed to Scottish Prem")]
        public void WhenUserProceedToScottishPrem()
        {
            bll.ProceedToScottishLeague();
        }


        [When(@"User goes on “View all Scottish Premiership“")]
        public void WhenUserGoesOnViewAllScottishPremiership()
        {
            bll.SeeAllMatchesScottishLeague();
        }


        [When(@"User proceed to a Month Result")]
        public void WhenUserProceedToAMonthResult()
        {
            bll.ProceedToResults();
        }

        [StepArgumentTransformation]
        public string[] TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        [Then(@"User sees a (.*) and (.*)")]
        public void ThenUserSeesAAnd(string team1, string team2)
        {
            MachResult machResult = new MachResult(team1, team2);
            actualScoreMachTable = machResult.ShowScore();
        }

        [Then(@"User sees score '(.*)'")]
        public void ThenUserSeesScore(string[] score)
        {
            string[] realScor = score;
            CollectionAssert.AreEqual(realScor,actualScoreMachTable);
        }

    }
}
