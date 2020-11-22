using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filocofy.classes
{
    class Waiter
    {
        public List<Philosopher> hungryPhilosophers { get; set; }
        public Waiter()
        {
            hungryPhilosophers = new List<Philosopher>();
            Task.Run(() => CheckHungry());
        }
        public void CheckHungry()
        {
            while (true)
            {
                if (hungryPhilosophers.Count > 0)
                {
                    try
                    {
                        foreach (Philosopher philosopher in hungryPhilosophers)
                        {
                            if (philosopher.left.isLock==false&&philosopher.right.isLock==false)
                            {
                                philosopher.right.isLock = true;
                                philosopher.left.isLock = true;
                                hungryPhilosophers.Remove(philosopher);
                                philosopher.resetEvent.Set();
                                Task.Run(()=>WaitUntilEating(philosopher));

                            }

                        }

                    }
                    catch (Exception  )
                    {

                        Console.WriteLine("");
                    }
                }
            }
           
        }
        public void WaitUntilEating(Philosopher philosopher)
        {
            philosopher.resetEvent.WaitOne();
            philosopher.left.isLock = false;
            philosopher.right.isLock = false;

        }
    }
}
