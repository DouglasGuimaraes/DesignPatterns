using FactoryMethod.Domain.Abstract;
using FactoryMethod.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Main
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());

            Console.ReadKey();
        }
        public static void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }

    }
}
