using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctoryMethodHW
{
    class Create
    {
        public static FirstFactory create()
        {
            return new FirstFactory();
        }
    }
}
