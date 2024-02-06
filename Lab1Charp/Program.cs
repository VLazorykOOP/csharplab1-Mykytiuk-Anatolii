using System;

class Program
{

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
        double S = (fcatet * scatet) / 2;
        Console.WriteLine("S = " + S);

    }

    static void task2()
    {
        Console.WriteLine("Task2 !");
        Console.WriteLine("Please enter a two-digit number:");
            string inputVal = Console.ReadLine();

            // Перевірка чи введене значення є двозначним числом
            if (inputVal.Length == 2 && char.IsDigit(inputVal[0]) && char.IsDigit(inputVal[1]))
            {
                int firstDig = int.Parse(inputVal[0].ToString());
                int secondDig = int.Parse(inputVal[1].ToString());

                if (firstDig > secondDig)
                {
                    Console.WriteLine($"The first digit ({firstDig}) is greater than the second digit ({secondDig}).");
                }
                else if (firstDig < secondDig)
                {
                    Console.WriteLine($"The second digit ({secondDig}) is greater than the first digit ({firstDig}).");
                }
                else
                {
                    Console.WriteLine("Both digits are equal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid two-digit number.");
            }
    }

    static void task3()
    {
        Console.WriteLine("Task3 !");
        Console.WriteLine("Please input coordinate your point:");
        Console.Write("x = ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("y = ");
        float y = float.Parse(Console.ReadLine());
        if (x * x + y * y < 225 && y > 0 && y > x)
            Console.WriteLine("contains");
        else if (x * x + y * y > 225 || y < 0 || y < x || y < -x)
            Console.WriteLine("not contains");
        else Console.WriteLine("on the border");
    }

    static void Main()
    {

        Console.WriteLine("Lab 1 !");

Console.WriteLine("Please input task");

Console.Write("n=");

 byte n = byte.Parse(Console.ReadLine());

 switch (n)
{
    case 1: Console.WriteLine("You choise task 1"); task1(); break;
    case 2: Console.WriteLine("You choise task 2"); task2(); break;
    case 3: Console.WriteLine("You choise task 3"); task3(); break;
    case 4: Console.WriteLine("You choise task 4"); break;
    case 5: Console.WriteLine("You choise task 5"); break;
    case 6: Console.WriteLine("You choise task 6"); break;
}
}

}

