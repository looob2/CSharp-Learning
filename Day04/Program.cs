//for (int i = 1; i < 10; i++)
//{
//    Console.WriteLine("\n");
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{j} * {i} = {j * i}\t");
//    }
//}

//Console.WriteLine("");

//static void bubbleSortOptimized(int[] arr)
//{
//    int n = arr.Length;

//    for (int m = 0; m < n - 1; m++)//跑完全程需要n-1轮,但因为m为0,所以要<n-1
//    {

//        bool swapped = false;//每轮重置开关

//        for (int h = 0; h < n - 1 - m; h++)//减去的m是已经完整循环过的次数,可以理解为数组最后最少已经有多少个数字已经排序完毕
//        {
//            if (arr[h] > arr[h + 1])//若后面的数比前面的数大
//            {
//                (arr[h], arr[h + 1]) = (arr[h + 1], arr[h]);//交换位置
//                swapped = true;//只要此轮发生了循环就会变为true
//            }
//        }

//        if (!swapped)//发生了循环变为true,所以!swapped是false,不会触发break而是继续开始新一轮的循环
//        {
//            break;
//        }
//    }
//}

//Console.WriteLine("");

//static void selectionSortDesc(int[] arr)
//{
//    int s = arr.Length;

//    for(int p = 0; p < s - 1; p++)
//    {
//        int minIndex = p;

//        for(int t = p + 1; t < s; t++)//从设置的当前最小值开始向后比较,所以是p+1
//        {
//            if (arr[t] < arr[minIndex])
//            {
//                minIndex = t;
//            }
//        }

//        if (minIndex != s)
//        {
//            (arr[s], arr[minIndex]) = (arr[minIndex], arr[s]);
//        }
//    }
//}

//Console.WriteLine("");

using System.Drawing;

class Program
{
    public static void FixHp(ref int hp)//修正血量
    {
        if (hp < 0) 
        { 
            hp = 0;
        }
        else if (hp > 100)
        {
            hp = 100;
        }
    }

    public static int GetDamage(int attack , int point)//计算伤害数值
    {
        if(point == 6)
        {
            return attack * 2;
        }
        else
        {
            return attack;            
        }
    }

    public static void ShowResult(int point1 , int point2)
    {
        if(point1 > point2)
        {
            Console.WriteLine($"你的点数为{point1}");
            Console.WriteLine($"对方的点数为{point2}");
            Console.WriteLine("你先手!");
        }
        if(point1 < point2)
        {
            Console.WriteLine($"你的点数为{point1}");
            Console.WriteLine($"对方的点数为{point2}");
            Console.WriteLine("对方先手!");
        }
        if(point1 == point2)
        {
            Console.WriteLine($"你的点数为{point1}");
            Console.WriteLine($"对方的点数为{point2}");
            Console.WriteLine("点数相同,双方同时出手!");
        }
    }

    public static void ShowCritical(int point , string name)
    {
        if (point == 6)
        {
            Console.WriteLine($"{name}暴击了!");
        }
    }

    public static int ShowBattleResult(ref int hp , string name1 , string name2 , int damage)
    {
        hp -= damage;
        FixHp(ref hp);
        Console.WriteLine($"{name1}对{name2}造成{damage}点伤害,{name2}剩余HP:{hp}");
        return hp;
    }

    static void Main()
    {
        Console.WriteLine("===========\n史莱姆出现!\n===========");
        int playerHp = 100;
        int slimeHp = 50;
        int hpPotion = 25;//设定玩家血量,怪物血量,以及药剂血量这些固定值
        int o = 0;

        while (playerHp > 0 && slimeHp > 0)
        {
            o++;
            Console.WriteLine($"\n=======\n第{o}回合\n=======\n1.攻击\n2.闪避\n3.回血\n");

            int playerInput = int.Parse(Console.ReadLine());//等待玩家输出行动

            int slimeMove = Random.Shared.Next(0, 2);//先随机史莱姆的行为,0为攻击,1为闪避

            int playerPoint = Random.Shared.Next(1, 7);
            int slimePoint = Random.Shared.Next(1, 7);//随机双方掷骰子点数,如果点数为6会暴击,造成双倍伤害

            int playerAttack = Random.Shared.Next(8, 16);
            int slimeAttack = Random.Shared.Next(16, 25);//随机双方攻击力

            if (playerInput == 1)//动作1为掷骰子攻击,史莱姆会进行攻击闪避中随机一种的应对方式
            {
                Console.WriteLine("你发动了攻击!");
                ShowResult(playerPoint, slimePoint);//展示点数比对结果
                if (playerPoint > slimePoint)//若玩家先手
                {
                    ShowCritical(playerPoint, "你");//判定是否暴击

                    if(slimeMove == 1)
                    {
                        Console.WriteLine("史莱姆使用了闪避,此次攻击无效!");
                        continue;
                    }

                    ShowBattleResult(ref slimeHp, "你", "史莱姆", GetDamage(playerAttack, playerPoint));

                    if (slimeHp == 0)//判定史莱姆是否死亡，死亡则无法做出行为,跳出循环
                    {
                        break;
                    }

                    ShowCritical(slimePoint, "史莱姆");//判定是否暴击

                    ShowBattleResult(ref playerHp, "史莱姆", "你", GetDamage(slimeAttack, slimePoint));
                }
                else if (slimePoint > playerPoint)//若史莱姆先手
                {
                    if (slimeMove == 1)//若史莱姆闪避,因为是先手,所以没有闪避到攻击
                    {
                        Console.WriteLine("史莱姆使用了闪避!但似乎没有效果!");
                    }
                    else//史莱姆攻击
                    {
                        ShowCritical(slimePoint, "史莱姆");//判定是否暴击

                        ShowBattleResult(ref playerHp , "史莱姆" , "你" , GetDamage(slimeAttack, slimePoint));

                        if (playerHp == 0)//判断是否死亡
                        {
                            break;
                        }
                    }

                    ShowCritical(playerPoint, "你");//玩家回合,判定是否暴击

                    ShowBattleResult(ref slimeHp, "你", "史莱姆", GetDamage(playerAttack, playerPoint));
                }
                else if (playerPoint == slimePoint)//若双方点数相同
                {
                    if (slimeMove == 0)//若史莱姆攻击
                    {
                        ShowCritical(slimePoint, "史莱姆");//先判定是否暴击

                        ShowBattleResult(ref playerHp, "史莱姆", "你", GetDamage(slimeAttack, slimePoint));

                        ShowCritical(playerPoint, "你");//判定玩家暴击

                        ShowBattleResult(ref slimeHp, "你", "史莱姆", GetDamage(playerAttack, playerPoint));
                    }
                    if (slimeMove == 1)//若史莱姆进行闪避
                    {
                        ShowCritical(playerPoint, "你");

                        Console.WriteLine("史莱姆闪避了你的攻击,此次攻击无效!");
                    }
                }
            }

            else if (playerInput == 2)//若玩家闪避
            {
                Console.WriteLine("你使用了闪避!");
                ShowResult(playerPoint, slimePoint);
                if (slimeMove == 1)//若史莱姆闪避
                {
                    Console.WriteLine("史莱姆使用了闪避!");
                }

                if (slimeMove == 0)//若史莱姆攻击
                {
                    if (slimePoint >= playerPoint)//若史莱姆先手与同时出手都会被闪避
                    {

                        ShowCritical(slimePoint, "史莱姆");//判定暴击

                        Console.WriteLine("你闪避了对方的攻击!");
                    }
                    else//若玩家先手
                    {
                        Console.WriteLine("闪避失效!似乎没有作用!");

                        ShowCritical(slimePoint, "史莱姆");

                        ShowBattleResult(ref playerHp, "史莱姆", "你", GetDamage(slimeAttack, slimePoint));
                    }
                }
            }

            else if (playerInput == 3)//若玩家回血
            {
                Console.WriteLine("你使用了药剂!");
                ShowResult(playerPoint, slimePoint);

                if (slimePoint > playerPoint)//若史莱姆先手
                {
                    if (slimeMove == 0)//若史莱姆攻击
                    {
                        Console.WriteLine("史莱姆发动了攻击!");

                        ShowCritical(slimePoint , "史莱姆");//判定暴击

                        ShowBattleResult(ref playerHp, "史莱姆", "你", GetDamage(slimeAttack, slimePoint));

                        if (playerHp == 0)//判定玩家是否死亡
                        {
                            continue;
                        }

                        playerHp += hpPotion;//玩家回血

                        FixHp(ref playerHp);//设置血量上限

                        Console.WriteLine($"回复25点HP,你当前的HP:{playerHp}");
                    }
                    else//若史莱姆闪避
                    {
                        Console.WriteLine("史莱姆使用了闪避!但似乎没有效果!");

                        playerHp += hpPotion;//玩家回血

                        FixHp(ref playerHp);//设置血量上限

                        Console.WriteLine($"回复25点HP,你当前的HP:{playerHp}");
                    }
                }

                if (slimePoint < playerPoint)//若史莱姆后手
                {
                    playerHp += hpPotion;//玩家回血

                    FixHp(ref playerHp);//设置血量上限

                    Console.WriteLine($"回复25点HP,你当前的HP:{playerHp}");

                    if (slimeMove == 0)//若史莱姆攻击
                    {
                        Console.WriteLine("史莱姆发动了攻击!");

                        ShowCritical(slimePoint, "史莱姆");//判定暴击

                        ShowBattleResult(ref playerHp, "史莱姆", "你", GetDamage(slimeAttack, slimePoint));
                    }
                    else//若史莱姆闪避
                    {
                        Console.WriteLine("史莱姆使用了闪避!但似乎没有效果!");
                    }
                }

                if (slimePoint == playerPoint)//双方同时行动
                {
                    if (slimeMove == 0)//若史莱姆攻击
                    {
                        Console.WriteLine("史莱姆发动了攻击!");

                        ShowCritical(slimePoint, "史莱姆");//判定暴击

                        ShowBattleResult(ref playerHp, "史莱姆", "你", GetDamage(slimeAttack, slimePoint));

                        playerHp += hpPotion;//玩家回血

                        FixHp(ref playerHp);//设置血量上限

                        Console.WriteLine($"回复25点HP,你当前的HP:{playerHp}");
                    }
                    else//若史莱姆闪避
                    {
                        Console.WriteLine("史莱姆使用了闪避!但似乎没有效果!");

                        playerHp += hpPotion;//玩家回血

                        FixHp(ref playerHp);

                        Console.WriteLine($"回复25点HP,你当前的HP:{playerHp}");
                    }
                }
            }
        }
        if (playerHp == 0)
        {
            Console.WriteLine("\n玩家死亡");
        }

        if (slimeHp == 0)
        {
            Console.WriteLine("\n史莱姆死亡");
        }
    }
}