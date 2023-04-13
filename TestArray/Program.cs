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
        private const int NumberStart = 0;
        private const int NumberEnd = 99;
        private static readonly Random Random = new Random();
        public static void Main(string[] args)
        {
            var array = Enumerable.Range(0, CountNum).Select(_ => Random.Next(NumberStart, NumberEnd + 1)).ToArray();


            array = array.OrderBy(x => x).ToArray();

            array.Select((value, index) => $"{index.ToString().PadLeft(2, ' ')}: {value}").ForEach(Console.WriteLine);
            //array.Select((value, index) => $"{index, 2}: {value}").ForEach(Console.WriteLine); тоже что и сверху 


            Console.WriteLine(String.Join(", ", array));

            Console.ReadKey();
        }
    }
}
