using System;
using System.Security.Cryptography;

Console.WriteLine("Registrierung:");
Console.WriteLine("Was willst du als Username festlegen?");
string userName = Console.ReadLine();

Console.WriteLine("Was willst du als Passwort festlegen?");
string passWort = Console.ReadLine();
Console.Clear();

Console.WriteLine("Gib deinen Username ein:");
string usernameEingabe = Console.ReadLine();
Console.WriteLine("Gib dein Passwort ein:");
string passwortEingabe = Console.ReadLine();
Console.Clear();

if (usernameEingabe == userName)
{
    if (passwortEingabe == passWort) //Abgleich um zu sehen ob die Daten mit der Registrierung übereinstimmen
    {

        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Wilkommen! Du kannst hier kannst du dinge Rechnen!");
        Console.WriteLine("Was willst du berechnen Lassen? Quadrat (1) | Dreieck (2) | Rechteck (3) | Kreis (4) ");
        string themenWahl = Console.ReadLine();
        if (themenWahl == "Quadrat")
        {
            Console.WriteLine("Was willst du Berechnen? Diagonale (1) | Fläche (2) | Umfang (3)");
            string quadratThemenwahl = Console.ReadLine();
            if (quadratThemenwahl == "1" || quadratThemenwahl == "Diagonale")
            {
                Console.WriteLine("Was ist die Seitenlänge von A?");
                double quadratSeiteA = double.Parse(Console.ReadLine());

                double quadratDiagonale = Math.Sqrt(Math.Pow(quadratSeiteA, 2) + Math.Pow(quadratSeiteA, 2));
                Console.WriteLine("Die Diagonale D beträgt: " + quadratDiagonale);
            }
            if (quadratThemenwahl == "2" || quadratThemenwahl == "Fläche")
            {
                Console.WriteLine("Was ist die Seitenlänge von A?");
                double quadratSeiteA = double.Parse(Console.ReadLine());

                double quadratFläche = quadratSeiteA * quadratSeiteA;
                Console.WriteLine("Die Fläche beträgt:" + quadratFläche);
            }
            if (quadratThemenwahl == "3" || quadratThemenwahl == "Umfang") ;
            {
                Console.WriteLine("Was ist die Seitenlänge von A?");
                double quadratSeiteA = double.Parse(Console.ReadLine());

                double quadratUmfang = quadratSeiteA * 4;
                Console.WriteLine("Der Umfang beträgt: " + quadratUmfang);
            }
            if (themenWahl == "2" || themenWahl == "Dreieck")
            {
                Console.WriteLine("Was willst du Berechnen? Kathete (1) | Hypnoteuse (2)");
                string dreieckThemewahl = Console.ReadLine();

                if (dreieckThemewahl == "1" || dreieckThemewahl == "Kathete")
                {
                    Console.WriteLine("Was ist die Seitenlänge der Hypnoteuse?");
                    double dreieckHypnoteuse = double.Parse(Console.ReadLine());

                    Console.WriteLine("Was ist die Seitenlänge der Kathete 1?");
                    double dreieckEingabeKathete = double.Parse(Console.ReadLine());

                    double dreieckKathete = Math.Sqrt(Math.Pow(dreieckHypnoteuse,2) - Math.Pow(dreieckEingabeKathete,2));

                    Console.WriteLine("Die Seitenlänge der Kathete 2 beträgt: " + dreieckKathete);

                }
                if (dreieckThemewahl == "2" || dreieckThemewahl == "Hypnoteuse")
                {
                    Console.WriteLine("Wie lang ist Kathete 1?");
                    double dreieckEingabeKathete = double.Parse(Console.ReadLine());

                    Console.WriteLine("Wie lang ist Kathete 2?");
                    double dreieckKathete = double.Parse(Console.ReadLine());

                    double dreieckHypnoteuse = Math.Sqrt(Math.Pow(dreieckEingabeKathete, 2) + Math.Pow(dreieckKathete, 2));
                    Console.WriteLine("Die Seitenlänge der Hypnoteuse beträgt: " + dreieckHypnoteuse);
                }
            }
            if (themenWahl == "3" || themenWahl == "Rechteck")
            {
                Console.WriteLine("Was willst du berechnen? Fläche (1) | Umfang (2) | Diagonale (3)");
                string rechteckThemenwahl = Console.ReadLine();

                if (rechteckThemenwahl == "Fläche" || rechteckThemenwahl == "1")
                {
                    Console.WriteLine("Was ist die Seitenlänge von A?");
                    double rechteckSeiteA = double.Parse(Console.ReadLine());

                    Console.WriteLine("Was ist die Seitenlänge von B?");
                    double rechteckSeiteB = double.Parse(Console.ReadLine());

                    double rechteckFläche = rechteckSeiteA * rechteckSeiteB;
                    Console.WriteLine("Die Fläche beträgt: " + rechteckFläche);
                }
            }
            if (themenWahl == "4" || themenWahl == "Kreis")
            {

            }
        }

        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("Was ist die Seitenlänge von A?");
        double seiteA = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Was ist die Seitenlänge von B?");
        double seiteB = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        double seiteC = Math.Sqrt(Math.Pow(seiteA, 2) + Math.Pow(seiteB, 2));
        Console.WriteLine("Die Seitenlänge C beträgt: " + seiteC);

        double Fläche = 0.5 * seiteA * seiteB;
        Console.WriteLine("Die Fläche beträgt: " + Fläche);

        double Umfang = seiteA + seiteB + seiteC;
        Console.WriteLine("Der Umfang beträgt: " + Umfang);
    }
    else
    {
        Console.WriteLine("Falsches Passwort. Das Programm wird beendet.");
    } }
else
{
    Console.WriteLine("Falscher Username. Das Programm wird beendet.");
}