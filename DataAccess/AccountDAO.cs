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
                    var account = context.Accounts.SingleOrDefault(x => x.Username == username && x.Password == password);
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

        public List<Account> GetDentistList()
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Accounts.Where(a => a.Role == 3).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
