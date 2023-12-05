using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequencia_impares {
    class Program {
        static void Main(string[] args) {

            int x, i;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            for (i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
