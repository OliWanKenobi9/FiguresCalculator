using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Console.WriteLine("Register:");
Console.WriteLine("What do you want to set as Username?");
string userName = Console.ReadLine();

Console.WriteLine("What do you want to set as Password?");
string passWord = Console.ReadLine();
Console.Clear();

Console.WriteLine("Username:");
string usernameEingabe = Console.ReadLine();
Console.WriteLine("Password:");
string passwordInput = Console.ReadLine();
Console.Clear();

if (usernameEingabe == userName)
{
    if (passwordInput == passWord)
    {

        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Welcome!");
        Console.WriteLine("What do you want to calculate? Square (1) | Triangle (2) | Rectangle (3) | Circle (4) ");
        string chosenTopic = Console.ReadLine();
        if (chosenTopic == "Square" || chosenTopic == "1")
        {
            Console.WriteLine("What do you want to calculate? Diagonal (1) | Area (2) | Scope (3)");
            string squarechosenTopic = Console.ReadLine();
            if (squarechosenTopic == "1" || squarechosenTopic == "Diagonale")
            {
                Console.WriteLine("Whats the length of side A?");
                double squareSideA = double.Parse(Console.ReadLine());

                double squareDiagonal = Math.Sqrt(Math.Pow(squareSideA, 2) + Math.Pow(squareSideA, 2));
                Console.WriteLine("Diagonal D is: " + squareDiagonal);
            }
            if (squarechosenTopic == "2" || squarechosenTopic == "Area")
            {
                Console.WriteLine("Whats the length of side A?");
                double squareSideA = double.Parse(Console.ReadLine());

                double squareArea = squareSideA * squareSideA;
                Console.WriteLine("The Area is:" + squareArea);
            }
            if (squarechosenTopic == "3" || squarechosenTopic == "Scope") ;
            {
                Console.WriteLine("Whats the length of Side A?");
                double squareSideA = double.Parse(Console.ReadLine());

                double squareScope = squareSideA * 4;
                Console.WriteLine("The Scope is: " + squareScope);
            }
        }
            if (chosenTopic == "2" || chosenTopic == "Triangle")
            {
                Console.WriteLine("What do you want to calculate? Catheter (1) | Hypotenuse (2)");
                string trianglechosenTopic = Console.ReadLine();

                if (trianglechosenTopic == "1" || trianglechosenTopic == "Catheter")
                {
                    Console.WriteLine("Was ist die Seitenlänge der Hypotenuse?");
                    double triangleHypotenuse = double.Parse(Console.ReadLine());

                    Console.WriteLine("Whats the side length pf Catheter 1?");
                    double triangleinputCatheter = double.Parse(Console.ReadLine());

                    double triangleCatheter = Math.Sqrt(Math.Pow(triangleHypotenuse,2) - Math.Pow(triangleinputCatheter,2));

                    Console.WriteLine("The sidelength of Catheter 2 is: " + triangleCatheter);

                }
                if (trianglechosenTopic == "2" || trianglechosenTopic == "Hypotenuse")
                {
                    Console.WriteLine("How long is Catheter 1?");
                    double triangleinputCatheter = double.Parse(Console.ReadLine());

                    Console.WriteLine("How long is Catheter 2)");
                    double triangleCatheter = double.Parse(Console.ReadLine());

                    double triangleHypotenuse = Math.Sqrt(Math.Pow(triangleinputCatheter, 2) + Math.Pow(triangleCatheter, 2));
                    Console.WriteLine("Die Seitenlänge der Hypnoteuse beträgt: " + triangleHypotenuse);
                }
            }
            if (chosenTopic == "3" || chosenTopic == "Rechteck")
            {
                Console.WriteLine("Was willst du berechnen? Fläche (1) | Umfang (2) | Diagonale (3)");
                string rectanglechosenTopic = Console.ReadLine();

                if (rectanglechosenTopic == "Fläche" || rectanglechosenTopic == "1")
                {
                    Console.WriteLine("Was ist die Seitenlänge von A?");
                    double rectangleSideA = double.Parse(Console.ReadLine());

                    Console.WriteLine("Was ist die Seitenlänge von B?");
                    double rectangleSideB = double.Parse(Console.ReadLine());

                    double rectangleArea = rectangleSideA * rectangleSideB;
                    Console.WriteLine("Die Fläche beträgt: " + rectangleArea);
                }
            }
            if (chosenTopic == "4" || chosenTopic == "Kreis")
            {
                Console.WriteLine("What do you want to calculate? Scope (1) | Radius (2) ");
                string circlechosenTopic = Console.ReadLine();

                if (circlechosenTopic == "Scope" || circlechosenTopic == "1")
                {
                    Console.WriteLine("Whats the radius?");
                    double circleRadius = double.Parse(Console.ReadLine());

                    double circleScope = 2 * Math.PI * circleRadius;
                    Console.WriteLine("The Scope is: " + circleScope);
                }
                if (circlechosenTopic == "Radius" || circlechosenTopic == "2")
                {
                    Console.WriteLine("Whats the scope?");
                    double circleScope = double.Parse(Console.ReadLine());

                    double circleRadius = circleScope / (2 * Math.PI);
                }
                
                



            
            }
    }
    else
    {
        Console.WriteLine("Wrong Password. The Program will be stopped.");
    } }
else
{
    Console.WriteLine("Wrong Username. The Program will be stopped.");
}
