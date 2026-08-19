//WaterHeater waterHeater = new();
//waterHeater.Use();
Test2 test2 = new Test2();
test2.Test3();

class WaterHeater
{
    private int temperature;
    public WaterHeater()
    {
        temperature = 21;
    }
    public void Heater()
    {
        temperature++;
    }
    public void Alarm()
    {
        if(temperature > 95)
        {
            Console.WriteLine($"水的温度:{temperature}");
        }
    }
    public void Monitor()
    {
        if (temperature <= 95)
        {
            Console.WriteLine("水没烧开");
        }
        else if (temperature > 95)
        {
            Console.WriteLine("水烧开了!");
        }
    }

    public event Action action;
    public void Use()
    {
        action = Heater;
        action += Alarm;
        action += Monitor;
        while (temperature < 100)
        {
            action();
        }
    }
}

class Test
{
    Func<int, int> GetMultiply (int num)
    {
        return (x) => num * x;
    }
    public void TestMultiply()
    {
        Func<int, int> Multiply = GetMultiply(5);
        int result = Multiply(3);
        Console.WriteLine(result);
    }
}
class Test2
{
    public Action _Print()
    {
        return () => 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
        };
    }
    public void Test3()
    {
        Action Print = _Print();
        Print();
    }
}