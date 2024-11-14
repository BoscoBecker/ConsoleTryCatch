using System.Globalization;

namespace ConsoleTryCatch {

    class Program {
        static void Main()
        {
            int valor1 = 0;
            int valor2 = 0;
            int result = 0;
            try
            {
                valor1 = int.Parse(Console.ReadLine());
                valor2 = int.Parse(Console.ReadLine());
                result = valor1 / valor2;

            }
            catch (DivideByZeroException e) // using Upcasting by Exception class and call DivideByZeroException
            {
                Console.WriteLine($"Divisão por zero(0) não é permitida.\n linha do erro: {e.StackTrace}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Apenas números são permitidos.\n linha do erro{e.StackTrace}");
            }
            
            finally{
                Console.WriteLine("Valor da divisão:" + result.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Finalizou o programa usando finally.");
            }
        }        
    }
}