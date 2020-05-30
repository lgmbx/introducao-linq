using System;
using System.Linq;

namespace Introdução_LINQ {
    class Program {
        static void Main(string[] args) {
            //data source
            int[] num = new int[] { 2, 3, 4, 5 };

            //query expression
            var result = num.Where(x => x % 2 == 0)
                            .Select(x => x * 10);


            //execute query
            foreach(int x in result) {
                Console.WriteLine(x);
            }

        }
    }
}
