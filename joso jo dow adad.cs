//my name is mohammad dehghani
//برنامه جست و جو دو عدد در آرایه 10 در 10

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[10, 10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }

        Console.WriteLine("aray :");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.Write("first number : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("two number : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("ستونی که در آن دو عدد موجود است :");
        for (int j = 0; j < 10; j++)
        {
            bool foundNum1 = false;
            bool foundNum2 = false;
            for (int i = 0; i < 10; i++)
            {
                if (array[i, j] == num1)
                {
                    foundNum1 = true;
                }
                if (array[i, j] == num2)
                {
                    foundNum2 = true;
                }
            }
            if (foundNum1 && foundNum2)
            {
                Console.WriteLine(j);
            }
        }

        Console.ReadLine();
    }
}