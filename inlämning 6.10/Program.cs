using System;

public class Program
{
    public static void Main()
    {
        string text = "5 4,1 hej 9,04";
        int antalTal = AntalTalIText(text);
        Console.WriteLine("Antal tal i texten: " + antalTal);
    }

    public static int AntalTalIText(string text)
    {

        string[] ord = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int antalTal = 0;
        foreach (var ordet in ord)
        {

            if (double.TryParse(ordet, out double tal))
            {
                antalTal++;
            }
        }

        return antalTal;
    }
}
