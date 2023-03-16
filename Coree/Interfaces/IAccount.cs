using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coree.Interfaces
{
    public interface IAccount
    {
        string PasswordChecker(string password);

        void ShowInfo(); 
    }
}
