using Smartwyre.DeveloperTest.Types;
using System.Threading.Tasks;

namespace Smartwyre.DeveloperTest.Services
{
    public class AccountDataStore : IAccountDataStore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public async Task<Account> GetAccountAsync(string accountNumber)
        {
              return await Task.Run(() =>  new Account());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task UpdateAccountAsync(Account account)
        {
            // Update account in database, code removed for brevity
        }

       
    }
}
