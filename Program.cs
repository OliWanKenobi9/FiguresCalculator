Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome!");
Console.WriteLine("What do you want to calculate? Square (1) | Rectangle (2) | Circle (3) | Triangle (4)");
string inputChoice = Console.ReadLine().ToLower();

switch(inputChoice)
{
    case "1":
    case "Square":
        Square();
        break;
    case "2":
    case "Rectangle":
        Rectangle();
        break;
    case "3":
    case "Circle":
        Circle();
        break;
    case "4":
    case "Triangle":
        Console.WriteLine("du hast 4 gedrückt");
        break;
    default:
        Console.WriteLine("Invalid Input.");
        break;
}

void Square()
{
    Console.WriteLine("What do you want to calculate? Area (1) | Scope (2) | Diagonal (3)");
    string squareChoice = Console.ReadLine().ToLower();
    if (squareChoice == null)
    {
        Console.WriteLine("Invalid");
    }
    switch (squareChoice)
    {
        case "1":
        case "area":
            Console.WriteLine("Whats the length of Side A?");
            double squareSideA = double.Parse(Console.ReadLine());

            double squareArea = squareSideA * squareSideA;
            Console.WriteLine("The area is:" + squareArea);

            if (squareSideA == null)
            {
                Console.WriteLine("Invalid Input.");
            }

            break;
        
        case "2":
        case "scope":
            Console.WriteLine("Whats the length of Side A?");
            squareSideA = double.Parse(Console.ReadLine());

            double squareScope = squareSideA * 4;
            Console.WriteLine("The Scope is: " + squareScope);
            
            if (squareSideA == null)
            {
                Console.WriteLine("Invalid Input.");
            }

            break;
        case "3":
        case "diagonal":
            Console.WriteLine("Whats the length of Side A?");
            squareSideA = double.Parse(Console.ReadLine());

            double squareDiagonal = Math.Sqrt(Math.Pow(squareSideA, 2) + Math.Pow(squareSideA, 2));
            Console.WriteLine("The Diagonal is: " + squareDiagonal);

            if (squareSideA == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
    }
}

void Rectangle()
{
    Console.WriteLine("What do you want to calculate? Area (1) | Scope (2) | Diagonal (3)");
    string rectangleChoice = Console.ReadLine().ToLower();
    if (rectangleChoice == null)
    {
        Console.WriteLine("Invalid");
    }
    switch (rectangleChoice)
    {
        case "1":
        case "area":
            Console.WriteLine("Whats the length of Side A?");
            double rectangleSideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Whats the length of Side B?");
            double rectangleSideB = double.Parse(Console.ReadLine());

            double rectangleArea = rectangleSideA * rectangleSideB;
            Console.WriteLine("The area is:" + rectangleArea);

            if (rectangleSideA == null)
            {
                Console.WriteLine("Invalid");
            }

            if (rectangleSideB == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        case "2":
        case "scope":
            Console.WriteLine("Whats the length of Side A?");
            rectangleSideA = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Whats the length of Side B?");
            rectangleSideB = double.Parse(Console.ReadLine());

            double rectangleScope = rectangleSideA + rectangleSideB * 2;
            Console.WriteLine("The scope is: " + rectangleScope);

            if (rectangleSideA == null)
            {
                Console.WriteLine("Invalid");
            }

            if (rectangleSideB == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        case "3":
        case "diagonal":
            Console.WriteLine("Whats the length of Side A?");
            rectangleSideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Whats the length of Side B?");
            rectangleSideB = double.Parse(Console.ReadLine());

            double rectangleDiagonal = Math.Sqrt(Math.Pow(rectangleSideA, 2) + Math.Pow(rectangleSideB, 2));
            Console.WriteLine("The diagonal is: " + rectangleDiagonal);
            if (rectangleSideA == null)
            {
                Console.WriteLine("Invalid");
            }

            if (rectangleSideB == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
    }
}

