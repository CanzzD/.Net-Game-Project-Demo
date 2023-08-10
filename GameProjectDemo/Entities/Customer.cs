using System;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class Customer : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationatyId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
