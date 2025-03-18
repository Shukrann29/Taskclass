using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskclass
{
    class Formattedstring
    {
        public static string GetFullName(string name,string surname)
        {
            return $"{name} {surname}";
        }
    }
}
