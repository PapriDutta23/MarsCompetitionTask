using MarsFramework.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.PROFILE_Pages
{
    public class Education
    {
        //Identifying the Education Data Tab button
        IWebElement EdctnBtn => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(@data-tab,'third')]"));

        //Identifying ADD NEW Button
        IWebElement AddNewBtn => GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));

        //Identify University Text Box
        IWebElement UniBtn => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));

        //Identify The College of Country DropDown
        IWebElement Country => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'country')]"));

        //Identify The Title 
        IWebElement Title => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'title')]"));

        //Identify Degree Text Box
        IWebElement Degree => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Degree')]"));

        //Identify The Year  Of Grdauation DropDown Box
        IWebElement Year => GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'yearOfGraduation')]"));

        //Identify Add Button
        IWebElement Add => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));

        //Identify Update Button
        IWebElement Update => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));
        public void AddNewEdctn()
        {
            //Click Education Data tab
            GlobalDefinitions.wait(60);
            EdctnBtn.Click();

            //Click "Add New Btn" 
            AddNewBtn.Click();

            //Click University Text Box
            UniBtn.Click();

            //Sending data to University Button
            UniBtn.SendKeys("WBUT");

            //Click Country Dropdown
            Country.Click();

            //Selection of Country from DROPdown
            Thread.Sleep(5000);
            // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//select[contains(@name,'country')]"), 30);
            ConstantHelpers.Drop_Down_Select_By_Value(Country, "India");

            //Click on Title Dropdown
            GlobalDefinitions.wait(60);
            Title.Click();

            //SElection Of TITLE Dropdown
            ConstantHelpers.Drop_Down_Select_By_Text(Title, "B.Sc");

            //Click on Degree 
            GlobalDefinitions.wait(60);
            Degree.Click();

            //Sending Data to Degree Button
            Degree.SendKeys("Graduation");

            //Click on Year of Grdauation
            GlobalDefinitions.wait(60);
            Year.Click();

            //Selection Of TITLE Dropdown
            ConstantHelpers.Drop_Down_Select_By_Text(Year, "2012");

            //Click Add
            Add.Click();
        }
        public void UpdateEducation()
        {
            //Click on Education Data Tab
            EdctnBtn.Click();

            //Iterating thhrough the Education table

            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    //Identify Country Text
                    var Country_Txt = GlobalDefinitions.driver.FindElement(By.XPath("html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Identify University Text
                    var Uni_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    //Identify The Title Text
                    var Title_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;

                    //Identify the DEGREE Text
                    var Degree_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[4]")).Text;

                    //Idendify the Year of Graduation Test
                    var Year_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[5]")).Text;

                    if (Country_Txt == "India" && Uni_Txt == "WBUT" && Degree_Txt == "Graduation" && Title_Txt == "B.Sc" && Year_Txt == "2012")
                    {
                        //Identify Language Update Pen
                        GlobalDefinitions.wait(30);
                        IWebElement Edctn_Updt_Pen = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[6]/span[1]/i"));


                        //Click on Update Pen Icon
                        GlobalDefinitions.wait(30);
                        ConstantHelpers.Click_Operation(Edctn_Updt_Pen);

                        //Click  University Text Box
                        UniBtn.Click();

                        //Clear University Button
                        UniBtn.Clear();

                        //Send Keys To University Text Box
                        UniBtn.SendKeys("HARVARD");


                        //Selection of Country from DROPdown
                        GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//select[contains(@name,'country')]"), 30);
                        ConstantHelpers.Drop_Down_Select_By_Value(Country, "United States");


                        //Click on Title Dropdown
                        GlobalDefinitions.wait(60);
                        Title.Click();

                        //SElection Of TITLE Dropdown
                        ConstantHelpers.Drop_Down_Select_By_Text(Title, "M.Tech");

                        //Click on Degree 
                        GlobalDefinitions.wait(60);
                        Degree.Click();

                        //Clear Degree text Box
                        Degree.Clear();

                        //Sending Data to Degree Button
                        Degree.SendKeys("Masters");

                        //Click on Year of Grdauation
                        GlobalDefinitions.wait(60);
                        Year.Click();

                        //Selection Of TITLE Dropdown
                        ConstantHelpers.Drop_Down_Select_By_Text(Year, "2019");

                        //Click on Update Button
                        Update.Click();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DeleteEducation()
        {
            //Click on Education Data Tab
            EdctnBtn.Click();

            //Iterating through the Education table

            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    //Identify Country Text
                    var Country_Txt = GlobalDefinitions.driver.FindElement(By.XPath("html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    //Identify University Text
                    var Uni_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                    //Identify The Title Text
                    var Title_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]")).Text;

                    //Identify the DEGREE Text
                    var Degree_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[4]")).Text;

                    //Idendify the Year of Graduation Test
                    var Year_Txt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[5]")).Text;

                    if (Country_Txt == "United States" && Uni_Txt == "HARVARD" && Degree_Txt == "Masters" && Title_Txt == "M.Tech" && Year_Txt == "2019")
                    {
                        //Identify Language Update Pen
                        GlobalDefinitions.wait(30);
                        IWebElement Edctn_Delete_Pen = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[6]/span[2]/i"));

                        //Click on Delete Pen Icon
                        Edctn_Delete_Pen.Click();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void ValidateAddEducation()
        {
            //Click Education Data tab
            GlobalDefinitions.wait(60);
            EdctnBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Education"
                var UniTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                //Get the Text of the "Degree" of Education                                                                                                               
                var DegreeTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[4]")).Text;

                try
                {

                    if (UniTxt == "WBUT" && DegreeTxt == "Graduation")
                    {
                        Console.WriteLine("Added Education has been Validated");
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        public void ValidateDelEducation()
        {
            //Click Education Data tab
            GlobalDefinitions.wait(60);
            EdctnBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Education"
                var UniTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                //Get the Text of the "Degree" of Education                                                                                                               
                var DegreeTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[4]")).Text;

                try
                {

                    if (UniTxt != "HARVARD" && DegreeTxt != "Masters")
                    {
                        Console.WriteLine("Deleted Education has been validated");
                        break;
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

        public void ValidateUpdateEducation()
        {
            //Click Education Data tab
            GlobalDefinitions.wait(60);
            EdctnBtn.Click();

            for (int i = 1; i <= 3; i++)
            {
                //Get the Text Of The "Education"
                var UniTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;

                //Get the Text of the "Degree" of Education                                                                                                               
                var DegreeTxt = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[4]")).Text;

                try
                {

                    if (UniTxt == "HARVARD" && DegreeTxt == "Masters")
                    {
                        Console.WriteLine("Updated Education has been Validated");
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














































