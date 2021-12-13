using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    class Stork
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        public Stork(int i)
        {
            id = i;
        }
        public void eat(Frog f)
        {
            f = null;
        }
    }
}
