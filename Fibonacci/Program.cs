
internal class Program
{
    public static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        int previous = 0;
        int current = 1;
        for (int i = 2; i <= n; i++)
        {
            int next = previous + current;
            previous = current;
            current = next;
        }
        return current;
    }
    private static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        var result = new int[number + 1];
        int buff;
        for (int i = 0; i < number + 1; i++)
        {
            buff = Fibonacci(i);
            result[i] = buff;
        }

        foreach (int i in result) 
        {
            Console.Write($"{i} ");
        }
    }
}