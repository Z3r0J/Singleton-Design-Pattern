using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    public sealed class Singleton
    {
        public static Singleton instance { get; } = new Singleton();

        public List<CarsClass> Cars = new List<CarsClass>();
        private Singleton()
        {

        }
    }
}
