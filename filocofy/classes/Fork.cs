using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace filocofy
{
    [Synchronization]
    class Fork
    {

        public  string Name { get; set; }
        public bool isLock { get; set; }//свободна или занята 
        public Fork(string _Name)
        {
            Name = _Name;
            isLock = false;
        }
    }
}
