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
        private int honger = 10;
        public int Id
        {
            get { return id; }
        }

        public int Honger
        {
            get { return honger; }
            set { honger = value; }
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
