using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDeRepetição
{
    public class AulaFor
    {
        public void MetodoFor()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Tabuada()
        {
            //Exibi uma Mensagem para o Usuário
            Console.WriteLine("Informe a Tabuada");

            //Recebe o valor do Usuário
            int tabuada = int.Parse(Console.ReadLine());

            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine($"{tabuada}X{i}= {tabuada * i}"); 
            }

        }
        public void SomaFor()
        {
            int valor = 0;
            int resultado = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Informe {i}º valor");
                valor = int.Parse(Console.ReadLine());

                resultado = resultado + valor;
            }
            Console.WriteLine($"Total da soma: {resultado}");
        }
        public void MultiFor()
        {
            int valor;
            int resultado = 1;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Informe {i}° valor");
                valor = int.Parse(Console.ReadLine());

                resultado = resultado * valor;
            }
            Console.WriteLine($"Total da Multiplicação: {resultado}");

        }
    }
}
