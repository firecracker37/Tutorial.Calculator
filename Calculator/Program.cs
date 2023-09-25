using Calculator;

bool endApp = false;

Console.WriteLine("Console Calculator in C#");
Console.WriteLine("------------------------");

while (!endApp)
{
    //Declare variables and set to empty
    string numInput1 = "";
    string numInput2 = "";
    double result = 0;

    Console.WriteLine("Input a number and then press enter:");
    numInput1 = Console.ReadLine();

    double cleanNum1 = 0;
    while(!double.TryParse(numInput1, out cleanNum1))
    {
        Console.WriteLine("This is not a valid input. Please enter an Integer value");
        numInput1 = Console.ReadLine();
    }

    Console.WriteLine("Type another number and then press enter:");
    numInput2 = Console.ReadLine();

    double cleanNum2 = 0;
    while (!double.TryParse(numInput2, out cleanNum2))
    {
        Console.WriteLine("This is not a valid input. Please enter an Integer value");
        numInput2 = Console.ReadLine();
    }

    // Ask the user to choose an operator.
    Console.WriteLine("Choose an operator from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.Write("Your option? ");

    string op = Console.ReadLine();

    try
    {
        result = Calculator.Calculator.DoOperation(cleanNum1, cleanNum2, op);
        if(double.IsNaN(result))
        {
            Console.WriteLine("This opperation will result in a mathmatical error\n");
        }
        else
        {
            Console.WriteLine("Your result: {0:0.##}", result);
        }
    } catch (Exception e)
    {
        Console.WriteLine("An exception occured.\n Details: " + e.Message);
    }
    Console.WriteLine("------------------------\n");

    Console.WriteLine("Press n and enter to exit or any other key to continue");
    if (Console.ReadLine() == "n") endApp = true;
    Console.WriteLine("\n");
}

return;