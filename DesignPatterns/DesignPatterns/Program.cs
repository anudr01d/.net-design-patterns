using DesignPatterns.Creational.Abstract_Factory;
using DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Greetings! This is the entry point for executing all the design patterns mentioned within this project.
             * Simply set the appropriate enum to view the results for the specific design pattern.
             */

            PatternType patternType = PatternType.Singleton;

            switch(patternType)
            {
                case PatternType.AbstractFactory:
                    Program.invokeAbstractFactory();
                    break;
                case PatternType.Builder:
                    break;
                case PatternType.FactoryMethod:
                    break;
                case PatternType.Prototype:
                    break;
                case PatternType.Singleton:
                    Program.invokeSingleton();
                    break;
                case PatternType.Adapter:
                    break;
                case PatternType.Bridge:
                    break;
                case PatternType.Composite:
                    break;
                case PatternType.Decorator:
                    break;
                case PatternType.Facade:
                    break;
                case PatternType.Flyweight:
                    break;
                case PatternType.Proxy:
                    break;
            }

            Console.WriteLine("Press a key to exit..");
            Console.ReadKey();
        }

        private static void invokeAbstractFactory()
        {
            // Abstract factory #1
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }

        private static void invokeSingleton()
        {
            Singleton instanceOne = Singleton.getInstance();
            Singleton instanceTwo = Singleton.getInstance();

            if(instanceOne==instanceTwo)
            {
                Console.WriteLine("The singleton instances are equal");
            }

        }
    }
}
