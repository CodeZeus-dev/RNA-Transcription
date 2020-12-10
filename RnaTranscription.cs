using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        Dictionary<string, string> complementaryBases = new Dictionary<string, string>();

        complementaryBases.Add("G", "C");
        complementaryBases.Add("C", "G");
        complementaryBases.Add("A", "U");
        complementaryBases.Add("T", "A");

        if (nucleotide.Length == 1) { return complementaryBases[nucleotide]; }

        string[] complementRNA = new string[nucleotide.Length];

        for (int i = 0; i < nucleotide.Length; i++)
        {
            complementRNA[i] = complementaryBases[nucleotide[i].ToString()];
        }

        return String.Join("", complementRNA);
    }
}