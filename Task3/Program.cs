while(true)
{
    System.Console.WriteLine();
    System.Console.Write("The first number is: ");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("The operation is: ");
    char c = Convert.ToChar(Console.ReadLine());
    System.Console.Write("The second number is: ");
    int b = Convert.ToInt32(Console.ReadLine());
    var cal = new Calculator(a,b);

    switch (c)
    {
        case '+':
            System.Console.WriteLine(a+" + "+b+" = "+cal.Sum());
            break;
        case '-':
            System.Console.WriteLine(a+" - "+b+" = "+cal.Subtract());
            break;
        case '*':
            System.Console.WriteLine(a+" * "+b+" = "+cal.Multiplication());
            break;
        case '/':
            System.Console.WriteLine(a+" / "+b+" = "+cal.Division());
            break;

        default:
            System.Console.WriteLine("Please enter only +-*/ operations!");
            break;
    } 
}