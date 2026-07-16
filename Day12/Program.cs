class Player//玩家类
{
    public string name;
    public int hp;
    public int attack;
    public Player(string name, int hp, int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }
    public void ShowInfo()//展示信息
    {
        Console.WriteLine($"玩家信息\n名称:{name}\nHP:{hp}\nATK:{attack}\n");
    }
    public void AddAttack(ref int attack, int attack1)//攻击力加成,配合武器使用
    {
        attack += attack1;
    }
    public void TakeDamage(int damage)//受到伤害
    {
        hp -= damage;
        Console.WriteLine($"造成了{damage}点伤害,剩余HP:{hp}\n");
    }
}

class Monster//怪物类
{
    public string name;
    public int hp;
    public int attack;
    public Monster(string name, int hp, int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }
    public void ShowInfo()//展示信息
    {
        Console.WriteLine($"怪物信息\n名称:{name}\nHP:{hp}\nATK:{attack}\n");
    }
    public void TakeDamage(int damage)//受到伤害
    {
        hp -= damage;
        Console.WriteLine($"造成了{damage}点伤害,剩余HP:{hp}\n");
    }
}

class Weapon//武器类
{
    string name;
    public int attack;
    public Weapon(string name, int attack)
    {
        this.name = name;
        this.attack = attack;
    }
    public void ShowInfo()//展示武器信息
    {
        Console.WriteLine($"武器信息\nATK加成:+{attack}\n");
    }
}

class Student
{
    public Student(int age, string name)
    {
        this.age = age;
        Name = name;
    }

    int age;
    string name;
    public string Name { get; private set; }

    public int Age
    {
        get
        {
            return age;
        }
        private set 
        { 
            if (value > 150)
            {
                Console.WriteLine("不是正确的年龄");
                throw new AggregateException();
            }
            age = value;
        }
    }

    public void IntroduceMyself()
    {
        Console.WriteLine($"My name is {Name}, and I am {Age} years old.");
    }
}

class Circle
{
    public Circle(double r)
    {
        Radius = r;
    }
    public double Radius { get; private set; }
    public double Area//只添加get访问器,无法再修改Area
    {
        get
        {
            return Radius * Radius * Math.PI;
        }
    }
}

class Program
{
    static void Main()
    {
        Player p = new Player("Tom", 100, 25);
        p.ShowInfo();

        Monster m = new Monster("slime", 50, 15);
        m.ShowInfo();

        Weapon w = new Weapon("sword", 15);
        w.ShowInfo();

        p.AddAttack(ref p.attack, w.attack);

        m.TakeDamage(p.attack);

        Student stu1 = new Student(17 , "Tom");
        stu1.IntroduceMyself();

        Circle circle = new Circle(2);
        Console.WriteLine(circle.Area);
    }
}
