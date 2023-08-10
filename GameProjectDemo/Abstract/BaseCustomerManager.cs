using System;
using GameProjectDemo.Concreate;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted to db : " + customer.FirstName + " " +
    customer.LastName + " " + customer.DateOfBirth);
        }

        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName + " " +
    customer.LastName + " " + customer.DateOfBirth);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Updated to db : " + customer.FirstName + " " +
    customer.LastName + " " + customer.DateOfBirth);
        }
    }
}
