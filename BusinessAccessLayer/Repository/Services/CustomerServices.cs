using BusinessAccessLayer.Repository.Interface;
using DataAccessLayer;
using ObjectModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Repository.Services
{
    public class CustomerServices : ICustomer
    {
        private readonly ApplicationDbContext _dbcontext;
        public CustomerServices(ApplicationDbContext dbContext)
        {
            _dbcontext=dbContext;
        }


        public List<Customer> GetAllCustomerList()
        {
            var custo = _dbcontext.list
        }


        public Customer CreateNewCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }


        public Customer UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
