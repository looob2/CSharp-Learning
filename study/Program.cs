namespace study
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("请输入玩家名称");
            string name = Console.ReadLine();
            Console.WriteLine("请输入玩家年龄");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n欢迎{name}!");
            Console.WriteLine($"年龄{age}岁");

            Console.WriteLine("");
            int hp = int.Parse(Console.ReadLine());
            if (hp <= 0)
            {
                Console.WriteLine("GameOver");
            }
            else
            {
                Console.WriteLine("Alive");
            }

            Console.WriteLine("");
            Console.WriteLine("输入攻击力:");
            int attack = int.Parse(Console.ReadLine());
            Console.WriteLine("输入敌人血量:");
            int bossHp = int.Parse(Console.ReadLine());
            int remainHp = bossHp - attack;
            Console.WriteLine($"敌人剩余血量:{remainHp}");

        }
    }
}
