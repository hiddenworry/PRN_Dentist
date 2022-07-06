using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        public List<Account> GetActiveDentistList() => AccountDAO.Instance.GetActiveDentistList();

        public List<Account> GetDentistList() => AccountDAO.Instance.GetDentistList();

        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);
        
    }
}
