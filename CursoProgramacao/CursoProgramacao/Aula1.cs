using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
    public class Aula1
    {
        int valor1;
        int valor2;

        //Método Soma
        public void Soma()
        {


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 + valor2}");
        }

        //Multiplicar
        public void Multipilcar()
        {


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 * valor2}");
        }

        //Subtrair
        public void Subtrair()
        {


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 - valor2}");
        }

        //Divisão
        public void Dividir()
        {


            Console.WriteLine("Informe o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {valor1 / valor2}");
                
        }



    }
}
        
         

        

