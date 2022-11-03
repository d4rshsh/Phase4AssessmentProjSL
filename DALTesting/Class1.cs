using DALPhase4;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTesting
{
    [TestFixture]
    public class UserInfoTest
    {
        UserMethods methods = new UserMethods();
        [TestCase]
        public void ValidateUserTest()
        {
            UserInfo user = new UserInfo();
            user.UserId = 1;
            user.Email = "darshan@gmail.com";
            user.Password = "boots1005";
            bool ans = methods.ValidateUser(user);
            Assert.AreEqual(true, ans); 
            Console.WriteLine("Successfully validated");

        }
    }
    [TestFixture]
    public class CustLogTest
    {
        CustLogMethods methods = new CustLogMethods();
        [Test]
        public void SaveCustLogInfoTest()
        {
            CustLogInfo cust = new CustLogInfo();
            cust.LogId = 1;
            cust.CustName = "Sonia";
            cust.CustEmail = "sonia@gmail.com";
            cust.LogStatus = "Logging";
            cust.UserId = 1;
            cust.Description = "Log in Error";

            bool ans = methods.SaveCustloginfotest(cust);
            Assert.AreEqual(true, ans); //ch
        }
    }
}
