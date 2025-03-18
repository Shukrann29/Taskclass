using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskclass
{
   public class Dog:Animal 
    {
        public bool HasTail;

        public void bark()
        {
            Console.WriteLine("Dogs are barking");
        }

    }
}
