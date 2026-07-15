class Player
{
    public string name;
    public int hp;
    public int attack;
    public Player(string name , int hp , int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"玩家信息\n名称:{name}\nHP:{hp}\nATK:{attack}\n");
    }
    public void AddAttack(ref int attack , int attack1)
    {
        attack += attack1;
    }
    public void Attack(Monster monster)
    {

    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Console.WriteLine($"造成了{attack}点伤害,剩余HP:{hp}\n");
    }
}

class Monster
{
    public string name;
    public int hp;
    public int attack;
    public Monster(string name , int hp , int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"怪物信息\n名称:{name}\nHP:{hp}\nATK:{attack}\n");
    }
    public void TakeDamage(int damage)
    {
        hp -= attack;
        Console.WriteLine($"造成了{attack}点伤害,剩余HP:{hp}\n");
    }
}

class Weapon
{
    string name;
    public int attack;
    public Weapon(string name, int attack)
    {
        this.name = name;
        this.attack = attack;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"武器信息\nATK加成:+{attack}\n");
    }
}

class Program
{
    static void Main()
    {
        Player p = new Player("Tom" , 100 , 25);
        p.ShowInfo();

        Monster m = new Monster("slime", 50, 15);
        m.ShowInfo();

        Weapon w = new Weapon("sword" , 15);
        w.ShowInfo();

        p.Attack(ref p.attack , w.attack);

        m.TakeDamage(ref m.hp , p.attack , p.name , m.name);
    }
}
