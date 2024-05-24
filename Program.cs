namespace Stopwatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            App();
        }

        static void App()
        {
            Console.Clear();
            Console.WriteLine("Digite o Tempo");

            int tempoInicial = 0;
            int tempoLimite = int.Parse(Console.ReadLine());

            while (tempoLimite != tempoInicial)
            {
                Console.Clear();
                Console.WriteLine(tempoInicial);
                ++tempoInicial;
                Thread.Sleep(1000);
            }

            Console.WriteLine("Cronometro Finalizado.");

        }

    }
}