using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowAllure
{
    [Binding]
    public class Selenium
    {



        ChromeOptions chromeOptions = new ChromeOptions();
       
        WebDriver driver = new ChromeDriver();
    [When(@"откроем google")]
        public void WhenОткроемGoogle()
        {
            chromeOptions.AddArguments("no-sandbox", "headless", "disable-gpu");
            var driver = new ChromeDriver(chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // driver.Manage().Window.Maximize();
            driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Navigate().GoToUrl(@"https:\\google.ru");
            driver.FindElement(By.Name("q")).SendKeys("mail.ru");
            driver.FindElement(By.Name("btnK")).Click();

        }

        [Then(@"перейдём на mailru")]
        public void ThenПерейдёмНаMailru()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@href='https://mail.ru/']")).Click();
        }

        [Then(@"Пощёлкаем вкладки")]
        public void ThenПощёлкаемВкладки()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-covid']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-regional']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-sport']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-lady']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-auto']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-cinema']")).Click();
        }

        [Then(@"Закроем браузер")]
        public void ThenЗакроемБраузер()
        {
            driver.Quit();
        }
    }
}
