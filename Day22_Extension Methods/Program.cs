static class Tools
{
    public static int Square(this int n)//为int添加了一个求平方的方法
    {
        return n * n;
    }

    public static void KillMyself(this Player player)//为Player添加了一个玩家自杀的方法
    {
        player.Hurted(player.HP);
        Console.WriteLine("玩家自杀!");
    }
}
class Player
{
    public Player(string name, int hp, int attack)
    {
        Name = name;
        HP = hp;
        Attack = attack;
    }

    public void ATK()//玩家攻击
    {
        Console.WriteLine(Name + "发动了攻击!");
    }
    public void Hurted(int damage)//玩家受伤
    {
        HP -= damage;
    }
    

    public string Name { get; private set; }
    public int HP { get; private set; }
    public int Attack { get; private set; }
}
class Monster
{
    public Monster(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }

    public void Hurted(Player player)//怪物受伤
    {
        HP -= player.Attack;
        Console.WriteLine("剩余血量" + HP);
    }

    public int HP { get; private set; }
    public int Attack { get; private set; }
}
class Program
{
    static void Main()
    {
        int i = 3;
        Console.WriteLine(i.Square());

        Player player = new Player("ghost" , 100 , 10 );
        Monster monster = new Monster(25 , 5);
        player.ATK();
        monster.Hurted(player);
        player.ATK();
        monster.Hurted(player);
        player.KillMyself();
        Console.WriteLine(player.HP);
    }
}