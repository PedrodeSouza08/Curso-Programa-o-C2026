using System.ComponentModel.Design;

namespace CursoProgramacao
{
    public class Aula2
    {
        public void ValorPar()
        {
            Console.WriteLine("Informe um valor:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
                
        }
        public void MaiorIdade()
        {
            Console.WriteLine("Informe a Idade:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 18 >= 0)
            {
                Console.WriteLine("Maior de Idade");
            }
            else
            {
                Console.WriteLine("Menor de Idade");
            }
        }
        public void Nota()
        {
            Console.WriteLine("Informe sua Nota");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
