using System.Security.Cryptography.X509Certificates;

class Array
{
    private List<int> array = new List<int>();

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set 
        { 
            array[index] = value;
        }
    }

    public void Add(int number)
    {
        array.Add(number);
    }

    public void delete(int index)
    {
        array.RemoveAt(index);
    }

    public void check(int index)
    {
        Console.Write(array[index] + " ");
    }

    public void fix(int index , int number)
    {
        array[index] = number;
    }

    public int length()
    {
        return array.Count;
    }
}
class Program
{
    static void Main()
    {
        Array array = new Array();
        array.Add(10);
        array.Add(20);
        array.Add(39);
        array.Add(27);//增

        for (int i = 0; i < array.length(); i++)
        {
            array.check(i);//查
        }

        Console.WriteLine();
        Console.WriteLine();

        array.delete(2);//删

        for (int i = 0; i < array.length(); i++)
        {
            array.check(i);
        }

        Console.WriteLine();
        Console.WriteLine();

        array.fix(0 , 80);//改

        for (int i = 0; i < array.length(); i++)
        {
            array.check(i);
        }
    }
}