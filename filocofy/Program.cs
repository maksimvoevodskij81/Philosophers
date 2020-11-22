using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filocofy.classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            Fork fork1 = new Fork("Fork1");
            Fork fork2 = new Fork("Fork2");
            Fork fork3 = new Fork("Fork3");
            Fork fork4 = new Fork("Fork4");
            Fork fork5 = new Fork("Fork5");
            Philosopher philosopher1 = new Philosopher("Diagen",fork1,fork5,waiter);
            Philosopher philosopher2 = new Philosopher("Kant",fork2,fork1,waiter);
            Philosopher philosopher3 = new Philosopher("Aristotel",fork3,fork2,waiter);
            Philosopher philosopher4 = new Philosopher("Nedshe",fork4,fork3,waiter);
            Philosopher philosopher5 = new Philosopher("Spenoza",fork5,fork4,waiter);
            Console.ReadKey();
        }
    }
}
