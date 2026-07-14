using System.Xml.Linq;

class Player
{
    public string name;
    public int hp;
    public int attack;

    public Player(string n, int h, int a)
    {
        name = n;
        hp = h;
        attack = a;
    }

    public void Attack()
    {
        Console.WriteLine(name + "发动攻击!\n");
    }

    public void ShowPlayerInfo()
    {
        Console.WriteLine($"玩家信息\n名称:{name}\nHP:{hp}\nATK:{attack}\n");
    }
}

class Monster
{
    public string name;
    public int hp;
    public int attack;

    public Monster(string n, int h, int a)
    {
        name = n;
        hp = h;
        attack = a;
    }

    public void Attack()
    {
        Console.WriteLine(name + "发动攻击!\n");
    }

    public void ShowMonsterInfo()
    {
        Console.WriteLine($"怪物信息\n怪物名称:{name}\nHP:{hp}\nATK:{attack}\n");
    }
}

class Weapon
{
    public string name;
    public int attack;
}

class Program
{
    static void Damage(ref int hp , int attack)
    {
        hp -= attack;
    }
    static void BattleInfo(int hp , string name)
    {
        Console.WriteLine($"{name}剩余血量:{hp}\n");
    }
    static void Main()
    {
        Player p = new Player("Tom", 100, 25);
        p.ShowPlayerInfo();

        Monster m = new Monster("slime", 50, 8);
        m.ShowMonsterInfo();

        p.Attack();

        Damage(ref m.hp , p.attack);

        BattleInfo(m.hp , m.name);
    }
}
