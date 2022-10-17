
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LISTA04_ALGOTITMOS
{
    public class QUESTAO03
    {
        public QUESTAO03()
        {
            double baseRetangulo, altura, perimetro, area, diagonal;
            Console.WriteLine("QUAL A BASE DO RETANGULO? ");
            baseRetangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("QUAL A ALTURA DO RETANGULO? ");
            altura = double.Parse(Console.ReadLine());

            perimetro = 2*(baseRetangulo + altura);
            area = (baseRetangulo * altura);
            diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(altura, 2));

            Console.WriteLine($"O retangulo cuja base é {baseRetangulo} e a altura é {altura} possui as seguntes medidas: area = {area}, perimetro = {perimetro} e diagonal = {diagonal}!");
        }
    }
}