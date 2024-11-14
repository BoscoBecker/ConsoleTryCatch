namespace ConsoleTryCatch {

    class Program {
        static void Main()
        {
            int valor1 = 0;
            int valor2 = 0;
            int result = 0;
            try
            {
                result = valor1 / valor2;                

            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {e.Message} \n linha do erro: {e.StackTrace}"); 
            }

        }
    }
}