using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace espnautomation
{
    internal class ChromeDriverWait : ChromeDriver
    {
        private IWebDriver chromeDriver;
        private TimeSpan timeSpan;

        public ChromeDriverWait(IWebDriver chromeDriver, TimeSpan timeSpan)
        {
            this.chromeDriver = chromeDriver;
            this.timeSpan = timeSpan;
        }
    }
}