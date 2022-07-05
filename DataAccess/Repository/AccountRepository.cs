using BusinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        public Account GetAccountById(int id) => AccountDAO.Instance.GetAccountById(id);

        public List<Account> GetActiveDentistList() => AccountDAO.Instance.GetActiveDentistList();

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);   

        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);
    }
}
