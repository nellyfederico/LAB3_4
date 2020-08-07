using System;

namespace LAB3_4Regex
{
    class Program
    {
        static void Main(string[] args)
        {
        string pattern = @"[d-e]"; // 67 Matches.
        string pattern = @"[d-e][*d]"; //5 Matches.
        string pattern = @"[a][a-z][a]"; // 4 Matches.
        string pattern = @"[ ][p][a-z]*"; // 6 Matches.
        string pattern = @"[a-z]*[e][ ]"; // 16 Matches.
        string pattern = @"[A-Z]"; // 31 Matches.
        string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
            {
        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
        }
    }
}