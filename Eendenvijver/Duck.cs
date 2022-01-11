using System;
namespace Eendenvijver
{
    public enum Gender
    {
        female,
        male
    }

    internal class Duck
    {
        private int age = 100;
        private Gender gender;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Duck(int r)
        {
            int g;
            if (r == 1)
            {
                g = 0;
            }
            else
            {
                g = 1;
            }

            if (g == 0)
            {
                gender = Gender.male;
            }
            else if (g == 1)
            {
                gender = Gender.female;
            }
        }

        public bool ageDuck(int r)
        {
            switch (r)
            {
                case 1:
                    age = age - 1;
                    break;

                case 2:
                    age = age - 5;
                    break;

                case 3:
                    age = age - 10;
                    break;
            }
            if (age <= 0)
            {
                return true;
            }
            return false;
        }
    }
}