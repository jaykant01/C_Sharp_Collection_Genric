using System;
using System.Collections.Generic;
using System.IO;

namespace Collections;

public class WordFrequencyCounter
{
    public Dictionary<string, int> CountWords()
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string text = File.ReadAllText(
            @"D:\C# All Repo\C_Sharp_Collection_Genric\Collections\Map\input.txt");

        string[] words = text
            .ToLower()
            .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                   StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        return wordCount;
    }
}
