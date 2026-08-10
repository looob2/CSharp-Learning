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

List<int> list = new List<int>() { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };
list.RemoveAt(4);
foreach (int i in list)
{
    Console.WriteLine(i);
}

Boss boss = new Boss();
Gablin gablin = new Gablin();
foreach (Monster m in Monster.monsters)
{
    m.Attack();
}

class Monster
{
    public static List<Monster> monsters = new List<Monster>();
    public Monster()
    {
        monsters.Add(this);
    }
    public virtual void Attack()
    {

    }

}

class Boss : Monster
{
    public override void Attack()
    {
        Console.WriteLine("Boss攻击");
    }
}

class Gablin : Monster
{
    public override void Attack()
    {
        Console.WriteLine("Gablin攻击");
    }
}

class Singleton<T> where T : class, new()
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new T();
            }

            return instance;
        }
    }
}

class GameManager
{
    public void StartGame()
    {
        Console.WriteLine("start");
    }
}

class MyArrayList<T>
{
    private T[] array;
    private int count;

    public MyArrayList()
    {
        array = new T[4];
        count = 0;
    }

    private void Expand()
    {
        T[] newarray = new T[array.Length * 2];
        for (int i = 0; i < array.Length; i++)
        {
            newarray[i] = array[i];
        }
        array = newarray;
    }

    public void Add(T value)
    {
        if(count >= array.Length)
        {
            Expand();
        }
        array[count] = value;
        count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)//这里不用array.Length的原因是因为count是数组中已经有的数,array.Length会包含空字符
        {
            throw new IndexOutOfRangeException();
        }
        return array[index];
    }

    public void Set(int index , T t)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }
        array[index] = t;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }
        for (int i = index; i < count; i++)
        {
            array[i] = array[i + 1];
        }
        count--;
    }
}

