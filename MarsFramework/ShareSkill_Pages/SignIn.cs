using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {

            ExcelLibHelp.PopulateInCollection(@"MarsFramework\ExcelData\TestDataShareSkill.xlsx", "SignIn");
            PageFactory.InitElements(GlobalDefinitions.driver, this);
            
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        //Finding the Change Password Link
        [FindsBy(How = How.XPath , Using = "//a[@class='pointerCursor'][contains(.,'Forgot your password?')]")]
        private IWebElement Forget_Password { get; set; }

        //Finding the Email address for Forget Password Link
        [FindsBy(How = How.XPath , Using = ("//input[contains(@placeholder,'Email address')]"))]
        private IWebElement email_verify { get; set; }
        //Finding the Send Verification Email
        [FindsBy (How = How.XPath , Using = ("//div[@class='fluid ui teal button'][contains(.,'SEND VERIFICATION EMAIL')]"))]
        private IWebElement Send_Verification { get; set; }


        #endregion

        public  void LoginSteps()
        {
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(ExcelLibHelp.ReadData(2,"Url"));
                        
            //Click the sign-In tab
            SignIntab.Click();

            //sending values to email id
            Email.SendKeys(ExcelLibHelp.ReadData(2, "Username"));

            //sending velues of password
            Password.SendKeys(ExcelLibHelp.ReadData(2, "Password"));

            //Click login Button
            LoginBtn.Click();

            Global.GlobalDefinitions.wait(5);


        }

        public void ChangePassword()
        {
            //Click Forget Password link
            Forget_Password.Click();

            //Click Forget Email verify link
            email_verify.Click();

            //Sending the email address
            //sending values to email id
            email_verify.SendKeys(ExcelLibHelp.ReadData(2, "Username"));

            //Click on "Send Verification" Box
            Send_Verification.Click();


        }
       
    }
}