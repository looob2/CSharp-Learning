enum Season
{
    Spring,//默认 = 0
    Summer,// = 1
    Autumn,// = 2
    Winter// = 3
}

enum Job
{
    Warrior,
    Mage,
    Archer
}

struct Monster
{
    public string name;
    public int hp;
    public int attack;
}

struct Player
{
    public string name;
    public int hp;
    public Job job;
}

class Program
{
    static void Main()
    {
        Season season = Season.Winter;
        Console.WriteLine(season);
        int n = (int)Season.Autumn;//可以显式转换打印出代表的int值
        Console.WriteLine(n);

        Monster slime = new Monster();
        slime.name = "史莱姆";
        slime.hp = 50;
        slime.attack = 8;
        Console.WriteLine($"{slime.name}\n{slime.hp}\n{slime.attack}");

        Player player = new Player();
        player.name = "小明";
        player.hp = 100;
        player.job = Job.Mage;
        Console.WriteLine($"{player.name}\n{player.hp}\n{player.job}");
    }
}
