WaterHeater waterHeater = new();
waterHeater.Use();

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