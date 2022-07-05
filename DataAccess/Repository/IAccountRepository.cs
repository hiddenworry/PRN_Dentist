using System;
using System.Collections.Generic;
using BusinessObject.Models;
namespace DataAccess
{
    public interface IAccountRepository
    {
        Account CheckLogin(string username, string password);
        List<Account> GetActiveDentistList();

        Account GetAccountById(int id);

        void UpdateAccount(Account account);
    }
}
