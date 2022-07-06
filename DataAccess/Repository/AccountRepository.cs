using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {

     
        public List<Account> GetActiveDentistList() => AccountDAO.Instance.GetActiveDentistList();

<<<<<<< HEAD
        public List<Account> GetDentistList() => AccountDAO.Instance.GetDentistList();

        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);
        
=======

        public Account GetAccountById(int id) => AccountDAO.Instance.GetAccountById(id);

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);   


        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);

        public void AddDentistAccount(Account account) => AccountDAO.Instance.AddDentistAccount(account);

        public List<Account> GetALLDentistList() => AccountDAO.Instance.GetALLDentistList();


        public void UpdateDentistAccount(Account account) => AccountDAO.Instance.UpdateDentistAccount(account);

        public List<Account> filterDentist(Account account) => AccountDAO.Instance.filterDentist(account);
       
>>>>>>> 42cc2ba450d82ce0b28a1449cbf15841d63a84f6
    }
}
