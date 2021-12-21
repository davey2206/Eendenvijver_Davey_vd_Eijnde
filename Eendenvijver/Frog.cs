namespace Eendenvijver
{
    internal class Frog
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