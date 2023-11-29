namespace YieldREturnApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseSTudy1();

            var query = GenerateFibonacciSequence(1000);

            foreach (var fibonacci in query)
            {
                Console.WriteLine(fibonacci);
            }

            Console.WriteLine("end");
        }

        private static void CaseSTudy1()
        {
            var query = GetData();

            foreach (var item in query)
            {

                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> GenerateFibonacciSequence(int limit)
        {
            int current = 0;
            int next = 1;

            while (current <= limit)
            {
                // Yield the current Fibonacci number
                yield return current;

                // Update the Fibonacci sequence for the next iteration
                int temp = current;
                current = next;
                next = temp + next;
            }
        }
        static IEnumerable<int> GetData() {
           yield return 10;
           yield return 20;
           yield return 30;
        }
    }
}