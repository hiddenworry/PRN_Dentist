using System;
using System.Collections.Generic;
using BusinessObject.Models;
namespace DataAccess
{
    public interface IAccountRepository
    {
        Account CheckLogin(string username, string password);
        List<Account> GetActiveDentistList();


        List<Account> GetALLDentistList();

        void AddDentistAccount(Account account);

        void UpdateDentistAccount(Account account);

        Account GetAccountById(int id);

        void UpdateAccount(Account account);

        List<Account> filterDentist(Account account);

    }
}
