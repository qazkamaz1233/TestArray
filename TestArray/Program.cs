using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestArray.Entityes;

namespace TestArray
{
    public class Program
    {
        private const int CountNum = 20;
        private static readonly Random Random = new Random();
        public static void Main(string[] args)
        {
            var array = Enumerable.Range(0, CountNum).
                Select(_ => new Item { Number = Random.Next(10) }).ToArray();

            array = array.OrderBy(x => x.Number).ToArray();

            Console.WriteLine(String.Join(", ", array.Select(i => $"{i.Number} - {i.Value}")));

            Console.ReadKey();
        }
    }
}
