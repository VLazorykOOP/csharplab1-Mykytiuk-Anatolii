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

    static void task4()
    {
        Console.WriteLine("Task4 !");
        Console.WriteLine("Please input m:");
        Console.Write("m =");
        int m = Convert.ToInt32(Console.ReadLine());
        int month = 1;
        month += m;
        int finalResult = month % 12;
        switch (finalResult)
        {
            case 0: Console.WriteLine("December"); break;
            case 1: Console.WriteLine("Janury"); break;
            case 2: Console.WriteLine("February"); break;
            case 3: Console.WriteLine("March"); break;
            case 4: Console.WriteLine("April"); break;
            case 5: Console.WriteLine("May"); break;
            case 6: Console.WriteLine("June"); break;
            case 7: Console.WriteLine("July"); break;
            case 8: Console.WriteLine("August"); break;
            case 9: Console.WriteLine("Septemder"); break;
            case 10: Console.WriteLine("October"); break;
            case 11: Console.WriteLine("November"); break;
        }
        
    }

           static void task5()
        {
            // Приклад використання функції Multiply
            Console.WriteLine("Please input first value");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input first value");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Multiply(a, b);
            Console.WriteLine($"The product of {a} and {b} is: {result}");
        }

        // Функція для обчислення добутку двох дійсних чисел
        static double Multiply(double x, double y)
        {
            return x * y;
        }

     static void task6()
{
    Console.WriteLine("Please input n:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input m:");
    int m = Convert.ToInt32(Console.ReadLine());
    
    float result = ((3f / (n + (m * m) + 1)) + 1) * (m - n);
    Console.Write("Result is: " + result);
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
    case 4: Console.WriteLine("You choise task 4"); task4(); break;
    case 5: Console.WriteLine("You choise task 5"); task5(); break;
    case 6: Console.WriteLine("You choise task 6"); task6(); break;
}
}

}

