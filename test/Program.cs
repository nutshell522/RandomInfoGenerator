using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ted.RandomInfoGenerator;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //測試姓名 random provider
           Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 2000; i++)
            {
                bool gender = rnd.Next(0, 2) == 1;
                var name = new TWNamesGenerator(gender,20).Info;
                string genderStr = gender ? "男" : "女";
                Console.WriteLine($"{genderStr}_{name}");
            }
            Console.ReadLine();
        }
    }
}
