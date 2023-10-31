using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public void DeleteAccountByEmail(string email) => AccountDAO.Instance.DeleteAccountByEmail(email);

        public int GetAccountIDByEmail(string email) => AccountDAO.Instance.GetAccountIDByEmail(email);

        public string GetAccountPassWordByEmail(string email) => AccountDAO.Instance.GetAccountPassWordByEmail(email);

        public IEnumerable<Account> GetAccounts() => AccountDAO.Instance.GetAccounts();

        public void InsertAccount(Account account) => AccountDAO.Instance.InsertAccount(account);

        public string LoginAccount(string email, string password) => AccountDAO.Instance.LoginAccount(email, password);

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);
        
    }
}
