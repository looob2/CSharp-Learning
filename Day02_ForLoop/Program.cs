for (int i = 1; i < 6; i = i + 1)
{
    Console.WriteLine("你好");
}

Console.WriteLine("");

for (int p = 1; p < 11; p++)
{
    Console.WriteLine(p);
}

Console.WriteLine("");

Console.WriteLine("请输入一个数字:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("");
for (int m = 1; m <= num; m++)
{
    Console.WriteLine(m);
}

Console.WriteLine("");

Console.WriteLine("请输入要刷新的怪物数量:");
int enemyCount = int.Parse(Console.ReadLine());
for (int n = 1; n <= enemyCount; n++)
{
    Console.WriteLine($"第{n}只怪物生成!");
}

Console.WriteLine("");

int playerHp = 100;
int enemyAttack = 10;
for (int s = 1; playerHp > 0; s++)
{
    playerHp -= enemyAttack;
    Console.WriteLine($"第{s}次攻击!\nHP:{playerHp}");
    if (playerHp<= 0)
    {
        Console.WriteLine("GameOver");
        break;
    }
}