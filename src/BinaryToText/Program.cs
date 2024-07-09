internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            var firstByte = args[0];
            int result = 0;

            for (int i = 0; i < firstByte.Length; i++)
            {
                if (firstByte[i] == '1') {
                    result += (int)Math.Pow(2, firstByte.Length - i - 1);
                }
            }

            System.Console.WriteLine(result);
        }
        else
        {
            System.Console.WriteLine("No input detected!");
        }
    }
}