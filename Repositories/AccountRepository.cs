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

        public void InsertAccount(Account account) => AccountDAO.Instance.InsertAccount(account);

        public string LoginAccount(string email, string password) => AccountDAO.Instance.LoginAccount(email, password);
       
    }
}
