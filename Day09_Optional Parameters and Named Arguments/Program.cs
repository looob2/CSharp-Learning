class Program
{
    static void Player(string name = "player" , int hp = 100, int attack = 10, int level = 0)
    {
        Console.WriteLine($"创建玩家:{name}\n初始HP:{hp}\n初始攻击:{attack}\n初始等级:{level}\n");
     }
    static void Main()
    {
        Player();//创建玩家,为初始值
        Player("Tom",level:1);//创建玩家,改变名称,选择等级进行修改
    }
}