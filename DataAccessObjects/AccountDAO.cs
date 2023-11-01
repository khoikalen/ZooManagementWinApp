using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Account> GetAccounts()
        {
            var accounts = new List<Account>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                accounts = db.Accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return accounts;
        }
        public void InsertAccount(Account account)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Accounts.Add(account);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public String LoginAccount(String email, String password)
        {
            try
            {
                using (var context = new ZooManagementDotNetContext())
                {
                    var loginAccount = context.Accounts.FirstOrDefault(c => c.Email.Equals(email) && c.Password.Equals(password));
                    return loginAccount.Role;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            }
        public void DeleteAccountByEmail(string email) 
        {
            var account = new Account();    
            try
            {
                using var db = new ZooManagementDotNetContext();
                account = db.Accounts.FirstOrDefault(x => x.Email == email);
                db.Accounts.Remove(account);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
<<<<<<< HEAD


        
=======
        public void UpdateAccount(Account account)
        {
            try
            {
                using (var context = new ZooManagementDotNetContext())
                {
                    context.Accounts.Update(account);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public int GetAccountIDByEmail(string email)
        {
            try
            {
                using(var context = new ZooManagementDotNetContext())
                {
                    var account = context.Accounts.SingleOrDefault(c => c.Email.Equals(email));
                    return account.Id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public String GetAccountPassWordByEmail(String email)
        {
            try
            {
                using(var context = new ZooManagementDotNetContext())
                {
                    var account = context.Accounts.SingleOrDefault(c => c.Email.Equals(email));
                    return account.Password;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
>>>>>>> 4cc1e79d88277d7bf274d2208cf382a8007c5ee9
    }
}
