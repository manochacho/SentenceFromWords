
Console.WriteLine("Enter words of a sentence one by one including punctuation:");

// liste til at gemme de indtastede ord
var words = new List<string>();

// uendelig loop, der fortsætter indtil break-kommando udføres
while (true)
{
    var input = Console.ReadLine();
    
    // Tilføjer det indtastede input til listen
    words.Add(input);
    
    // Samler inputs i listen til én streng med mellemrum hver input
    string phrase = string.Join(" ", words);

    if (input.EndsWith("."))
    {
       Console.WriteLine($"<{phrase}>");
       break;
    }
}
