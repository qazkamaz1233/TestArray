using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestArray
{
    public class Program
    {
        private const int CountNum = 20;
        private static readonly Random Random = new Random();
        public static void Main(string[] args)
        {
            var array = Enumerable.Range(0, CountNum).Select(_ => Random.Next(10)).OrderBy(x => x).ToArray();

            Console.WriteLine(String.Join(", ", array));

            Console.ReadKey();
        }
    }
}
