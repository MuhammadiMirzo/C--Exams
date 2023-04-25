int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    for (int j = 1; j <=10; j++)
    {
        System.Console.WriteLine(i+"*"+j+"="+i*j);
    }
    System.Console.WriteLine();   
}