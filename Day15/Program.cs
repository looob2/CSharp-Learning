using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

class Creature//生物类的基类
{
    public Creature(string name, int hp, int attack)
    {
        Name = name;
        Hp = hp;
        Attack = attack;
        MaxHp = hp;
    }
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Attack {  get; set; }
    public int MaxHp { get; set; }
}
class Player : Creature
{
    public Player(string name, int hp, int attack) : base(name, hp, attack) { }

    public void Use(Weapon weapon)//方法重载,Use可以用于Weapon与Potion
    {
        Attack += weapon.Attack;
        Console.WriteLine($"装备了武器!目前攻击力:{Attack}");
    }
    public void TakeOff(Weapon weapon)
    {
        Attack -= weapon.Attack;
        Console.WriteLine($"卸下了装备{weapon.Name}!目前攻击力:{Attack}");
    }
    public void Use(Potion potion)
    {
        Hp += potion.AddHp;
        if (Hp > MaxHp)//修正血量,使其不超过上限
        {
            Hp = MaxHp;
        }
        Console.WriteLine($"喝下了药水!目前HP:{Hp}");
        potion.Count--;
    }
}
class Item//物品类的基类
{
    public string Name { get; set; }
    public int Count { get; set; }
    public Item (string name , int count = 1)
    {
        Name = name;
        Count = count;
    }
}
class Weapon : Item
{
    public Weapon(string name , int attack , int count) : base(name , count)
    {
        Attack = attack;
    }
    public int Attack { get; set; }

    public void WeaponInfo()//展示信息
    {
        Console.WriteLine($"\n武器信息:{Name}\nATK:{Attack}\n数量:{Count}\n1.装备武器2.丢弃3.返回");
    }
}
class Potion : Item
{
    public Potion(string name , int addhp , int count) : base(name , count)
    {
        AddHp = addhp;
    }
    public int AddHp { get; set; }

    public void PotionInfo()//展示信息
    {
        Console.WriteLine($"\n药品信息:{Name}\nATK:{AddHp}\n数量:{Count}\n1.喝下药水2.丢弃3.返回");
    }
}
class Package
{
    private List<Item> items = new List<Item>();//创建Item类的List<>数组,存放物品

    public void Add(Item item)//获取物品
    {
        items.Add(item);
        Console.WriteLine($"获取{item.Name}!数量:{item.Count}");
    }

    private List<Weapon> items_weapon = new List<Weapon>();//创建武器数组,用来存放装备在身上的武器

    private void Add_Weapon(Weapon weapon)
    {
        items_weapon.Add(weapon);
    }

    public void PackageInfo(Player player)//展示背包信息
    {
        Console.WriteLine("\n背包信息");
        for (int i = 0; i < items.Count; i++)//i是items[]中检索的序号
        {
            Item item = items[i];//创建一个Item类的item,这样不管是Weapon还是Potion都可以存放进来
            Console.WriteLine((i+1) + "." + item.Name);
        }

        int input_package = int.Parse(Console.ReadLine()) - 1;//数组是从0开始的,所以跟界面展示的数字不同,需要-1
        if (items[input_package] is Weapon weapon)//如果对应的为Weapon类
        {
            weapon.WeaponInfo();//展示物品信息
            int input_item = int.Parse(Console.ReadLine());//输入数字来选择物品
            if (input_item == 1)//使用物品
            {
                Add_Weapon(weapon);//添加物品到装备栏

                if (items_weapon[0] != weapon)
                {
                    Add(items_weapon[0]);//卸下来的装备放回背包
                    player.TakeOff(items_weapon[0]);//减攻击力
                    items_weapon.RemoveAt(0);//从装备栏中移除
                }

                player.Use(weapon);

                items.RemoveAt(input_package);//直接移出数组

                PackageInfo(player);//返回菜单
            }
            else if (input_item == 2)//丢弃
            {
                Discard(weapon);
                if (weapon.Count == 0)
                {
                    items.RemoveAt(input_package);
                }
                PackageInfo(player);
            }
            else if (input_item == 3)//返回
            {
                PackageInfo(player);
            }
        }
        else if (items[input_package] is Potion potion)//如果对应的为Potion类
        {
            potion.PotionInfo();//展示物品信息
            int input_item = int.Parse(Console.ReadLine());//输入数字来选择物品
            if (input_item == 1)//使用物品
            {
                player.Use(potion);
                if (potion.Count == 0)//检测数量是否为零,为零则移出数组
                {
                    items.RemoveAt(input_package);
                }
                PackageInfo(player);//返回菜单
            }
            else if (input_item == 2)//丢弃
            {
                Discard(potion);
                if (potion.Count == 0)
                {
                    items.RemoveAt(input_package);
                }
                PackageInfo(player);
            }
            else if (input_item == 3)//返回
            {
                PackageInfo(player);
            }
        }
    }

    public void Discard(Item item)//丢弃物品
    {
        Console.WriteLine("请输入要丢弃物品的数量:");
        int input_discard = int.Parse(Console.ReadLine());

        if (input_discard > item.Count)//防止输入的数字大于物品的数量
        {
            input_discard = item.Count;
        }

        item.Count -= input_discard;
    }
}
class Program
{
    public static void Main()
    {
        Player player = new Player("Tom" , 100 , 5);
        Package package = new Package();
        package.Add(new Weapon("木剑", 5 , 1));
        package.Add(new Potion("初级治疗药水" , 10, 2));
        package.Add(new Potion("高级治疗药水", 50, 3));
        package.Add(new Weapon("铁剑", 10, 1));

        package.PackageInfo(player);
    }
}