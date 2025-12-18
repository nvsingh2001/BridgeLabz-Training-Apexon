namespace collections.Dictionaries;

public class CountFrequency
{
    public static Dictionary<char, int> Frequency(string input)
    {
        Dictionary<char, int> freq = new();
        foreach (var character in input)
        {
            if (!freq.ContainsKey(character))
            {
                freq.Add(character, 0);
            }
            freq[character]++;
        }
        return freq;
    }
}