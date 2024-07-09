internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            string result = "";

            for (int i = 0; i < args.Length; i++)
            {
                result += GetUnicode(args[i]);
            }

            System.Console.WriteLine(result);
        }
        else
        {
            System.Console.WriteLine("No input detected!");
        }
    }

    private static char GetUnicode(string binaryString)
    {
        int unicode = 0;

        for (int i = 0; i < binaryString.Length; i++)
        {
            if (binaryString[i] == '1') {
                unicode += (int)Math.Pow(2, binaryString.Length - i - 1);
            }
        }

        return (char) unicode;
    }
}