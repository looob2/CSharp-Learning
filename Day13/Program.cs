using System.Security.Cryptography.X509Certificates;

class Player
{
    private int hp = 50;
    private int attack = 5;
    private int level = 1;
    public Player(string name)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
        Level = level;
    }
    public string Name { get; private set; }
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Level { get; private set; }

    public void ShowInfo()//展示信息
    {
        Console.WriteLine($"玩家信息\n玩家:{Name}\nHP:{Hp}\nATK:{Attack}\nLEVEL:{Level}\n");
    }

    public void AddAttack(int attack)
    {
        Attack += attack;        
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine($"受到{damage}点伤害,剩余HP:{Hp}\n");
    }

    public void Attacking(Monster monster)
    {
        Console.WriteLine($"{Name}向{monster.Name}发动了攻击!");
        monster.TakeDamage(Attack);
    }
    
    public void Death(int hp)
    {
        if (hp <= 0)
        {
            Console.WriteLine("玩家死亡!");
        }
    }
}
class Monster
{
    public Monster(string name , int hp , int attack)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
    }
    public string Name { get; private set;}
    public int Hp { get; private set; }
    public int Attack { get; private set; }

    public void ShowInfo()
    {
        Console.WriteLine($"怪物信息\n名称:{Name}\nHP:{Hp}\nATK:{Attack}\n");
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine($"受到{damage}点伤害,剩余HP:{Hp}\n");
    }

    public void Attacking(Player player)
    {
        Console.WriteLine($"{Name}向{player.Name}发动了攻击!");
        player.TakeDamage(Attack);
    }

    public void Death(int hp)
    {
        if (hp <= 0)
        {
            Console.WriteLine("怪物死亡!");
        }
    }
}
class Weapon
{
    public Weapon(string name , int attack)
    {
        Name = name;
        Attack = attack;
    }
    public string Name { get; private set; }
    public int Attack { get; private set; }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("请输入玩家名称:");
        string n = Console.ReadLine();//输入玩家名称
        Console.WriteLine();

        Player player = new Player(n);
        player.ShowInfo();

        Weapon weapon = new Weapon("sword" , 5);
        player.AddAttack(weapon.Attack);
        player.ShowInfo();

        Monster slime = new Monster("slime" , 15 , 5);
        slime.ShowInfo();

        while(player.Hp > 0 && slime.Hp > 0)
        {
            player.Attacking(slime);
            if(slime.Hp <= 0)
            {
                break;
            }
            slime.Attacking(player);
        }

        slime.Death(slime.Hp);
        player.Death(player.Hp);
    }
}
