using System;
using System.Collections.Generic;
using BusinessObject.Models;
namespace DataAccess
{
    public interface IAccountRepository
    {
        Account CheckLogin(string username, string password);
        List<Account> GetActiveDentistList();
<<<<<<< HEAD
        List<Account> GetDentistList();
=======


        List<Account> GetALLDentistList();

        void AddDentistAccount(Account account);

        void UpdateDentistAccount(Account account);

        Account GetAccountById(int id);

        void UpdateAccount(Account account);

        List<Account> filterDentist(Account account);

>>>>>>> 42cc2ba450d82ce0b28a1449cbf15841d63a84f6
    }
}
