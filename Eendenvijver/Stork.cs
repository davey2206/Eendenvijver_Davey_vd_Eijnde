namespace Eendenvijver
{
    internal class Stork
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

        public Stork(int i, int h)
        {
            id = i;
            honger = h;
        }

        public void eat(Frog f)
        {
            f.Dead = true;
        }
    }
}