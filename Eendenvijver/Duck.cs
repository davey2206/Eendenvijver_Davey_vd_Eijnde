using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    public enum Gender
    {
        female,
        male
    }

    class Duck
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

        public Duck(int g)
        {
            if (g == 0)
            {
                gender = Gender.male;
            }
            else if (g == 1)
            {
                gender = Gender.female;
            }
        }
    }
}
