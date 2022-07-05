using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {
     
        public List<Account> GetActiveDentistList() => AccountDAO.Instance.GetActiveDentistList();

        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);

        public void AddDentistAccount(Account account) => AccountDAO.Instance.AddDentistAccount(account);

        public List<Account> GetALLDentistList() => AccountDAO.Instance.GetALLDentistList();


        public void UpdateDentistAccount(Account account) => AccountDAO.Instance.UpdateDentistAccount(account);
      

      
    }
}
