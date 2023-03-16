namespace DiamanteX.NewConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante X");

            Console.Write("Digite um número ímpar: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 != 0)
            {

                // NUM = NUMERO SOLICITADO
                //  i = espaço
                // y = escreve x

                for (int i = 1; i <= num; i += 2)
                {
                    for (int y = 0; y < (num - i) / 2; y++)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y < i; y++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                }


                for (int i = num - 2; i >= 1; i -= 2)
                {
                    for (int y = 0; y < (num - i) / 2; y++)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y < i; y++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();

                }
            }
            else 
            {
                if (num % 2 == 0);
                {
                    Console.WriteLine("Número inválido, tente novamente: ");
                }
                
                
                
            }
         
        }
    }
}
    