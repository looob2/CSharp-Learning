class GameManager
{
    private GameManager() {}
    private static GameManager instance = new GameManager();
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
}
static class MathMethod
{
    private const double pi = Math.PI;
    public static double CircumArea(int r)
    {
        return pi * r * r;
    }
    public static double Circumference(int r)
    {
        return 2 * pi * r;
    }
    public static int RectangleArea(int l , int h)
    {
        return l * h;
    }
    public static int RectanglePerimeter(int l , int h)
    {
        return 2 * (l + h);
    }
    public static int Abs(int num)
    {
        if (num < 0)
        {
            return -num;
        }
        return num;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine(GameManager.Instance);

        Console.WriteLine(MathMethod.CircumArea(5).ToString("F2"));
        Console.WriteLine(MathMethod.Circumference(5).ToString("F2"));
        Console.WriteLine(MathMethod.RectangleArea(4, 6));
        Console.WriteLine(MathMethod.RectanglePerimeter(4 ,6));
        Console.WriteLine(MathMethod.Abs(-10));
    }    
}
