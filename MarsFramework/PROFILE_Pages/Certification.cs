using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.PROFILE_Pages
{
    public class Certification
    {
        public IWebDriver driver;
        public Certification(IWebDriver driver)
        {
            this.driver = GlobalDefinitions.driver;
            ExcelLibHelp.PopulateInCollection(@"MarsFramework\ExcelData\TestDataShareSkill.xlsx", "Certification");
            // ExcelLibHelp.PopulateInCollection(@"C:\Users\abhij\Desktop\Competition Task My work\marsframework(Cloned)\MarsFramework\ExcelData\TestDataShareSkill", "Share Skill");
            // PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        //Identify Certification Tab
        IWebElement CertificationBtn => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'fourth')]"));

        //Identify "Add New" Button
        IWebElement AddNew => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        //Identify The Certificate Text Box
        IWebElement CertificateTxtBx => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));

        //Identify  Certificate From Txt Box
        IWebElement CrtfctFrm => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@name,'certificationFrom')]"));

        //Identify The Year Dropdown
        IWebElement Year => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'certificationYear')]"));

        //Identify Add Button
        IWebElement add => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));

        public void AddNewCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();

            //Click on Add New Button
            AddNew.Click();

            //Click on Certificate
            CertificateTxtBx.Click();

            //Sending data to certificate
            CertificateTxtBx.SendKeys(ExcelLibHelp.ReadData(3, "Certificate"));

            //Click on Certificate From Txt Box
            CrtfctFrm.Click();

            //Sending data to certificate From text box
            CrtfctFrm.SendKeys(ExcelLibHelp.ReadData(3, "From"));

            //Click on Year Dropdown 
            Year.Click();

            //Sending value to Year dropdown
            GlobalDefinitions.wait(30);
            Year.SendKeys(ExcelLibHelp.ReadData(3, "Year"));

            //Click on Add 
            GlobalDefinitions.wait(30);
            add.Click();
        }
        public void UpdateCertification()

        {
            //Click on Certification Button
            CertificationBtn.Click();
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    //Get the Text of Certificate
                    var CrtfctTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of Certificate From 
                    var CrtfctFrmTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    //Get The Year
                    var YearBxTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;

                    if (CrtfctTxt == "Certificate 4" && CrtfctFrmTxt == "TAFE" && YearBxTxt == "2018")
                    {
                                       
                        //Identify Certification Update Pen
                        IWebElement CertUpdatePen = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                        GlobalDefinitions.wait(30);

                        //Click on Update Pen Icon
                        ConstantHelpers.Click_Operation(CertUpdatePen);

                        //Click Cert Text Box
                        IWebElement CertupdateTxtBx = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input"));
                        ConstantHelpers.Click_Operation(CertupdateTxtBx);

                        //Clear the Text Box
                        CertupdateTxtBx.Clear();

                        //Send data To "Cert Text Box"
                        GlobalDefinitions.wait(30);
                        CertupdateTxtBx.SendKeys("Test Analyst");

                        //Click From Text Box
                        IWebElement FromupdateTxtBx = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input"));
                        ConstantHelpers.Click_Operation(FromupdateTxtBx);

                        //Clear the Text Box
                        FromupdateTxtBx.Clear();

                        //Send data To "Cert Text Box"
                        GlobalDefinitions.wait(30);
                        FromupdateTxtBx.SendKeys("MVPStudio");


                        //Select year value from Dropdown Box
                        GlobalDefinitions.wait(30);
                        IWebElement CertYearDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select"));
                        ConstantHelpers.Drop_Down_Select_By_Text(CertYearDrpdwn, "2012");

                        //Click Update
                        IWebElement Certupdate = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                        ConstantHelpers.Click_Operation(Certupdate);
                        break;
                    }
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DeleteCertification()
        {
            // Click on Certification Button
            CertificationBtn.Click();
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    //Get the Text of Certificate
                    var CrtfctTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Get the Text of Certificate From 
                    var CrtfctFrmTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    //Get The Year
                    var YearBxTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;

                    if (CrtfctTxt == "Certificate 4" && CrtfctFrmTxt == "TAFE" && YearBxTxt == "2018")
                    {
                        //Identify Certification Update Pen
                        IWebElement CertUpdatePen = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[2]"));
                        GlobalDefinitions.wait(30);

                        //Click on Delete Pen Icon
                        ConstantHelpers.Click_Operation(CertUpdatePen);
                        break;
                    }
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ValidateAddCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();   

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Certificate"
                var CertTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "From"                                                                                                                  
                var FromTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (CertTxt == "Certificate 4" && FromTxt == "TAFE")
                    {
                        Console.WriteLine("Added Certificate has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        public void ValidateUpdatedCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Certificate"
                var CertTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "From"                                                                                                                  
                var FromTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (CertTxt == "Test Analyst" && FromTxt == "MCPStudio")
                    {
                        Console.WriteLine("Udpated Certificate has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }


        public void ValidateDelCertification()
        {
            //Click on Certification Button
            CertificationBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Certificate"
                var CertTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                //Get the Text of the "From"                                                                                                                  
                var FromTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                try
                {

                    if (CertTxt != "Certificate 4" && FromTxt != "TAFE")
                    {
                        Console.WriteLine("Deleted Certificate has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }




    }
}
