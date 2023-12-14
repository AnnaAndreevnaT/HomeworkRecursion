using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
       var hw = new HomeworkRecursions();
       hw.Task1();
       hw.Task2();
       hw.Task3();
    }
}


public class HomeworkRecursions 
{
    public HomeworkRecursions()
    {
        
    }

    public void Task1()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Che(m,n);
    }

    private void Che(int m, int n)
    {
        if (m <= n) return;
        Console.WriteLine($"{m}, ");
        Che(m - 1,n);
    }

    public void Task2()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int functionAkkerman = Ack(m, n);

        Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");

    }

    private int Ack(int m, int n)
    {
        if (m == 0) 
        {
            return n + 1;
        }
        else if (n == 0) 
        {
            return Ack(m - 1, 1);
        }
        else 
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
    }


    public void Task3()
    {
        Console.WriteLine("Введите массив значений разделеных запятой");
        var input = Console.ReadLine();

        var array = input.Split(",");
        var int_array = array.Select(i => Int32.Parse(i)).ToArray();

        PrintArray(int_array, int_array.Length - 1);
    }

    private void PrintArray(int[] array, int position)
    {
        if (position > 0)
        {
            Console.WriteLine(array[position]);
            PrintArray(array, position - 1);
        }        
        else if (position == 0)
        {
            Console.WriteLine(array[0]);
        }
    }
    
}


