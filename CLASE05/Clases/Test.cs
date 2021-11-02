using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE05.Clases
{
    class Test
    {       
        private int val;

        public Test(int val)
        {
            this.val = val;
        }
        public override string ToString()
        {
            return "Val: " + val.ToString();
        }
    }
}
