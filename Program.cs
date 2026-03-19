internal class Program
{
    private static void Main(string[] args)
    {
        //Entrada
        Console.WriteLine("===Números Positivos o Negativos===");
        int num;
        Console.Write("Dame un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        //Proceso
        //Salida
        if (num >= 0)
        {
            Console.WriteLine("Es un número positivo");
        }
        else 
        {
            Console.WriteLine("Es un número negativo");
        }
    }
}