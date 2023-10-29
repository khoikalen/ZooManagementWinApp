﻿using BusinessObjects.Models;
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
        String LoginAccount(String email, String password);
        void DeleteAccountByEmail(string email);
    }
}
