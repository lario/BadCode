using System;

namespace BadCode.CommonMistakes
{
    internal class CM03
    {
        public class HomeController : Controller
        {
            public static string UserName { get; set; }

            [HttpPost]
            public HomeViewModel GetViewModel()
            {
                dynamic viewModel = GetExpensiveModelFromDataBase();

                UserName = viewModel.UserName;

                return viewModel;
            }

            [HttpPost]
            public void ResetPassword()
            {
                SendEmailToUser(UserName);
            }

            private void SendEmailToUser(string UserName)
            {
                throw new NotImplementedException();
            }

            private dynamic GetExpensiveModelFromDataBase()
            {
                throw new NotImplementedException();
            }
        }

        #region ...

        public class Controller
        {
        }

        public class HttpPost : Attribute
        {
        }

        public class HomeViewModel
        {
        }

        #endregion
    }
}