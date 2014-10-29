using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CodeSmells
{
    class CS07Bad
    {
        class Account
        {
            public string HolderName { get; set; }

            public int Amount { get; set; }

            public string ToXml()
            {
                return string.Format("<account><name>{0}</name><amount>{1}</amount></account>", HolderName, Amount);
            }
        }
    }

    class CS07Good
    {
        // divergent change
        class Account
        {
            public string HolderName { get; set; }

            public int Amount { get; set; }
        }

        class AccountSerializer
        {
            public string ToXml(Account account)
            {
                return string.Format("<account><name>{0}</name><amount>{1}</amount></account>", account.HolderName, account.Amount);
            }
        }
    }
}
