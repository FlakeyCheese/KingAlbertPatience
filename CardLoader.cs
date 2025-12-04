using CardGame;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class CardLoader
{
    public static Card[] LoadCards(string folderPath)
    {
        var cards = new List<Card>();

        // Check if the folder exists
        if (!Directory.Exists(folderPath))
        {
            throw new DirectoryNotFoundException($"The specified folder was not found: {folderPath}");
        }

        // Get all PNG files in the specified directory
        string[] imageFiles = Directory.GetFiles(folderPath, "*.png");

        // Regex pattern to match the filename structure "intchar"
        // ^(\d+) matches one or more digits at the start of the string
        // ([A-Z]) matches a single uppercase letter
        var regex = new Regex(@"^(\d+)([A-Z])$", RegexOptions.IgnoreCase);

        foreach (string file in imageFiles)
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            Match match = regex.Match(fileName);

            if (match.Success)
            {
                // Extract value and suit from the filename
                int value = int.Parse(match.Groups[1].Value);
                string suit = match.Groups[2].Value;

                // Load the image from the file
                Image face = Image.FromFile(file);

                // Create a new Card object and add it to the list
                cards.Add(new Card(value, suit,face));
            }
        }

        return cards.ToArray();
    }
}

