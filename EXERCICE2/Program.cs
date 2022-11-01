using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE2
{
    public class Program
    {
        static void Main()
        {
            int i;
            int[] a = new int [30];
            Console.Write("entrez le nombre de valeurs à etre triés : ");
            int n = Convert.ToInt16(Console.ReadLine());
            for ( i = 1; i <= n; i++ )
            {
                Console.Write("entrez le non" + i + ":");
                a[i] = Convert.ToInt16(Console.ReadLine());

            }
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("tri ascendant: ");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.ReadKey();

        }
    }
}




