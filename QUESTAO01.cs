
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LISTA04_ALGOTITMOS
{
    public class QUESTAO01
    {
        public QUESTAO01()
        {
            int num, c, d, u;
            Console.WriteLine("Digite um número de 3 digitos: ");
            num = int.Parse(Console.ReadLine());
            c = num / 100;
            d = (num % 100) / 10;
            u = num % 10;
            int udc = u * 100 + d * 10 + c;
            Console.WriteLine("O número no padrão UDC é: " + udc + "!");
            Console.ReadKey();
        }
    }
}