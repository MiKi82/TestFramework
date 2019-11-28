using TechTalk.SpecFlow;
using UnitTestProjectMs.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using UnitTestProjectMs.BLL;

namespace UnitTestProjectMs.CodeBinding
{
    [Binding]
    public class BigScreenSportPageSteps
    {
        private readonly Bll bll = new Bll();


        [Given(@"User on Scottish Premship score results page")]
        public void GivenUserOnScottishPremshipScoreResultsPage()
        {           
            bll.UserGettingFromBBCComToScottishPremshipResults();
        }


        [StepArgumentTransformation]
        public string[] TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        [When(@"User press on (.*) or (.*) name")]
        public void WhenUserPressOnOrName(string team1, string team2)
        {
            MachResult machResult = new MachResult(team1, team2);
            machResult.ButtonClickONTeams();
            
        }

        [Then(@"User sees the '(.*)' same as on previous page")]
        public void ThenUserSeesTheSameAsOnPreviousPage(string[] score)
        {
            string[] actualScoreBigBoard;
            var bigBoardScreen = new BigBoardScorePage();
            actualScoreBigBoard = bigBoardScreen.GetResultFromTheScreen();
            CollectionAssert.AreEqual(score, actualScoreBigBoard);
        }
    }
}

