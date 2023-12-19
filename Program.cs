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
        Triangle();
        break;
    default:
        Console.WriteLine("Invalid");
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
        default:
            Console.WriteLine("Invalid");
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
        default:
            Console.WriteLine("Invalid");
            break;
    }
}

void Circle()
{
    Console.WriteLine("What do you want to calculate? Area (1) | Scope (2) | Radius (3) | Diameter (4) ");
    string circleChoice = Console.ReadLine().ToLower();
    if (circleChoice == null)
    {
        Console.WriteLine("Invalid");
    }
    switch (circleChoice)
    {
        case "1":
        case "area":
            Console.WriteLine("Whats the radius of the circle?");
            double circleRadius = double.Parse(Console.ReadLine());

            double circleArea = 2 * Math.PI * circleRadius;
            Console.WriteLine("The Area is: " + circleArea);
            
            if (circleRadius == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        case "2":
        case "scope":
            Console.WriteLine("Whats the radius of the circle?");
            circleRadius = double.Parse(Console.ReadLine());

            double circleScope = 2 * Math.PI * circleRadius;
            Console.WriteLine("The Scope is: " + circleScope);
            if (circleRadius == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        case "3":
        case "radius":
            Console.WriteLine("Whats the Scope of the circle?");
            circleScope = double.Parse(Console.ReadLine());

            circleRadius = circleScope / (2 * Math.PI);
            Console.WriteLine("The Radius is: " + circleRadius);
            if (circleScope == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        case "4":
        case "diameter":
            Console.WriteLine("Whats the Scope of the circle?");
            circleScope = double.Parse(Console.ReadLine());

            double circleDiameter = circleScope / (2 * Math.PI) * 2;
            Console.WriteLine("The Radius is: " + circleDiameter);
            if (circleScope == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
}

void Triangle()
{
    Console.WriteLine("What do you want to calculate? Area (1) | Sidelength C (2) | Scope (3)");
    string triangleChoice = Console.ReadLine();
    if (triangleChoice == null)
    {
        Console.WriteLine("Invalid");
    }
    switch (triangleChoice)
    {
        case "1":
        case "area":
            Console.WriteLine("What is the length of side A?");
            double triangleSideA = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the length of side B?");
            double triangleSideB = double.Parse(Console.ReadLine());

            double triangleSideC = Math.Sqrt(Math.Pow(triangleSideA, 2) + Math.Pow(triangleSideB, 2));
            double triangleS = (triangleSideA + triangleSideB + triangleSideC) / 2;
            double triangleArea = Math.Sqrt(triangleS * (triangleS - triangleSideA) * (triangleS - triangleSideB) * (triangleS - triangleSideC));
            if (triangleSideA == null)
            {
                Console.WriteLine("Invalid");
            }
            if (triangleSideB == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        case "2":
        case "sidelength c":
            Console.WriteLine("What is the length of side A?");
            triangleSideA = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the length of side B?");
            triangleSideB = double.Parse(Console.ReadLine());

            triangleSideC = Math.Sqrt(Math.Pow(triangleSideA, 2) + Math.Pow(triangleSideB, 2));
            Console.WriteLine("The length of side C is:" + triangleSideC);
            if (triangleSideA == null)
            {
                Console.WriteLine("Invalid");
            }
            if (triangleSideB == null)
            {
                Console.WriteLine("Invalid");
            }
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
}