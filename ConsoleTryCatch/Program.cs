using System.Globalization;

namespace ConsoleTryCatch {

    class Program {
        static void Main()
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine()); 
            int result = 0;
            try
            { 
                result = valor1 / valor2;              

            }
            catch (DivideByZeroException e) // using Upcasting by Exception class and call DivideByZeroException
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {e.Message} \n linha do erro: {e.StackTrace}"); 
            }

            Console.WriteLine("Valor da divisão:" + result.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}