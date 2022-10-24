using System;

namespace Main
{
    public class Mama
    {
        public string papa;
        public int brat;
        public long cat { get; set; }
    }
    public class User
    {
        public String name;
        public int age;
        public Dog[] dogs;
        public long test { get; set; }
        private float money = 10.5f;
        public Profile profile;
    }

    public class Dog
    {
        public string name;
        
        public Dog(string name)
        {
            this.name = name;
          
        }

    }

    public class Profile
    {
        public string address;
        public Profile(string address)
        {
            this.address = address;
        }
 
    }
}
