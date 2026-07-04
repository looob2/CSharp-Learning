int num = Random.Shared.Next(1, 11);
Console.WriteLine($"{num}");

Console.WriteLine("");

int playerHp = 100;
while (playerHp > 0)
{
    int enemyAttack = Random.Shared.Next(8, 16);
    playerHp -= enemyAttack;
    Console.WriteLine($"敌人造成{enemyAttack}点伤害!\n剩余HP:{playerHp}");
}
Console.WriteLine("GameOver");

Console.WriteLine("");

int randomNum = Random.Shared.Next(1, 101);
Console.WriteLine("请输入一个数,看看你什么时候能猜对");
int userNum = 0;
while (userNum != randomNum)
{
    userNum = int.Parse(Console.ReadLine());
    if (userNum > randomNum)
    {
        Console.WriteLine("太大了");
    }
    else if (userNum < randomNum)
    {
        Console.WriteLine("太小了");
    }
}
Console.WriteLine("恭喜猜对!");

Console.WriteLine("");

Console.WriteLine("===========\n史莱姆出现!\n===========");
Console.WriteLine("");
int userHp = 100;
int smileHp = 50;
while (userHp > 0 && smileHp >0)
{
    int userAttack = Random.Shared.Next(8,16);
    int smileAttack = Random.Shared.Next(16,30);
    smileHp -= userAttack;
    if (smileHp < 0)
    {
        smileHp = 0;
    }
    Console.WriteLine($"你的回合!\n对史莱姆造成了{userAttack}点HP,史莱姆剩下{smileHp}点HP");
    Console.WriteLine("");
    if (smileHp <= 0)
    {
        break;
    }
    userHp -= smileAttack;
    if (userHp < 0)
    {
        userHp = 0;
    }
    Console.WriteLine($"对方的回合!\n对你造成了{smileAttack}点HP,你剩下{userHp}点HP");
    Console.WriteLine("");
    if (userHp <= 0)
    {
        break;
    }
}
Console.WriteLine("");
if (userHp <= 0)
{
    Console.WriteLine("玩家死亡");
}
else if (smileHp <= 0)
{
    Console.WriteLine("史莱姆死亡");
}