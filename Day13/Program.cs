using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.XPath;

class Player
{
    public Player(string name)
    {
        Name = name;
        Hp = 50;
        Attack = 5;
        Level = 1;
        Xp = 0;
        MaxXp = 10;
    }
    public string Name { get; private set; }
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Level { get; private set; }
    public int Xp { get; private set; }
    public int MaxXp { get; private set; }

    public void ShowInfo()//展示信息
    {
        Console.WriteLine($"玩家信息\n玩家:{Name}\nHP:{Hp}\nATK:{Attack}\nLEVEL:{Level}({Xp}/{MaxXp})\n");
    }

    public void AddWeapon(Weapon weapon)//玩家装备加成
    {
        Attack += weapon.Attack;        
    }

    public void TakeDamage(int damage)//受到伤害
    {
        Hp -= damage;
        if (Hp < 0)//修正血量为零
        {
            Hp = 0;
        }
        Console.WriteLine($"{Name}受到{damage}点伤害,剩余HP:{Hp}\n");
    }

    public void Attacking(Monster monster)//攻击行为
    {
        Console.WriteLine($"{Name}向{monster.Name}发动了攻击!");
        monster.TakeDamage(Attack);
    }
    
    public void Death()//死亡反馈
    {
        if (Hp == 0)
        {
            Console.WriteLine("玩家死亡!\n");
        }
    }

    public void CheckLevelUp(Monster monster)
    {
        if (monster.Hp == 0)
        {
            Xp += monster.Xp;
            Console.WriteLine($"击败了{monster.Name},获得{monster.Xp}XP!");
            while (Xp >= MaxXp)
            {
                Level++;
                Xp -= MaxXp;
                MaxXp += 10;
            }
            Console.WriteLine($"当前等级为:{Level}级\n");
        }
    }
}
class Monster
{
    public Monster(string name , int hp , int attack , int xp)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
        Xp = xp;
    }
    public string Name { get; private set;}
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Xp { get; private set; }

    public void ShowInfo()//展示信息
    {
        Console.WriteLine($"怪物信息\n名称:{Name}\nHP:{Hp}\nATK:{Attack}\n");
    }

    public void TakeDamage(int damage)//受到伤害
    {
        Hp -= damage;
        if(Hp < 0)
        {
            Hp = 0;
        }
        Console.WriteLine($"{Name}受到{damage}点伤害,剩余HP:{Hp}\n");
    }

    public void Attacking(Player player)//攻击行为
    {
        Console.WriteLine($"{Name}向{player.Name}发动了攻击!");
        player.TakeDamage(Attack);
    }

    public void Death()//死亡反馈
    {
        if (Hp == 0)
        {
            Console.WriteLine("怪物死亡!\n");
        }
    }
}
class Weapon
{
    public Weapon(string name , int attack)
    {
        Name = name;
        Attack = attack;
        number = 1;
    }
    public string Name { get; private set; }
    public int Attack { get; private set; }
    public int number { get; private set; }

    public void ShowInfo()
    {
        Console.WriteLine($"武器信息\n名称:{Name}\nATK:{Attack}\n");
    }
}
class Program
{
    public static void Battle(Player player , Monster monster)
    {
        while(player.Hp > 0 && monster.Hp > 0)
        {
            player.Attacking(monster);
            if (monster.Hp == 0)
            {
                break;
            }
            monster.Attacking(player);
        }
        player.Death();
        monster.Death();
    }
    static void Main()
    {
        Console.WriteLine("请输入玩家名称:");
        string n = Console.ReadLine();//输入玩家名称
        Console.WriteLine();

        Player player = new Player(n);
        player.ShowInfo();

        Weapon weapon = new Weapon("sword" , 5);
        player.AddWeapon(weapon);
        player.ShowInfo();

        Monster slime = new Monster("slime" , 15 , 5 , 10);
        slime.ShowInfo();

        Battle(player, slime);
        player.CheckLevelUp(slime);

        Monster zombie = new Monster("zombie", 1 , 1 , 100);
        zombie.ShowInfo();
        player.ShowInfo();

        Battle(player, zombie);
        player.CheckLevelUp(zombie);
        player.ShowInfo();
    }
}
