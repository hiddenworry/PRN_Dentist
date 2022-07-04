using System;
using BusinessObject.Models;
namespace DataAccess
{
    public interface IAccountRepository
    {
        Account CheckLogin(string username, string password);
    }
}
