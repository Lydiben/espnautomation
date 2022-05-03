using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace espnautomation
{
     class Program
    {

      static void Main(string[] args)
        {

            using (IWebDriver ChromeDriver = new ChromeDriver())
            {
                ChromeDriver.Navigate().GoToUrl("https://www.espn.in");
                //Thread.Sleep(3000);
                ChromeDriver.Manage().Window.Maximize();
                //  _ = new ChromeDriverWait(ChromeDriver, TimeSpan.FromSeconds(10));

                // Sign In
                IWebElement SignUpClick = ChromeDriver.FindElement(By.ClassName("button med"));
                SignUpClick.Click();
                IWebElement firstName = ChromeDriver.FindElement(By.Id("firstName"));
                firstName.SendKeys("MySport");
                IWebElement lastName = ChromeDriver.FindElement(By.Id("lastName"));
                lastName.SendKeys("Watch");
                IWebElement Emailaddress = ChromeDriver.FindElement(By.Id("Emailaddress"));
                Emailaddress.SendKeys("lydiabenhur.98@gmail.com");
                IWebElement Password = ChromeDriver.FindElement(By.Id("Password (case sensitive)"));
                Password.SendKeys("MySport@98");
                IWebElement SigninClick = ChromeDriver.FindElement(By.ClassName("btn btn-primary ng-scope ng-isolate-scope"));
                SigninClick.Click();
                IWebElement close = ChromeDriver.FindElement(By.Id("close"));
                close.Click();


                //Login 
                IWebElement Usernameoremailaddress = ChromeDriver.FindElement(By.Id("Username or Email Address"));
                Usernameoremailaddress.SendKeys("lydiabenhur.98@gmail.com");
                IWebElement logPassword = ChromeDriver.FindElement(By.Id("Password (case sensitive)"));
                logPassword.SendKeys("MySport@98");
                IWebElement Login = ChromeDriver.FindElement(By.ClassName("btn btn-primary btn-submit ng-isolate-scope"));
                Login.Click();

                //search
                IWebElement search = ChromeDriver.FindElement(By.Id("global-search-trigger"));
                search.Click();

                //Follow 
                IWebElement football = ChromeDriver.FindElement(By.ClassName("Football"));
                football.Click();
                // ChromeDriver waitForControl = new ChromeDriverWait(ChromeDriver, TimeSpan.FromSeconds(10));

                IWebElement arsenal = ChromeDriver.FindElement(By.ClassName("sprite-soccer-teams-25 sprite-25-team-359"));
                arsenal.Click();

                IWebElement follow = ChromeDriver.FindElement(By.ClassName("/Button Button--sm Button--alt ClubhouseHeader__Follow"));
                follow.Click();

                ChromeDriver.Quit();
            }


        }

    }
    }
          
         

