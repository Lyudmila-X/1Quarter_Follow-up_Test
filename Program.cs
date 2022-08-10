namespace Test
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите элементы массива через запятую");
            string[] arrayInput = Console.ReadLine()!.Split(",");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ниже представлен введенный вами массив:");
            Console.ForegroundColor = ConsoleColor.White;
            PrintArray(arrayInput);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Массив, который содержит только те элементы, где 3 или менее символов:");
            Console.ForegroundColor = ConsoleColor.White;
            PrintArray(CheckArray(arrayInput));
            Console.WriteLine();
            Console.ReadKey();
        }
        public static string[] CheckArray(string[] arrayInput)
        {
            int count =0;
            for (int i = 0; i < arrayInput.Length; i++) 
            {
                if (arrayInput[i].Length<=3)
                {
                    count++;
                }
            }
            string[] newArray = new string[count];
            int j = 0;
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (arrayInput[i].Length<=3)
                {
                    newArray[j]=arrayInput[i];
                    j++;
                }
            }
            return newArray;
        }
        public static void PrintArray(string[] incomeArray)
        {
            for (int i = 0; i < incomeArray.Length; i++)
            {
                Console.Write(incomeArray[i] + " ");

            }
        }
    }
}