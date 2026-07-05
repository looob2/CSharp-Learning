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

    int slimeMove = Random.Shared.Next(0,2);//先随机史莱姆的行为,0为攻击,1为闪避

    int playerPoint = Random.Shared.Next(1, 7);
    int slimePoint = Random.Shared.Next(1, 7);//随机双方掷骰子点数,如果点数为6会暴击,造成双倍伤害

    int playerAttack = Random.Shared.Next(8, 16);
    int slimeAttack = Random.Shared.Next(16, 25);//随机双方攻击力

    if (playerInput == 1)//动作1为掷骰子攻击,史莱姆会进行攻击闪避中随机一种的应对方式
    {
        Console.WriteLine("你发动了攻击!");
        if (playerPoint > slimePoint)//若玩家先手
        {
            Console.WriteLine("你先手!");
            if (playerPoint == 6)//判定是否暴击
            {
                Console.WriteLine("你暴击了!");
                if (slimeMove == 1)//史莱姆闪避则攻击无效
                {
                    Console.WriteLine("史莱姆闪避了你的攻击,此次攻击无效!");
                    continue;
                }
                slimeHp -= playerAttack * 2;
            }
            else
            {
                if (slimeMove == 1)
                {
                    Console.WriteLine("史莱姆闪避了你的攻击,此次攻击无效!");
                    continue;
                }
                slimeHp -= playerAttack;
            }

            if (slimeHp < 0)//如果血量为负则修正为0
            {
                slimeHp = 0;
            }

            if (playerPoint == 6)
            {
                Console.WriteLine($"你对史莱姆造成{playerAttack*2}点伤害!\n对方剩余HP:{slimeHp}");
            }
            else
            {
                Console.WriteLine($"你对史莱姆造成{playerAttack}点伤害!\n对方剩余HP:{slimeHp}");
            }

            if (slimeHp == 0)//判定史莱姆是否死亡，死亡则无法做出行为,跳出循环
            {
                break;
            }

            if (slimeMove == 0)//判定史莱姆行动
            {
                if (slimePoint == 6)//判定是否暴击
                {
                    Console.WriteLine("史莱姆暴击了!");
                    playerHp -= slimeAttack * 2;
                }
                else
                {
                    playerHp -= slimeAttack;
                }
            }

            if (playerHp < 0)//如果血量为0则修正为0
            {
                playerHp = 0;
            }

            if (slimePoint == 6)
            {
                Console.WriteLine($"史莱姆对你造成{slimeAttack * 2}点伤害!\n你剩余HP:{playerHp}");
            }
            else
            {
                Console.WriteLine($"史莱姆对你造成{slimeAttack}点伤害!\n你剩余HP:{playerHp}");
            }
        }
        else if(slimePoint > playerPoint)//若史莱姆先手
        {
            Console.WriteLine("对方先手!");
            if (slimeMove == 1)//若史莱姆闪避,因为是先手,所以没有闪避到攻击
            {
                Console.WriteLine("史莱姆使用了闪避!但似乎没有效果!");
            }

            if (slimeMove == 0)//史莱姆攻击
            {
                if (slimePoint == 6)//判定是否暴击
                {
                    Console.WriteLine("史莱姆暴击了!");
                    playerHp -= slimeAttack * 2;
                }
                else
                {
                    playerHp -= slimeAttack;
                }
            }

            if (playerHp < 0)//修正血量为0
            {
                playerHp = 0;
            }

            if(slimeMove == 0)//这里需要判定史莱姆是否为攻击行为,否则在闪避后仍会攻击玩家
            {
                if (slimePoint == 6)
                {
                    Console.WriteLine($"史莱姆对你造成{slimeAttack * 2}点伤害!\n你剩余HP:{playerHp}");
                }
                else
                {
                    Console.WriteLine($"史莱姆对你造成{slimeAttack}点伤害!\n你剩余HP:{playerHp}");
                }
            }

            if (playerHp == 0)//判断是否死亡
            {
                break;
            }

            if (playerPoint == 6)//判定是否暴击
            {
                Console.WriteLine("你暴击了!");
                slimeHp -= playerAttack * 2;
            }
            else
            {
                slimeHp -= playerAttack;
            }

            if (slimeHp < 0)//如果血量为负则修正为0
            {
                slimeHp = 0;
            }

            if (playerPoint == 6)
            {
                Console.WriteLine($"你对史莱姆造成{playerAttack * 2}点伤害!\n对方剩余HP:{slimeHp}");
            }
            else
            {
                Console.WriteLine($"你对史莱姆造成{playerAttack}点伤害!\n对方剩余HP:{slimeHp}");
            }
        }
        else if(playerPoint == slimePoint)
        {
            Console.WriteLine("双方点数相同重投");
            continue;
        }

    if (playerInput == 2)//若玩家闪避
        {
            Console.WriteLine("");
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