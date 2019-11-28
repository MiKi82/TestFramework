using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using SeleniumExtras.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;




namespace UnitTestProjectMs.PageObjects
{
    public class MachResult : CorePage
    {

        public string Team1 { get; set; }
        public string Team2 { get; set; }


        [FindsBy(How = How.XPath, Using = @"//div[@class ='qa-match-block']/descendant::abbr/following-sibling::span")]
        protected IList<IWebElement> TeamOnResultList { get; set; }

        [FindsBy(How = How.XPath, Using = @"//span[@class ='sp-c-fixture__block']/span")]
        protected IList<IWebElement> ScoreOnResulList { get; set; }

        [FindsBy(How = How.XPath, Using = @"//a[@class = 'sp-c-fixture__block-link']")]
        protected IList<IWebElement> ScoreButtonOnResulList { get; set; }

        public MachResult(string team1, string team2)
        {
            Team1 = team1;
            Team2 = team2;
        }

        // Private Method to get List of Teams out of page and then get their indexes
        private (int, int) GetTeam(string firstTeam, string secondTeam) 
        {
            (int, int) val = (0, 0);
            List<string> teamName = TeamOnResultList.Select(s => s.Text).ToList();
            for (int i = 0; i < teamName.Count; i++)
            {
                if (teamName[i] == firstTeam && teamName[i+1] == secondTeam)
                {
                    val.Item1 = i;
                    val.Item2 = i+1;
                    break;
                }

            }
            return val;
        }

        //Method to click on link Teams that were chosen
        public void ButtonClickONTeams()
        {
           (int,int) index = GetTeam(Team1, Team2);
            int indexA = index.Item1 / 2;
            var buttonClickONTeam =  ScoreButtonOnResulList.ElementAt(indexA);
            buttonClickONTeam.Click();
        }

        // Private Method to get  Score out of page by matching indexes against teams indexes
        private string[] GetScore((int, int) teams)
        {
            string[] score = new string[2];
            List<string> teamScore = ScoreOnResulList.Select(s => s.Text).ToList();
            for (int i = 0; i < teamScore.Count; i++)
            {
                if (i == teams.Item1)
                {
                    score[0] = teamScore[i];
                }
                else if (i == teams.Item2)
                {
                    score[1] = teamScore[i];
                }

            }
            return score;
        }

      
        public string[] ShowScore()
        {

            return GetScore(GetTeam(Team1, Team2));

        }


    }
}
