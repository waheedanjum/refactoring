using Smartwyre.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartwyre.DeveloperTest.Services
{
    public interface IAccountDataStore
    {
        Task<Account> GetAccountAsync(string accountNumber);
        Task UpdateAccountAsync(Account account);
    }
}
