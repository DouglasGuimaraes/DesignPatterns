using FactoryMethod.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Domain.Entities
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return $"{this.GetType().Name} operation.";
        }
    } 
    
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return $"{this.GetType().Name} operation.";
        }
    }
}
