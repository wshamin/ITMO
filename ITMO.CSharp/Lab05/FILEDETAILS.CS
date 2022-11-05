
using System;                // Console
using System.IO;             // FileStream, FileReader
    
class FileDetails 
{
    static void Main(string[ ] args) 
	{
        Console.WriteLine("Длина массива args равна " + args.Length);

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        string fileName = args[0];

        FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);

        char[] contents = new char[stream.Length];
        int i = 0;

        foreach (char c in reader.ReadToEnd()) contents[i++] = c;

        // foreach (char c in contents) Console.Write(c);

        reader.Close();

        Summarize(contents);

        stream.Close();
    }

    public static void Summarize(char[] charArray)
    {
        int vowels = 0, consonants = 0, lines = 0;

        foreach (char c in charArray)
        {
            if ("AEIOUaeiou".IndexOf(c) != -1) vowels++;
            else if (c == '\n') lines++;
            else consonants++;
        }

        Console.WriteLine("Total no of characters = " + charArray.Length);
        Console.WriteLine("Total no of vowels = " + vowels);
        Console.WriteLine("Total no of consonants = " + consonants);
        Console.WriteLine("Total no of lines = " + lines);
    }
}
