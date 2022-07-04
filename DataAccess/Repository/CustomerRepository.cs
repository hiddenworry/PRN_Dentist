using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        void ICustomerRepository.AddNewCustomer(Customer newCustomer) => CustomerDAO.Instance.AddCustomer(newCustomer);

        List<Customer> ICustomerRepository.GetAll() => CustomerDAO.Instance.GetAllCustomer();

        Customer ICustomerRepository.GetById(int id) => CustomerDAO.Instance.GetCustomerById(id);

        void ICustomerRepository.UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);
    }
}
