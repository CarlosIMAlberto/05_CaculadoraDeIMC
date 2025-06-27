using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaraçao de variaveis
            float altura = 0, peso = 0, IMC = 0;

            //Entrada de dados
            Console.WriteLine("Digite o peso (em kg)");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o altura (em metros)");
            altura = float.Parse(Console.ReadLine());

            //Operacão do IMC
            IMC = CalcularIMC(peso, altura);
            Console.WriteLine(AvaliarIMC(IMC));

            //testes
        } 
        public static float CalcularIMC(float peso, float altura)
        { 
            return peso /(altura * altura);
        }
        public static string AvaliarIMC(float IMC)
        {
            if (IMC >= 40)
            {
                return "Está com obesidade grau III (Mórbida)";
            }
            else if (IMC >= 35)
            {
                return "Está com obesidade grau II (Severa)";
            }
            else if (IMC >= 30)
            {
                return "Está com obesidade grau I";
            }
            else if (IMC >= 25)
            {
                return "Está com Sobrepeso";
            }
            else if (IMC >= 18.5)
            {
                return "Está com Peso Normal";
            }
            else
            {
                return "Está abaixo do Peso ";
            }
        }
    }
}
