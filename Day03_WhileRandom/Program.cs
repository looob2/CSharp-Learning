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
while (userHp > 0 && smileHp > 0)
{
    int userAttack = Random.Shared.Next(8, 16);
    int smileAttack = Random.Shared.Next(16, 30);
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

Console.WriteLine("");

Console.WriteLine("===========\n史莱姆出现!\n===========");
int _playerHp = 100;
int _smileHp = 50;
while (_playerHp > 0 && _smileHp > 0)
{
    Console.WriteLine("");
    Console.WriteLine("========================\n请按下任意键掷出你的骰子\n========================");
    Console.ReadKey();
    Console.WriteLine("");
    int playerPoint = Random.Shared.Next(1, 7);
    Console.WriteLine($"你的点数为{playerPoint}");
    int smilePoint = Random.Shared.Next(1, 7);
    Console.WriteLine($"对方的点数为{smilePoint}");//双方掷出骰子点数

    int _playerAttack = Random.Shared.Next(8, 16);
    int _smileAttack = Random.Shared.Next(16, 30);//双方随机攻击力

    if (playerPoint > smilePoint)//若玩家点数大
    {
        Console.WriteLine("");
        Console.WriteLine("你先手!");
        _smileHp -= _playerAttack;
        if(_smileHp < 0)
        {
            _smileHp = 0;
        }
        Console.WriteLine($"史莱姆受到{_playerAttack}点攻击!\n史莱姆剩余HP{_smileHp}");
        if (_smileHp == 0)//判断史莱姆是否死亡,死亡后则无法发动攻击,跳出if
        {
            break;
        }
        _playerHp -= _smileAttack;
        if (_playerHp < 0)
        {
            _playerHp = 0;
        }
        Console.WriteLine($"你受到{_smileAttack}点攻击!\n你剩余HP{_playerHp}");
    }

    else if (playerPoint < smilePoint)//若史莱姆点数大
    {
        Console.WriteLine("");
        Console.WriteLine("对方先手!");
        _playerHp -= _smileAttack;
        if(_playerHp < 0)//判断玩家是否死亡,死亡后则无法发动攻击,跳出if
        {
            _playerHp = 0;
        }
        Console.WriteLine($"你受到{_smileAttack}点攻击!\n你剩余HP{_playerHp}");
        if (_playerHp == 0) 
        { 
            break;
        }
        _smileHp -= _playerAttack;
        if (_smileHp < 0)
        {
            _smileHp = 0;
        }
        Console.WriteLine($"史莱姆受到{_playerAttack}点攻击!\n史莱姆剩余HP{_smileHp}");
    }

    else if (playerPoint == smilePoint)//若双方点数相同
    {
        Console.WriteLine("");
        Console.WriteLine("双方点数相同,同时攻击!");
        _playerHp -= _smileAttack;
        if (_playerHp < 0)
        {
            _playerHp = 0;
        }
        Console.WriteLine($"你受到{_smileAttack}点攻击!\n你剩余HP{_playerHp}");
        _smileHp -= _playerAttack;
        if (_smileHp < 0)
        {
            _smileHp = 0;
        }
        Console.WriteLine($"史莱姆受到{_playerAttack}点攻击!\n史莱姆剩余HP{_smileHp}");
    }
}

Console.WriteLine("");

if (_playerHp == 0)
{
    Console.WriteLine("玩家死亡!");
}
else if (_smileHp == 0)
{
    Console.WriteLine("史莱姆死亡!");
}