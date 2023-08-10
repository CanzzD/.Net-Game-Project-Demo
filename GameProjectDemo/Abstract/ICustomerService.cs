using System;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concreate
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
