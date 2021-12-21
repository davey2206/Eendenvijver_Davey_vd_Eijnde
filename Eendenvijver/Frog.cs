using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    class Frog
    {
        private int id;
        private bool dead = false;

        public bool Dead
        {
            get { return dead; }
            set { dead = value; }
        }
        public int Id
        {
            get { return id; }
        }

        public Frog(int i)
        {
            id = i;
        }
    }
}
