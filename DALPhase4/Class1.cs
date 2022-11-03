using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALPhase4
{
    public class UserMethods
    {
        Phase4AzureDBEntities context = null;
        public UserMethods()
        {
            context = new Phase4AzureDBEntities();
        }
        public bool ValidateUser(UserInfo u)
        {
            List<UserInfo> list = context.UserInfoes.ToList();
            bool ans = false;

            UserInfo u1 = list.Find(x => x.UserId == u.UserId);
            if (u1 != null)
            {
                if (u1.Password == u.Password)
                {
                    ans = true;
                }
            }

            return ans;

        }

    }
    public class CustLogMethods
    {
        Phase4AzureDBEntities context = null;
        public CustLogMethods()
        {
            context = new Phase4AzureDBEntities();
        }
        public bool SaveCustloginfotest(CustLogInfo cust)
        {
            try
            {
                context.CustLogInfoes.Add(cust);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
