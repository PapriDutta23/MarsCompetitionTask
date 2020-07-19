


using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;




namespace MarsFramework.Global
{
    class GlobalDefinitions
    {
        //Initialise the browser
        public static IWebDriver driver { get; set; }

        #region WaitforElement 

        //Inplicit wait Implementation
        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }

        //Explicit wait Implementtaion for an WebElement
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }
        #endregion

        #region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                // var folderLocation = (Base.ScreenshotPath);
                var folderLocation = (@"MarsFramework\TestReports\Screenshots\Papri Test_");

                //if (!System.IO.Directory.Exists(folderLocation))
                //{
                //    System.IO.Directory.CreateDirectory(folderLocation);
                //}

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
        #endregion
    }
}
