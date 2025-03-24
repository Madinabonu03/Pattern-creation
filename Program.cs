using System;
class Program
{
    static void Main()
    {
         string userInput;
     string isContinued;
do{
Console.WriteLine("Pattern creation is starting");
System.Console.WriteLine("Choose what do you want to create from below list:");
System.Console.WriteLine("Triangle");
System.Console.WriteLine("Square");
userInput=Console.ReadLine()?.ToLower();
switch(userInput)
{
    case "triangle":
    DrawTriangle();
    break;

    case "square":
    DrawSquare();
    break;

    default:
    Console.WriteLine("Invalid pattern! Choose from the menu");
    break;
}
System.Console.WriteLine("Do you want to continue:Yes/No");
isContinued=Console.ReadLine();
}
while(isContinued.ToLower()=="yes");

static void DrawTriangle()
    {
        Console.WriteLine("Enter the number of rows for the triangle:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void DrawSquare()
    {
        Console.WriteLine("Enter the size of the square:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
}


