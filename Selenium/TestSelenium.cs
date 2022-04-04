using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    
    class TestSelenium
    {
        WebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.bing.com/";

            WebElement searchBar = (WebElement)driver.FindElement(By.Id("sb_form_q"));

            searchBar.SendKeys("java fundamentals");

            searchBar.Submit();

            driver.Url = driver.FindElement(By.LinkText("Java fundamentals - CodeLearn")).GetAttribute("href");

            Assert.AreEqual(driver.Title, "Java fundamentals");
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }
    }
}
