using EF_Meyawo.DataAccess.Abstract;
using EF_Meyawo.DataAccess.SqlDbContex;
using EF_Meyawo.Entity.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.DataAccess.Concret
{
    public class CustomerRepository : IUserRepository
    {
        private ManagmentSqlDbContex _dbContex;
        public void Add(Customer entity)
        {
            _dbContex.Customers.Add(entity);
            _dbContex.SaveChanges();

        }

        public void Delete(Customer entity)
        {
            _dbContex.Customers.Update(entity);
            _dbContex.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = _dbContex.Customers.ToList();
            return customers;
        }

        public Customer GetByID(int id)
        {
            Customer customer = _dbContex.Customers.Find(id);
            return customer;
        }

        public void Update(Customer entity)
        {
            _dbContex.Customers.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
