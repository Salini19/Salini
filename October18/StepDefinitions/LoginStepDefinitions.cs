using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        Login l = new Login();
        string? ans;

        [Given(@"the UserId is (.*)")]
        public void GivenTheUserIdIs(string uid)
        {
            l.Userid = uid;
        }

        [Given(@"the password is (.*)")]
        public void GivenThePasswordIs(string pass)
        {
            l.Passwrod = pass;
        }

        [When(@"UserClicksLogin")]
        public void WhenUserClicksLogin()
        {
            ans = l.login();
        }

        [Then(@"LoginMessage should be (.*)")]
        public void ThenSuccessfulLogINMessageShouldDisplay(string result)
        {
            Assert.AreEqual(ans, result);
            //Console.WriteLine($"{result}");
            //throw new PendingStepException();
        }

        //***************************************************************//

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            Console.WriteLine("Logging Out..");
        }

        [Then(@"Logoutmessage should be(.*)")]
        public void ThenLogOutMessageShouldDisplaye(string s)
        {
            s = "Successful Logged Out";
            Console.WriteLine($"{s}");
        }


        //***********************************************************//

        
       

    }
}
