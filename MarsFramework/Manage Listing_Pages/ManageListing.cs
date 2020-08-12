using MarsFramework.Global;
using NUnit.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Manage_Listing_Pages
{
    public class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Click on Yes 
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Yes')]")]
        private IWebElement Yes { get; set; }

        //Click on No 
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'No')]")]
        private IWebElement No { get; set; }

        //Identify > Sign
        [FindsBy(How = How.XPath , Using = "//button[@class='ui button otherPage'][contains(.,'>')]")]
        private IWebElement NextPage { get; set; }


        public void EditManageListing()
        {
            //Click on Managelisting Link

            manageListingsLink.Click();
            GlobalDefinitions.wait(30);
            String EditStatus = "False";
            int i;

            try
            {
                while (EditStatus == "False")
                {
                    for ( i= 1; i <= 5; i++)
                    {
                        //Get the Text of CATEGORY
                        var CtgryTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[2]")).Text;

                        //Get the  Text of TITLE
                        var TitleTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]")).Text;

                        //Get The Text of DESCRIPTION
                        var DscrptnTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[4]")).Text;

                        //Get the Text of SERVICE TYPE
                        var SrvcType = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[5]")).Text;

                        //Assert.AreEqual(CtgryTxt, "Programming & Tech");
                        //Assert.AreEqual(TitleTxt, "Software Developer");
                        //Assert.AreEqual(DscrptnTxt, "Coding");
                        //Assert.AreEqual(SrvcType, "Hourly");
                        if (CtgryTxt == "Programming & Tech" && TitleTxt == "Software Developer" && DscrptnTxt == "Coding" && SrvcType == "Hourly")
                        {
                            //Identify on Edit Pen sign
                             //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[2]/i"), 60);
                            IWebElement EditPen = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[2]/i"));

                            //Click on Edin Pen button
                            Thread.Sleep(3000);
                            EditPen.Click();
                            EditStatus = "True";
                            break;
                        }
                    }
                    if (EditStatus == "False")
                    {
                        i = 0;
                        //Click on Next Page
                        NextPage.Click();
                    }


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
        public void DeleteManageListing()
        {
            //Click on Managelisting Link

            manageListingsLink.Click();
            GlobalDefinitions.wait(30);
            String DelStatus = "False";
            int i;
            //Itertaing Through The table
                      

                try
                {
                    while (DelStatus == "False")
                    {


                        for ( i = 1; i <= 5; i++)
                        {
                            //Get the Text of CATEGORY
                            var CtgryTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[2]")).Text;

                            //Get the  Text of TITLE
                            var TitleTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]")).Text;

                            //Get The Text of DESCRIPTION
                            var DscrptnTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[4]")).Text;

                            //Get the Text of SERVICE TYPE
                            var SrvcType = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[5]")).Text;

                            //Assert.AreEqual(CtgryTxt, "Programming & Tech");
                            //Assert.AreEqual(TitleTxt, "Software Tester");
                            //Assert.AreEqual(DscrptnTxt, "Api , Selenium C Tester");
                            //Assert.AreEqual(SrvcType, "Hourly");

                            if (CtgryTxt == "Programming & Tech" && TitleTxt == "Software Tester" && DscrptnTxt == "Api , Selenium C Tester" && SrvcType == "Hourly")
                            {
                                //Identify Delete CROSS SIGN
                                IWebElement Delete = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[3]/i"));

                                //Click On delete 
                                Delete.Click();

                                //Click on Yes
                                Yes.Click();
                                DelStatus = "True";
                                break;
                            }

                        }

                        if (DelStatus == "False")
                        {
                         i = 0;
                        //Click on Next Page
                        NextPage.Click();
                        }
                    

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

        }


        


    }
}
