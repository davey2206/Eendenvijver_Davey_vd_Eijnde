using System;
using System.Collections.Generic;

namespace Eendenvijver
{
    internal class Lake
    {
        private Random rng = new Random();
        private List<Duck> ducks = new List<Duck>();
        private List<Duck> toRemoveDucks = new List<Duck>();
        private List<Frog> frogs = new List<Frog>();
        private List<Stork> storks = new List<Stork>();
        private List<Stork> toRemoveStorks = new List<Stork>();
        private List<Frog> toRemoveFrogs = new List<Frog>();
        private int frogID = 1;
        private int storkID = 1;

        #region wordt niet meer gebruikt

        public void CreateLake()
        {
            for (int i = 1; i < 27; i++)
            {
                rngGender();
            }

            for (int i = 1; i < 20; i++)
            {
                frogs.Add(new Frog(frogID++));
            }

            for (int i = 1; i < 3; i++)
            {
                storks.Add(new Stork(i, rng.Next(1, 11)));
            }
        }

        #endregion wordt niet meer gebruikt

        public List<Duck> getDucks()
        {
            return ducks;
        }

        public List<Frog> getFrogs()
        {
            return frogs;
        }

        public List<Stork> getStorks()
        {
            return storks;
        }

        public void age()
        {
            foreach (var duck in ducks)
            {
                int r = rng.Next(1, 4);
                switch (r)
                {
                    case 1:
                        duck.Age = duck.Age - 1;
                        break;

                    case 2:
                        duck.Age = duck.Age - 5;
                        break;

                    case 3:
                        duck.Age = duck.Age - 10;
                        break;
                }
                if (duck.Age <= 0)
                {
                    toRemoveDucks.Add(duck);
                }
            }
        }

        public void Delete()
        {
            ducks.RemoveAll(toRemoveDucks.Contains);
            storks.RemoveAll(toRemoveStorks.Contains);
            frogs.RemoveAll(toRemoveFrogs.Contains);
        }

        public void CreateDucks()
        {
            int Mcount = 0;
            int Fcount = 0;
            foreach (var duck in ducks)
            {
                if (duck.Gender == Gender.male)
                {
                    Mcount++;
                }
                else if (duck.Gender == Gender.female)
                {
                    Fcount++;
                }
            }

            if (Mcount != 0 && Fcount != 0)
            {
                if (Mcount > Fcount)
                {
                    double count = Mcount / 2;
                    count = Math.Round(count);
                    for (int i = 0; i < count; i++)
                    {
                        int r = rng.Next(5);
                        if (r == 1)
                        {
                            rngGender();
                        }
                    }
                }
                else
                {
                    double count = Fcount / 2;
                    count = Math.Round(count);
                    for (int i = 0; i < count; i++)
                    {
                        int r = rng.Next(5);
                        if (r == 1)
                        {
                            rngGender();
                        }
                    }
                }
            }
        }

        public void createFrogs()
        {
            if (rng.Next(1, 5) == 1)
            {
                if (!(frogs.Count <= 1))
                {
                    int r = rng.Next(1, 3);
                    for (int i = 0; i < r; i++)
                    {
                        frogs.Add(new Frog(frogID++));
                    }
                }
            }
        }

        public void addFrog(int n)
        {
            for (int i = 0; i < n; i++)
            {
                frogs.Add(new Frog(frogID++));
            }
        }

        public void addStork(int n)
        {
            for (int i = 0; i < n; i++)
            {
                storks.Add(new Stork(storkID++, rng.Next(1, 11)));
            }
        }

        public void addDuck(int n)
        {
            for (int i = 0; i < n; i++)
            {
                rngGender();
            }
        }

        public void rngGender()
        {
            int g;
            if (rng.Next(0, 2) == 1)
            {
                g = 0;
            }
            else
            {
                g = 1;
            }
            ducks.Add(new Duck(g));
        }

        public void EatFrog()
        {
            foreach (var stork in storks)
            {
                stork.Honger--;
                if (!(frogs.Count < 1))
                {
                    if (stork.Honger == 0)
                    {
                        stork.Honger = 10;
                        int r = rng.Next(0, frogs.Count);
                        stork.eat(frogs[r]);
                    }
                    foreach (var frog in frogs)
                    {
                        if (frog.Dead)
                        {
                            toRemoveFrogs.Add(frog);
                        }
                    }
                }
                else
                {
                    if (stork.Honger == 0)
                    {
                        toRemoveStorks.Add(stork);
                    }
                }
            }
        }
    }
}