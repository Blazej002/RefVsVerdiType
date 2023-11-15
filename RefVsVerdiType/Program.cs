namespace RefVsVerdiType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int totalLetters = 0;
            string text = "b";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine() ?? string.Empty;
                foreach (var character in text.ToLower())
                {   totalLetters++;
                    counts[(int)character]++;
                }

                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var prosent = 100 * counts[i] / totalLetters;

                        if (char.IsDigit(character))
                        {
                            Console.Write(character);
                            int d = int.Parse(character.ToString()); 
                            for (int j = 0; j < d; j++)
                            {
                                Console.Write("0");
                            }
                            Console.WriteLine("");
                            string zput = character + " - " + prosent.ToString("F1") + "%";
                            Console.CursorLeft = Console.BufferWidth - zput.Length -10;
                            Console.WriteLine(zput);
                            continue;
                        }
                        string output = character + " - " + prosent.ToString("F1") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}