using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Example
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoapps.qspiders.com/");
            driver.Manage().Window.Maximize();

            Console.WriteLine(driver.Title);

            IWebElement tileUITestingConcepts = driver.FindElement(By.XPath("//*[@id='optionsBody']/a[1]/div/main/div[2]"));

            tileUITestingConcepts.Click();



            driver.Quit();

        }
    }
}