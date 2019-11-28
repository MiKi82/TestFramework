using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;



namespace UnitTestProjectMs.PageObjects
{
    class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver Driver()
        {
            // Если driver равен null (??), то создать новый ChromeDriver
            driver = driver ?? new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return driver;
        }
        public static void CloseDriver()
        {
            if (driver != null) driver.Quit();
        }
        static readonly Finalizer finalizer = new Finalizer();
        sealed class Finalizer
        {
            ~Finalizer()
            {
                CloseDriver();
            }
        }

    }
}
