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

        WebDriver driver;


        //WebDriver driver = new ChromeDriver();
        // ChromeOptions chromeOptions = new ChromeOptions();

        // ChromeDriverService Sdriverpath = "/usr/local/share/chromedriver";
        
        

        [When(@"откроем google")]
        public void WhenОткроемGoogle()
        {
            try
            {
                var browserDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments(browserDriverPath, "--no-sandbox", "--headless", "--disable-gpu");
                //            driver = (chromeOptions.);
                driver = new ChromeDriver(chromeOptions);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                // driver.Manage().Window.Maximize();
                driver.Manage().Window.Size = new Size(1920, 1080);
                driver.Navigate().GoToUrl(@"https:\\google.ru");
                driver.FindElement(By.Name("q")).SendKeys("mail.ru");
                driver.FindElement(By.Name("btnK")).Click();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
                driver.Quit();
            }

        }

        [Then(@"перейдём на mailru")]
        public void ThenПерейдёмНаMailru()
        {
            try
            {
                driver.FindElement(By.XPath("//a[@href='https://mail.ru/']")).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                driver.Quit();
            }
        }

        [Then(@"Пощёлкаем вкладки")]
        public void ThenПощёлкаемВкладки()
        {
            try 
            { 
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-regional']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-sport']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-lady']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-auto']")).Click();
            driver.FindElement(By.XPath("//a[@data-testid='news-tabs-tab-item-cinema']")).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                driver.Quit();
            }
        }

        [Then(@"Закроем браузер")]
        public void ThenЗакроемБраузер()
        {
            driver.Quit();
        }
    }
}
