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