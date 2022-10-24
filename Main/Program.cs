using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker.Faker f = new Faker.Faker();
            Mama ff = f.Create<Mama>();
            //List<int> ff = f.Create<List<int>>();
            Console.WriteLine(JsonConvert.SerializeObject(ff, Formatting.Indented));

            //Console.WriteLine(ff.ToString());
        }
    }
}
