using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Telefono
{ 
//All'interno della classe Telefono, viene dichiarato un metodo statico chiamato Check.
    public static string Check(string[] vettoreDiStringhe)
    { //Il metodo Check itera attraverso ogni elemento nella lista vettoreDiStringhe utilizzando un ciclo foreach.
        for (int i = 0; i < vettoreDiStringhe.Length; i++)
        { 
            string cleanedString = vettoreDiStringhe[i].Replace(" ", "").Replace("-", "");
            if (IsItalianPhoneNumber(cleanedString))
            {
                return cleanedString;
            }
        }
        return "";
    }

    private static bool IsItalianPhoneNumber(string str)
    {
        // Controlla se la stringa inizia con +39 ed è lunga 13 caratteri
        if (str.StartsWith("+39") && str.Length == 13)
        {
            return true;
        }

        // Controlla se la stringa inizia con 0039 ed è lunga 14 caratteri
        if (str.StartsWith("0039") && str.Length == 14)
        {
            return true;
        }

        // Controlla se la stringa inizia con 3 ed è lunga 10 caratteri
        if (str.StartsWith("3") && str.Length == 10)
        {
            return true;
        }

        return false;
    }
}

