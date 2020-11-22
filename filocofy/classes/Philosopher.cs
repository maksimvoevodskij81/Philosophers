using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace filocofy.classes
{
    class Philosopher
    {
        public string Name { get; set; }
        public Fork left { get; set; }
        public Fork right { get; set; }
        public AutoResetEvent resetEvent { get; set; }
        public Waiter waiter { get; set; }
        static Random random = new Random();
        public Philosopher(string _Name,Fork _left,Fork _right,Waiter _waiter)
        {
            Name = _Name;
            left = _left;
            right = _right;
            waiter = _waiter;
            resetEvent = new AutoResetEvent(false);
            Task.Run(() => Process());


        }
        public void Process()
        {
            while (true) 
            {
                if (random.Next(0,11)%2 == 0)
                {
                    Console.WriteLine(Name+" Get Hungry !!!");
                    waiter.hungryPhilosophers.Add(this);
                    resetEvent.WaitOne();
                    Console.WriteLine(Name+"start to eat ");
                    Thread.Sleep(3000);
                    resetEvent.Set();
                    Console.WriteLine(Name +"  is Finish eating");


                }
                else
                {
                    Console.WriteLine(Name+"Fall asleep");
                    Thread.Sleep(3000);
                }
            }
        }

    }
}
