internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            var firstByte = args[0];
            int unicode = 0;

            for (int i = 0; i < firstByte.Length; i++)
            {
                if (firstByte[i] == '1') {
                    unicode += (int)Math.Pow(2, firstByte.Length - i - 1);
                }
            }

            System.Console.WriteLine((char) unicode);
        }
        else
        {
            System.Console.WriteLine("No input detected!");
        }
    }
}