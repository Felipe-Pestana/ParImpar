namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0, fim = 0, aux = 0;
            
            Console.WriteLine("Informe o número de início:");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de fim:");
            fim = int.Parse(Console.ReadLine());

            Console.WriteLine("Pares");
            for (int i = inicio+1; i < fim; i++)
            {
                if((i)%2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\nImpares");
            aux = inicio;
            
            do
            {
                aux++;
                if(aux%2 != 0)
                    Console.Write(aux + " ");
            }while(aux < fim);

        }
    }
}
