class Program
{
    public static void Show(int x)
    {
        Console.WriteLine(x);
    }
    public static void Show(string s)
    {
        Console.WriteLine(s);
    }
    public static void swap(ref int x , ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"x的值为:{x},y的值为:{y}");
    }

    static void Main()
    {
        //var i = Console.ReadLine();
        //Show(i);
        int s = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        swap(ref s,ref p);
    }
}