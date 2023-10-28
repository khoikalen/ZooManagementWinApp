using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository
    {
        void InsertAccount(Account account);
<<<<<<< HEAD
        String LoginAccount(String email, String password);
=======
        void DeleteAccountByEmail(string email);
>>>>>>> ea31d9ed9fffea341de8c81a428cbe2af4c75edb
    }
}
