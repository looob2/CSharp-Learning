using System.Diagnostics.CodeAnalysis;

class Ticket
{
    public Ticket(int distance)
    {
        Distance = distance;
    }

    public void GetPrice()
    {
        double price = Distance;

        if (Distance > 100 && Distance < 201)
        {
            price *= 0.95;
        }
        else if (Distance > 200 && Distance < 301)
        {
            price *= 0.9;
        }
        else if (Distance > 300)
        {
            price *= 0.8;
        }

        Console.WriteLine($"{Distance}公里{price}块钱");
    }

    public int Distance { get; private set; }
}

class Student
{
    public Student(string name , string sex , int age , int csharpscore , int unityscore)
    {
        Name = name;
        Sex = sex;
        Age = age;
        CsharpScore = csharpscore;
        UnityScore = unityscore;
    }

    private int age;
    private string sex;
    private int csharpscore;
    private int unityscore;
    public string Name { get; private set; }
    public string Sex 
    {
        get
        {
            return sex;
        }
        set
        {
            if (value == "男" || value == "女")
            {
                sex = value;
            }
            else
            {
                Console.WriteLine("性别只能为男或女");
                return;
            }
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0 || value > 150)
            {
                Console.WriteLine("输入了错误的年龄");
                return;
            }
            age = value;
        }
    }
    public int CsharpScore
    {
        get
        {
            return csharpscore;
        }
        set
        {
            if(value < 0 || value > 100)
            {
                Console.WriteLine("成绩只能为0-100");
                return;
            }
            csharpscore = value;
        }
    }
    public int UnityScore
    {
        get
        {
            return unityscore;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("成绩只能为0-100");
                return;
            }
            unityscore = value;
        }
    }

    public void Hello()
    {
        Console.WriteLine($"我叫{Name},今年{Age}岁了,是{Sex}同学");
    }

    public void ShowInfo()
    {
        int sum = CsharpScore + UnityScore;
        double average = (double)sum / 2;
        Console.WriteLine($"总分数为{sum},平均分为{average}");
    }
}

class Program
{
    static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        if (distance < 0)
        {
            return;
        }
        Ticket ticket = new Ticket(distance);
        ticket.GetPrice();

        Student student = new Student("tom" , "男" , 18 , 83 , 97);
        Student student1 = new Student("sarah" , "女" , 22 , 76 , 98);
        student.Hello();
        student1.Hello();
        student.ShowInfo();
        student1.ShowInfo();
        
    }
}
