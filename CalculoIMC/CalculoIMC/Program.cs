using System.Xml.Serialization;

partial class Program
{
    static void Main(string[] args)
    {
        float peso;
        float altura;
        float resultado;
        string opcao;

        while (true)
        {
            //Informar peso
            Console.WriteLine("Informe seu peso");
            peso = float.Parse(Console.ReadLine());

            //Informar altura
            Console.WriteLine("Informe a altura");
            altura = float.Parse(Console.ReadLine());


            resultado = peso / (altura * altura);
            Console.Clear();
            //Resultado
            Console.WriteLine($"IMC: {resultado} ");

            //Opção
            Console.WriteLine("Deseja calcular outro IMC s/n");
            opcao = Console.ReadLine();

            if (opcao != "s")
            {
                break;
            }
            Console.Clear();
        }
    }
}