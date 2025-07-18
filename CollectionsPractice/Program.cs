namespace CollectionsPractice
{
    internal class Program
    {
        private const int ASCII_SHIFT = 48;

        static void Main(string[] args)
        {
            List<int> inputList = [];
            ConsoleKeyInfo keyInfo;

            Console.WriteLine("Input a list");

            while ((keyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
            {
                inputList.Add(keyInfo.KeyChar - ASCII_SHIFT);
            }

            Console.WriteLine();
            SingleNumber onlyOneTime = new();

            Console.WriteLine("result: ");
            foreach (int number in onlyOneTime.GetSingleNumbersOf(inputList))
            {
                Console.Write(number);
            }
        }
    }
}
