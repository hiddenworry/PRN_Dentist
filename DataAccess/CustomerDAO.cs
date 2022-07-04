using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess
{
    public class CustomerDAO
    {

        private static CustomerDAO instance;
        private static readonly object InstanceLock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public void UpdateCustomer(Customer newCustomer)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    context.Customers.Update(newCustomer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Customer GetCustomerById(int id)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    var customer = context.Customers.Where(x => x.Id == id).FirstOrDefault();
                    return customer;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddCustomer(Customer newCustomer)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    throw new Exception(newCustomer.Dob.ToString());
                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetAllCustomer()
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
