using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resS;
            int resR;
            int resM;
            int resD;

            Console.WriteLine("Ingrese un número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            resS = num1 + num2;
            resR = num1 - num2;
            resM = num1 * num2;
            resD = num1 / num2;

            Console.WriteLine("Si los sumas será: " + resS);
            Console.WriteLine("Si los restas será: " + resR);
            Console.WriteLine("Si los multiplicas será: " + resM);
            Console.WriteLine("Si los divides será: " + resD);
            Console.WriteLine("NO INCLUYEN DECIMALES");

            Console.ReadLine();
        }
    }
}
