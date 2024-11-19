namespace ListTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

            double sum = numbers.Sum();
            double average = sum / numbers.Count;

            average = Math.Round(average, 2);

            Console.WriteLine($"Sum={sum}; Average={average}");
        }
    }
}
