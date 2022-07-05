using System;
using BusinessObject.Models;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private static readonly object instanceLock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    {
                        if (instance == null)
                        {
                            instance = new AccountDAO();
                        }
                    }
                    return instance;
                }
            }
        }

        public Account CheckLogin(string username, string password)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    var account = context.Accounts.SingleOrDefault(x => x.Username == username && x.Password == password && x.Status == 1);
                    return account;
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public List<Account> GetActiveDentistList()
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Accounts.Where(a => a.Role == 3 && a.Status == 1).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Account GetAccountById(int id)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Accounts.SingleOrDefault(x => x.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAccount(Account account)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    //check username
                    var a = context.Accounts.Where( x => x.Username == account.Username && x.Id != account.Id).FirstOrDefault();
                    if(a == null)
                    {
                        context.Accounts.Update(account);
                        context.SaveChanges();
                        return;
                    } else
                    {
                        throw new Exception("Username alraedy in use");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
