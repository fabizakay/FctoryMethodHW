using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctoryMethodHW
{
    class createAgian
    {
        public static SecondFactory creat()
        {
            return new SecondFactory("fabi", 40);
        }
    }
}
