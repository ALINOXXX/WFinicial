namespace CEX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° Número!");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite 0 2° Número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\n0 Numero {maior} é o maior valor!");
        }
    }
}
