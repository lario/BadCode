using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    public class HomeController : Controller
    {
        public static string UserName { get; set; }

        [HttpPost]
        public HomeViewModel GetViewModel()
        {
            var viewModel = GetExpensiveModelFromDataBase();

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

    public class Controller { }

    public class HttpPost : Attribute { }

    public class HomeViewModel { }

    #endregion
}
