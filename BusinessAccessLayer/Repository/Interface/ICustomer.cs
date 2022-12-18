using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Repository.Interface
{
    public interface ICustomer
    {
        List<Customer> GetAllCustomerList();   
        Customer CreateNewCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);

    }
}
