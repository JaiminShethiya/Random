using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = null;
            Random random = new Random();

            randomArray = GenerateArray(randomArray, null);

            int index = random.Next(randomArray.Length);
            var name = randomArray[index];
            Console.WriteLine("Random #: {0}", name);

            randomArray = GenerateArray(randomArray, name);
            index = random.Next(randomArray.Length);
            name = randomArray[index];
            Console.WriteLine("Random #: {0}", name);
            
            Console.ReadLine();
        }

        private static int[] GenerateArray(int[] array, int? value)
        {
            if (!value.HasValue && value == 0)
                return array;

            int[] randomArray = new int[10];
            randomArray = array;
            if (array == null)
                randomArray = new int[10] { 1, 0, 2, 0, 3, 0, 4, 0, 5, 0 };

            if (array != null && (value.HasValue && value.Value != 0))
            {
                for (int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = randomArray[i] * value.Value;
                }
            }

            return randomArray;
        }
    }
}
