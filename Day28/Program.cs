using System.Runtime.CompilerServices;

void judge<T>()
{
    if(typeof(T) == typeof(int)) 
    {
        Console.WriteLine($"整形,{Unsafe.SizeOf<T>()}字节");
    }
    else if (typeof(T) == typeof(char))
    {
        Console.WriteLine($"字符,{Unsafe.SizeOf<T>()}字节");
    }
    else if (typeof(T) == typeof(float))
    {
        Console.WriteLine($"浮点,{Unsafe.SizeOf<T>()}字节");
    }
    else if (typeof(T) == typeof(string))
    {
        Console.WriteLine($"字符串,{Unsafe.SizeOf<T>()}字节");
    }
    else
    {
        Console.WriteLine("其他类型");
    }
}

judge<int>();
judge<char>();
judge<string>();
judge<float>();
judge<double>();

