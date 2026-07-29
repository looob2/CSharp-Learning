//运算符重载
struct Point
{
    public Point (int x , int y)
    {
        X = x;
        Y = y;
    }

    public static bool operator == (Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }
    public static bool operator != (Point p1, Point p2)
    {
        return p1.X != p2.X || p1.Y != p2.Y; 
    }
    public static explicit operator Vector3(Point p)//显式转换
    {
        return new Vector3(p.X , p.Y , 0);
    }

    public int X { get; set;}
    public int Y { get; set;}
}

class Vector3
{
    public Vector3(int x , int y , int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"({X} , {Y} , {Z})");
    }
    public static Vector3 operator +(Vector3 v1 , Vector3 v2)
    {
        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
    public static Vector3 operator -(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X - v2.X , v1.Y - v2.Y , v1.Z - v2.Z);
    }
    public static Vector3 operator *(Vector3 v1, int num)
    {
        return new Vector3(v1.X * num , v1.Y * num , v1.Z * num);
    }
    public static implicit operator Point (Vector3 v)//隐式转换
    {
        return new Point(v.X , v.Y);
    }

    public int X { get; set;}
    public int Y { get; set;}
    public int Z { get; set;}
}

//里氏替换原则
class Monster
{

}
class Boss : Monster
{
    public void Skill()
    {
        Console.WriteLine("Boss技能");
    }
}
class Goblin : Monster
{
    public void Attack()
    {
        Console.WriteLine("小怪攻击");
    }
}
class Player
{
    public Weapon[] hand = new Weapon[1] { new Dagger() };//手持的物品
    public void Hold(Weapon weapon)
    {
        if (hand[0].GetType() == weapon.GetType())//判断类型是否相同(是否拿着重复武器)
        {
            Console.WriteLine("已经在手上了!");
            return;
        }
        hand[0] = weapon;//替换数组中的武器
        weapon.ShowInfo();
    }
}
class Weapon
{
    public Weapon() { }
    public string Name { get; set; }
    public void ShowInfo()
    {
        Console.WriteLine($"目前装备:{Name}");
    }
    public static void WeaponMenu(Player player)
    {
        Console.WriteLine("\n武器菜单\n1.匕首\n2.冲锋枪\n3.霰弹枪\n4.手枪");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int n) && n < 5 && n > 0)
        {
            switch (n)
            {
                case 1:
                    player.Hold(new Dagger());
                    break;
                case 2:
                    player.Hold(new Submachinegun());
                    break;
                case 3:
                    player.Hold(new Shotgun());
                    break;
                case 4:
                    player.Hold(new Pistol());
                    break;
            }
        }
        else
        {
            Console.WriteLine("请按下正确的按键");
        }
    }
}
class Dagger : Weapon
{
    public Dagger(){ Name = "匕首"; }
}
class Submachinegun : Weapon
{
    public Submachinegun() { Name = "冲锋枪"; }
}
class Shotgun : Weapon
{
    public Shotgun() { Name = "霰弹枪"; }
}
class Pistol : Weapon
{
    public Pistol() { Name = "手枪"; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(new Point(1, 2) != new Point(2, 2));
        Console.WriteLine(new Point(2, 2) == new Point(2, 2));
        Vector3 v1 = new Vector3(1, 5, 3) - new Vector3(2, 1, 5);
        v1.ShowInfo();
        Vector3 v2 = new Vector3(2, 3, 7) * 3;
        v2.ShowInfo();
        Point p = new Point(1, 3);
        p = v2;//三维隐式转换为二维
        v1 = (Vector3)p;//二维显示转换为三维

        List<Monster> monsters = new List<Monster>() //创建数组
        {
            new Goblin() , new Boss() , new Boss() , new Goblin() , new Boss() , 
            new Goblin() , new Boss() , new Goblin() , new Goblin() , new Goblin()
        };
        foreach (Monster monster in monsters)//遍历monsters中的monster
        {
            if (monster is Goblin)//若monster的类型为Goblin就会进入
            {
                (monster as Goblin).Attack();//将monster转化为Goblin才能使用Attack
            }
            else//若monster的类型为Boss
            {
                (monster as Boss).Skill();
            }
        }
        Player player = new Player();
        Weapon weapon = new Weapon();
        while (true)
        {
            Weapon.WeaponMenu(player);
        }
    }
}