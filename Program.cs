//inclusão de bibliotecas
using System;
using System.Globalization;
//nome
namespace Course
{
    //classe do programa
    public class Program
    {
        //programa principal em modo público
        public static void Main(string[] args)
        {
            //array com as variáveis das medidas dos triangulos
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");

            //variáveis da área de cada triangulo
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);

            //interface de usuário (to string)
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //condicionais da area dos triangulos
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        //função de leitura das medidas dos triangulos
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            //array que define o número de imputs
            double[] medidas = new double[3];

            //interface de usuário para imputar as medias
            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
            //condicional para os imputs das medidas do triangulo (3 lados)
            for (int i = 0; i < 3; i++)
            {
                //atribuição dos valores
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //retorno ocm as medidas imputadas
            return medidas;
        }
        //função de cálculo da área
        public static double CalcularAreaTriangulo(double[] medidas)
        { 
            //variáveis com os valores imputados das medidas
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];

            //cálculo da área do triangulo
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            //retorno da área
            return area;
        }
    }
}
