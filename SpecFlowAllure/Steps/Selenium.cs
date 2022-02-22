using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowAllure
{
    [Binding]
    public class Selenium
    {
       
        
        //WebDriver driver = new ChromeDriver();
        //ChromeOptions chromeOptions = new ChromeOptions();
        
        // ChromeDriverService Sdriverpath = "/usr/local/share/chromedriver";
        //WebDriver driver = new ChromeDriver();
        

        [When(@"откроем google")]
        public void WhenОткроемGoogle()
        {

            var browserDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //Set Chrome to start with maximized window
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--no-sandbox", "--headless", "--disable-gpu");

            //Open Chrome
            using (WebDriver driver = new ChromeDriver(browserDriverPath, options))
            {
                //Assign google.com to variable named url
                var url = "http://google.com";
                //Go to Google.com
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                // driver.Manage().Window.Maximize();
                driver.Manage().Window.Size = new Size(1920, 1080);
                driver.Navigate().GoToUrl(@"https:\\google.ru");
                driver.FindElement(By.Name("q")).SendKeys("mail.ru");
                driver.FindElement(By.Name("btnK")).Click();
                driver.FindElement(By.XPath("//a[@href='https://mail.ru/']")).Click();
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-covid']")).Click();
                driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-regional']")).Click();
                driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-sport']")).Click();
                driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-lady']")).Click();
                driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-auto']")).Click();
                driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-cinema']")).Click();

                driver.Quit();
            }
            
            //   chromeOptions.AddArguments("--no-sandbox", "--headless", "--disable-gpu");
            //            driver = (chromeOptions.);

            //      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //      // driver.Manage().Window.Maximize();
            //      driver.Manage().Window.Size = new Size(1920, 1080);
            //      driver.Navigate().GoToUrl(@"https:\\google.ru");
            //      driver.FindElement(By.Name("q")).SendKeys("mail.ru");
            //      driver.FindElement(By.Name("btnK")).Click();






        }

        [Then(@"перейдём на mailru")]
        public void ThenПерейдёмНаMailru()
        {
            Thread.Sleep(2000);
         //   driver.FindElement(By.XPath("//a[@href='https://mail.ru/']")).Click();
        }

        [Then(@"Пощёлкаем вкладки")]
        public void ThenПощёлкаемВкладки()
        {
          // driver.SwitchTo().Window(driver.WindowHandles[1]);
          // driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-covid']")).Click();
          // driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-regional']")).Click();
          // driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-sport']")).Click();
          // driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-lady']")).Click();
          // driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-auto']")).Click();
          // driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-cinema']")).Click();
        }

        [Then(@"Закроем браузер")]
        public void ThenЗакроемБраузер()
        {
            //driver.Quit();
        }
    }
}
