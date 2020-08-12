using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Global;
using OpenQA.Selenium;

namespace MarsFramework.PROFILE_Pages
{
   public  class Description
    {
        public IWebDriver Driver;
        public Description(IWebDriver driver)
        {
            this.Driver = GlobalDefinitions.driver;
            ExcelLibHelp.PopulateInCollection(@"MarsFramework\ExcelData\TestDataShareSkill.xlsx", "Description");
            // ExcelLibHelp.PopulateInCollection(@"C:\Users\abhij\Desktop\Competition Task My work\marsframework(Cloned)\MarsFramework\ExcelData\TestDataShareSkill", "Share Skill");
            // PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        //Identify the Pen sign in Desccription 
        IWebElement DscrptnPen => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));

        //Identifying The Text box in Description
        IWebElement DscrptnTxtBx => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

        //Identify SAVE button
        IWebElement save => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

        public void AddDescription()
        {
            //Click on Pen sign of Description
            DscrptnPen.Click();

            //Click on Description Text Box
            DscrptnTxtBx.Click();

            //Sending dataTo description
            DscrptnTxtBx.SendKeys(ExcelLibHelp.ReadData(3, "Profile Description"));

            //Click on Save
            save.Click();
        }






        

    }
}
