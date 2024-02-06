
 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.WriteLine("Please input length first catet");
    Console.Write("length first catet = ");
    string? str = Console.ReadLine();
    float fcatet = 0;
    if (str != null) fcatet = float.Parse(str);
    Console.WriteLine("Please input length second catet");
    Console.Write("length second catet = ");
    str = Console.ReadLine();
    float scatet = 0;
    if (str != null) scatet = float.Parse(str);
    double S = (fcatet * scatet)/2;
    Console.WriteLine("S = " + S);

}
Console.WriteLine("Lab 1 !");
task1();

