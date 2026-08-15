Family family = new();
family.Produce();
Player player = new Player();
player.SwitchAttack();

class Family
{
    public void Cook()
    {
        Console.WriteLine("做饭");
    }
    public void Finish()
    {
        Console.WriteLine("开饭");
    }
    public void Eat()
    {
        Console.WriteLine("吃饭");
    }

    public void Produce()
    {
        Action action = Cook;
        action += Finish;
        action += Eat;
        action();
    }
}

class Player
{
    public void Attack()
    {
        Console.WriteLine("普通攻击");
    }
    public void HeavyAttack()
    {
        Console.WriteLine("暴击");
    }
    public void MagicAttack()
    {
        Console.WriteLine("技能攻击");
    }
    Action action;
    public void SwitchAttack()
    {
        Console.WriteLine("1.普通攻击\n2.暴击\n3.技能攻击");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int i))
        {
            switch (i)
            {
                case 1:
                    action = Attack;
                    action();
                    break;
                case 2:
                    action = HeavyAttack;
                    action();
                    break;
                case 3:
                    action = MagicAttack;
                    action();
                    break;
            }
        }
        else
        {
            Console.WriteLine("输入的不合法!");
            return;
        }
    }
}