namespace _2_Dictionnaires;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, string> dictionary = new Dictionary<char, string>();

        dictionary.Add('a', "Abraham");
        dictionary.Add('b', "Bertrand");
        dictionary.Add('c', "Charly");

        dictionary.Remove('c');

        foreach (var word in dictionary)
            Console.WriteLine($"Key: {word.Key}, Value: {word.Value}");

    }
}

