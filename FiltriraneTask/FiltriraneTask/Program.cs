namespace FiltriraneTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
            ;
            numbers.RemoveAll(i => i < 0);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
