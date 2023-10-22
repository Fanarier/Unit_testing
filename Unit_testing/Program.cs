// See https://aka.
internal class Program
{
    private static void Main(string[] args)
    {
        int N = 5;
        int result = GetTotalDivisorsInRange(N);
        Console.WriteLine(result);
    }

    private static int GetTotalDivisorsInRange(int N)
    {
        int totalDivisors = 0;


        for (int i = N; i <= 2 * N; i++)
        {

            int divisors = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    divisors++;
                }
            }


            totalDivisors += divisors;
        }

        return totalDivisors;
    }
}