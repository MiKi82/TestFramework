using System.Collections.Generic;
using System.Threading;
using UnitTestProjectMs.PageObjects;



namespace UnitTestProjectMs.BLL
{
    public  class Bll
    {
        
        public void UserOnBbcComPage()
        {
            var bbcPage = new BbcPage();
            bbcPage.Invoke();
        }

        public void UserOnBbcNewsPage()
        {
            var nwestPg = new NewsPage();
            nwestPg.Invoke();
        } 
        public void ProceedToSportPage()
        {
            var bbcPage = new BbcPage();
            bbcPage.ClickSportBtn();
           
        }
        public void clickOnMoreBtn()
        {
            var sportPg = new SportPage();
            sportPg.ClickMoreBtnOnSportPg();
           
        }

        public void ProceedToScottishLeague()
        {
            var sportPg = new SportPage();
            sportPg.ClickScotlandLeagueBtnOnSportPg();
           
        }
        public void SeeAllMatchesScottishLeague()
        {
            var sportPg = new SportPage();
            sportPg.ClickScotlandPrenAllMatchBtnOnSportPg();
           
        }

        public void ProceedToResults()
        {
            var sportPg = new SportPage();
            sportPg.ClickResultsBtnOnSportPg();
           
        }

        public  void UserGettingFromBBCComToScottishPremshipResults()
        {
            UserOnBbcComPage();
            ProceedToSportPage();
            clickOnMoreBtn();
            ProceedToScottishLeague();
            SeeAllMatchesScottishLeague();
            ProceedToResults();
        }

        public string[] GetScoreFromTheTable(string team1, string team2)
        {
            MachResult machResult = new MachResult(team1, team2);
            return machResult.ShowScore();
           
        }
        public List<string> CheckingSecondHeadersArticleArePresent()
        {
            var newsPage = new NewsPage();           
            return newsPage.GetRealResultsHeadersList();
             
        }
        public string[] GettingscoreFromBigScreenPage(string team1, string team2)
        {
            MachResult machResult = new MachResult(team1, team2);
            machResult.ButtonClickONTeams();
            Thread.Sleep(2000);          
            var bigBoardScreen = new BigBoardScorePage();
            return  bigBoardScreen.GetResultFromTheScreen();
             
        }

        public void CopyTextOfTheLinkUnderTheHeadlineArticle()
        {
            UserOnBbcNewsPage();
            var newsPage = new NewsPage();
            newsPage.GetCategoryText();
           
            
        }

        public void PasteTextOfTheLinkUnderTheHeadlineArticle()
        {
            var newsPage = new NewsPage();
            newsPage.SearchResult();
        }

        public string GetFirstSearchQueryResult()
        {
            var searchResultPG = new SearchResultPage();
            return searchResultPG.FirstResult();

        }

        public void ClickNewsBtn()
        {
            var bbcPage = new BbcPage();
            bbcPage.ClickNewsBtn();
          
        }


    }
}
