using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        public static Singleton _instance;

        protected Singleton() { }

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
