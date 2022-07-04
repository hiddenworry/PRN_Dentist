using BusinessObject.Models;
using System;

namespace DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        Account IAccountRepository.CheckLogin(string username, string password) => AccountDAO.Instance.CheckLogin(username, password);
    }
}
