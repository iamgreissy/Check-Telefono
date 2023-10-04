# Check-Telefono

La classe "Telefono" è stata progettata per cercare numeri di telefono italiani all'interno di un array di stringhe.

Il Metodo Check:

Il metodo Check prende in input un array di stringhe chiamato vettoreDiStringhe, che rappresenta una serie di dati tra cui potrebbero esserci numeri di telefono italiani.
Per ogni stringa all'interno dell'array, il metodo esegue una serie di controlli per determinare se quella stringa è un numero di telefono italiano.
Pulizia delle Stringhe

Prima di effettuare qualsiasi controllo, il metodo pulisce la stringa rimuovendo spazi bianchi e trattini e questo passaggio è fondamentale perché i numeri di telefono possono contenere vari spazi e caratteri speciali.

Il Metodo IsItalianPhoneNumber:
Questo metodo privato è responsabile di verificare se una data stringa è effettivamente un numero di telefono italiano.

Il metodo segue tre criteri specifici per identificare un numero di telefono italiano:

Verifica se la stringa inizia con "+39" ed è lunga 13 caratteri.
Verifica se la stringa inizia con "0039" ed è lunga 14 caratteri.
Verifica se la stringa inizia con "3" ed è lunga 10 caratteri.
Se una di queste condizioni è soddisfatta, il metodo ritorna "true", altrimenti ritorna "false".

Restituzione del Risultato:

Dopo aver esaminato tutte le stringhe nell'array e applicato i controlli del metodo IsItalianPhoneNumber, il metodo Check restituisce la prima stringa che corrisponde a un numero di telefono italiano. Se non viene trovato nessun numero italiano, viene restituita una stringa vuota.
Test di Verifica

Per assicurarsi che il codice funzioni correttamente, abbiamo implementato una serie di test di verifica. Questi test includono situazioni in cui ci sono numeri con prefissi diversi o formati variabili. Se il codice supera tutti questi test, possiamo essere sicuri della sua correttezza.
In breve, questa classe e il suo metodo Check forniscono un modo affidabile per identificare numeri di telefono italiani all'interno di un insieme di dati, rimuovendo problemi di formattazione e garantendo la conformità ai requisiti specifici per i numeri di telefono italiani.
``` C#
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//Viene dichiarata una classe chiamata Telefono.
public class Telefono
{ 
//All'interno della classe Telefono, viene dichiarato un metodo statico chiamato Check.
    public static string Check(string[] vettoreDiStringhe)
    { //Il metodo Check itera attraverso ogni elemento nella lista vettoreDiStringhe utilizzando un ciclo foreach.
        foreach (string stringa in vettoreDiStringhe)
        { 
            // Rimuovi spazi bianchi e trattini dalla stringa
            string cleanedString = stringa.Replace(" ", "").Replace("-", "");

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
``` 
