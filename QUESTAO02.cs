
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LISTA04_ALGOTITMOS
{
    public class QUESTAO02
    {
        public QUESTAO02()
        {
            double cateto_1, cateto_2, hipotenusa;
            Console.WriteLine("DIGITE O VALOR DO PRIMEIRO CATETO: ");
            cateto_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O VALOR DO SEGUNDO CATETO: ");
            cateto_2 = double.Parse(Console.ReadLine());
            hipotenusa = Math.Sqrt(Math.Pow(cateto_1, 2) + Math.Pow(cateto_2, 2));
            Console.WriteLine($"O valor da hipotenusa do triangulo retangulo é: {hipotenusa}");
            Console.ReadKey();
        }
    }
}