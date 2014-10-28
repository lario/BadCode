using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    enum Role
    {
        Admin,
        User
    }

    class CM09_Switch
    {
        #region Bad
        public bool IsAllowedBad(Role role)
        {
            if (role == Role.User)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SaveFile(string content)
        {
            int quota = 0;

            switch (GetCurrentRole())
            {
                case Role.Admin:
                    quota = 1000;
                    break;

                case Role.User:
                    quota = 100;
                    break;
            }

            if (content.Length > quota)
                throw new QuotaExcedeedException();

            // save file
        } 
        #endregion

        #region Good
        public bool IsAllowedGood(Role role)
        {
            if (role == Role.User)
            {
                return false;
            }
            else if (role == Role.Admin)
            {
                return true;
            }

            return false;
        }

        public void SaveFile(string content)
        {
            int quota = 0;

            switch (GetCurrentRole())
            {
                case Role.Admin:
                    quota = 1000;
                    break;

                case Role.User:
                    quota = 100;
                    break;

                default:
                    throw new ArgumentException();
            }

            if (content.Length > quota)
                throw new QuotaExcedeedException();

            // save file
        } 
        #endregion

        #region ...
        private Role GetCurrentRole()
        {
            return Role.Admin;
        }

        class QuotaExcedeedException : Exception
        {
        } 
        #endregion
    }
}
