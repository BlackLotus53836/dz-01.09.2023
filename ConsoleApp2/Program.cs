public class Answer
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[8];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100); // Генерация случайного числа от 0 до 99
        }

        Console.Write("Случайные числа: [");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);

            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]");
    }
}
