
namespace EstruturaDeRepetição
{
    public class AulaWhile
    {
        public void MetodoWhile()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write(i);
                i++;
            }
        }


        public void TabuadaWhile()
        {
            int i = 0;

            Console.WriteLine("Informe a Tabuada");
            int tabuada = int.Parse(Console.ReadLine());

            while (i < 10)
            {
                Console.WriteLine($"{tabuada}X{i} = {tabuada*i}");
                i++;
            }
        }


        public void Calculos()
        {
            //Instanciando
            Calculos calculos = new Calculos();
            int v1 = 0;
            int v2 = 0;
            string operacao;

            while (true)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("|Informe + para soma         |");
                Console.WriteLine("|Informe * para multiplicação|");
                Console.WriteLine("|Informe - para subtrair     |");
                Console.WriteLine("|Informe / para divisão      |");
                Console.WriteLine("==============================");
                Console.Write("Operação: ");
                operacao = Console.ReadLine();

                Console.Clear();

                //=========Coletar Valores do Usuário
                Console.WriteLine("Informe o primeiro valor");
                v1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo valor");
                v2 = int.Parse(Console.ReadLine());

                //==================Calculos
                switch (operacao)
                {
                    case "+":
                        Console.WriteLine($"Soma:{calculos.Soma(v1, v2)}");
                        break;
                    case "-":
                        Console.WriteLine($"Subtração:{calculos.Subtrair(v1, v2)}");
                        break;
                    case "*":
                        Console.WriteLine($"Multiplicação:{calculos.Multiplicar(v1, v2)}");
                        break;
                    case "/":
                        Console.WriteLine($"Divisão:{calculos.Dividir(v1, v2)}");
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção válida");
                        break;
                }

                //======================Para While
                Console.WriteLine("Deseja Encerrar? s/n");
                if (operacao == "s")
                {
                    Console.Clear();
                    break;
                }

            }

        }
    }
}
