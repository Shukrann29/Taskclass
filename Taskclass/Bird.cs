﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Taskclass
{
    public class Bird:Animal 
    {
        public bool canswim;
        
        public void fly()
        {
            Console.WriteLine("fly");
        }
    }
}
