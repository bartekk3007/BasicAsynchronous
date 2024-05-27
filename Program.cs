namespace AsynchronousTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int repetitions = 100;
            // Aby zastosować bibliotekę TPL w wersjach starszych niż .NET 4.5, 
            // wywołaj metodę Task.Factory.StartNew<string>().
            Task task = Task.Run(() =>
            {
                for (int count = 0; count < repetitions; count++)
                {
                    Console.Write('-');
                }
            });
            for (int count = 0; count < repetitions; count++)
            {
                Console.Write('+');
            }

            // Oczekiwanie na ukończenie zadania
            task.Wait();
        }
    }
}
