using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacetask
{
    internal interface IAccount
    {
        public void ShowFullInfo();
        public bool PasswordChecker(string password);
    }
}
