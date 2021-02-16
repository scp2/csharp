using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Variáveis de tipo inteiro");
            // int support 32 bits | short 16 bits
            int indade = 23; //inteiro

            // Variáveis do tipo double e float:
            // double(Maior quandide de números após o ponto)
            // para utilizar o float, é necessário informar com um f após o valor. 

            float test = 1.80f;
            double testDouble = 1.80;

            // long support 64bits
            long salarioLong = 130000000000000;
            double salario = 5000.32; //double
            System.Console.WriteLine("Salário: " + salario);

            // Exemplo de casting
            int salarioEmInteiro = (int) salario;
            Console.WriteLine("Salário após o casting" + salarioEmInteiro);

            System.Console.WriteLine("Variáveis de tipo char");

            // character
            char primeiraLetra = 'a';
            System.Console.WriteLine(primeiraLetra);

            // type casting de int para char
            primeiraLetra = (char) 65;
            System.Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);

            // Variável do tipo string 
            string text = "Variável do tipo texto";
            System.Console.WriteLine(text);


        }
    }
}
